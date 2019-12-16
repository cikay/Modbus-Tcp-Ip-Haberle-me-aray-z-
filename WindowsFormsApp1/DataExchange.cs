using EasyModbus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;
using System.Reflection;

namespace WindowsFormsApp1
{
    public class DataExchange
    {
        public Modbus modbus = new Modbus();
     
        public DataTypeComStatus DataExchangeProtocol(SystemInfoControls controls)
        {
            int[] Values = new int[100];

          
            if (Values[0] != (int)AccessSystem.onay)
            {
                controls.lbAccesSystem.Text = "Sisteme erişim yok";
                modbus.modbusClient.WriteSingleRegister((int)RegisterAdress.AccessSystem, (int)AccessSystem.talep); //sistem erişim talebi
                modbus.modbusClient.WriteSingleCoil(135, true);
                Thread.Sleep(250);

            }
            try
            {
                if (Values[0] == (int)AccessSystem.onay)
                {
                    controls.lbAccesSystem.Text = "Sisteme erişim sağlandı";

                    int[] reqData = new int[] { (int)RequestData.talep, (int)controls.requestDataType, (int)controls.comType };

                    modbus.modbusClient.WriteMultipleRegisters((int)RegisterAdress.RequestData, reqData); //veri talebi
                    modbus.modbusClient.WriteSingleCoil(135, true);
                    Thread.Sleep(250);
                    Values = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.RequestData, 3); //veri talebi durumu

                    if (Values[0] == (int)RequestData.onay)
                    {
                        if (controls.comType == commandType.read)
                        {
                            if (controls.requestDataType == RequestDataType.users)
                            {
                                return (int)DataTypeComStatus.readableAccounts;
                            }
                            else if (controls.requestDataType == RequestDataType.products)
                            {
                                return DataTypeComStatus.readableProducts;
                            }
                            else if (controls.requestDataType == RequestDataType.cables)
                            {
                                return DataTypeComStatus.readableCables;
                            }
                        }
                        else if (controls.comType == commandType.write)
                        {
                            if (controls.requestDataType == RequestDataType.users)
                            {
                                return DataTypeComStatus.writeableAccounts;
                            }
                            else if (controls.requestDataType == RequestDataType.products)
                            {
                                return DataTypeComStatus.writeableProducts;
                            }
                            else if (controls.requestDataType == RequestDataType.cables)
                            {
                                return DataTypeComStatus.writeableCables;
                            }
                        }
                        controls.lbRequestData.Text = "Veri talebi onaylandı";

                    }
                    else if (Values[0] == (int)RequestData.red)
                    {
                        controls.lbRequestData.Text = "Veri talebi reddedildi!";
                    }
                }
                else if (Values[0] == (int)AccessSystem.red)
                {
                    controls.lbAccesSystem.Text = "Sistem erişim talebi reddedildi!";
                }
                Values = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.AccessSystem, 4); //sistem erişim durumu
                modbus.modbusClient.WriteSingleRegister((int)RegisterAdress.DataStatus, 0); //veri talebi
                modbus.modbusClient.WriteSingleCoil(135, true);
                Thread.Sleep(250);
            }
            catch (Exception)
            {
                MessageBox.Show("Haberleşme yapılamıyor!");
            }

            return DataTypeComStatus.Non;
        }

        public void ListUsers(ref SystemInfoControls controls)
        {

            int[] AccountCount = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataCount, 1);

            int[] dataStatus = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataStatus, 1);

            int[] Values = new int[120];


            for (int i = 0; i < AccountCount[0]; i++)
            {
                int increment = i * 30;

                if (increment % 120 == 0)
                {
                    Values = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.usersDataOffSet + increment, 120);
                    increment = 0;
                }

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ModbusClient.ConvertRegistersToString(Values, increment % 120, (int)EUser.nameLenght);
                lvi.SubItems.Add(ModbusClient.ConvertRegistersToString(Values, 13 + (increment % 120), (int)EUser.barcodPinLength));
                lvi.SubItems.Add(Values[27 + (increment % 120)].ToString());
                lvi.SubItems.Add(Values[28 + (increment % 120)].ToString());
                lvi.SubItems.Add(Values[29 + (increment % 120)].ToString());
                controls.lV_Users.Items.Add(lvi);

            }

            modbus.modbusClient.WriteSingleRegister((int)RegisterAdress.DataStatus, 2);
            modbus.modbusClient.WriteSingleCoil(135, true);
            Thread.Sleep(250);
        }

        public void Add<T>(T data) 
        {
            PropertyInfo[] Properties = typeof(T).GetProperties();

            foreach(var prop in Properties)
            {

                Parameters parameters = (Parameters)(prop.GetValue(data));
                int StartingAdress = Convert.ToInt32(parameters.StartingAdress);
                
                byte[] byteArray= Encoding.ASCII.GetBytes(parameters.Value);
                int[] intArray = new int[byteArray.Length];

                for (int i = 0; i < byteArray.Length; i++) intArray[i] =(int)byteArray[i];

                modbus.modbusClient.WriteMultipleRegisters(StartingAdress, intArray);

            }
        }

        public Dictionary<int, T> ListProduct<T>()
        {
            T data=Activator.CreateInstance<T>();
            Dictionary<int, T> DataCollection = new Dictionary<int, T>();
            int[] AccountCount = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataCount, 1);
            PropertyInfo[] Properties = typeof(T).GetProperties();
            string stringValue;

            for (int i = 0; i < AccountCount[0]; i++)
            {
                foreach (var prop in Properties)
                {

                    Parameters parameters = (Parameters)(prop.GetValue(data));
                    int length = Convert.ToInt32(parameters.Length);
                    int startingAdress = Convert.ToInt32(parameters.StartingAdress);

                    int[] registerValues = modbus.modbusClient.ReadHoldingRegisters(5000 + startingAdress, length);


                    if (parameters.ConvertToAsciiString)
                    {
                        stringValue = ModbusClient.ConvertRegistersToString(registerValues, 0, length);

                    }
                    else
                    {
                        stringValue = string.Join("", registerValues);
                    }

                    parameters.Value = stringValue;
                    

                }
                DataCollection.Add(i, data);
            }
            //foreach (var prop in Properties)
            //{

            //    Parameters parameters = (Parameters)(prop.GetValue(data));
            //    int length = Convert.ToInt32(parameters.Length);
            //    int startingAdress = Convert.ToInt32(parameters.StartingAdress);

            //    int[] registerValues = modbus.modbusClient.ReadHoldingRegisters(5000 + startingAdress, length);


            //    if (parameters.ConvertToAsciiString)
            //    {
            //        stringValue = ModbusClient.ConvertRegistersToString(registerValues, 0, length);

            //    }
            //    else
            //    {
            //        stringValue = string.Join("", registerValues);
            //    }

            //    parameters.Value = stringValue;

            //}

            return DataCollection;
        }
    }
}
