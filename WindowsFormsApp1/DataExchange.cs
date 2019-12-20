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
            Values = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.AccessSystem, 1);
            try
            {
                if (Values[0] == (int)AccessSystem.onay)
                {
                    controls.lbAccesSystem.Text = "Sisteme erişim sağlandı";

                    int[] reqData = new int[] { (int)RequestData.talep, (int)controls.requestDataType, (int)controls.comType, (int)DataStatus.musait, (int)DataStatus.musait, (int)DataStatus.musait };

                    modbus.modbusClient.WriteMultipleRegisters((int)RegisterAdress.RequestData, reqData); //veri talebi
                    modbus.modbusClient.WriteSingleCoil(135, true);
                    Thread.Sleep(200);
                    Values = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.RequestData, 4); //veri talebi durumu

                    if (Values[0] == (int)RequestData.onay)
                    {
                        if (Values[2] == (int)commandType.read)
                        {
                            if (Values[1] == (int)RequestDataType.users)
                            {
                                return DataTypeComStatus.readableAccounts;
                            }
                            else if (Values[1] == (int)RequestDataType.products)
                            {
                               
                                return DataTypeComStatus.readableProducts;
                            }
                            else if (Values[1] == (int)RequestDataType.cables)
                            {
                                
                                return DataTypeComStatus.readableCables;
                            }
                        }
                        else if (Values[2] == (int)commandType.write)
                        {
                            if (Values[1] == (int)RequestDataType.users)
                            {
                                
                                return DataTypeComStatus.writeableAccounts;

                            }
                            else if (Values[1] == (int)RequestDataType.products)
                            {
                                return DataTypeComStatus.writeableProducts;
                            }
                            else if (Values[1] == (int)RequestDataType.cables)
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
                
                Thread.Sleep(250);
            }
            catch (Exception)
            {
                MessageBox.Show("Haberleşme yapılamıyor!");
            }

            return DataTypeComStatus.Non;
        }

        public void SendData<T>(T data) 
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

        public Dictionary<int, T> GetData<T>()
        {
            
            Dictionary<int, T> DataCollection = new Dictionary<int, T>();
            
            int[] veriDurumu =modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataStatus, 1);
            if (veriDurumu[0] != (int)DataStatus.hazir)
            {
                DataCollection = null;
                return DataCollection;
            }

            int[] AccountCount = modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataCount, 1);
            PropertyInfo[] Properties = typeof(T).GetProperties();
            string stringValue=string.Empty;
           
            int Increment = 0;

            int startingAdress=0;
            for (int i = 0; i < AccountCount[0]; i++)
            {
                T data = Activator.CreateInstance<T>();
                if (i == 0)
                {
                    Increment = 0;

                }
                else if (i == 1)
                {
                    foreach (var inc in Properties)
                    {
                        if (string.Compare(inc.Name, "Increment") == 0)
                        {
                            Increment = (int)inc.GetValue(data);
                            break;
                        }
                    }
                }

                foreach (var prop in Properties)
                {
                   
                    if (string.Compare(prop.Name, "Increment") == 0)
                    {
                        continue;
                    }

                    Parameters parameters = (Parameters)(prop.GetValue(data));
                    int length = Convert.ToInt32(parameters.Length);
                    startingAdress += Convert.ToInt32(parameters.StartingAdress);
                    

                    int[] registerValues = modbus.modbusClient.ReadHoldingRegisters(5000+Increment+startingAdress, length);

                    if (parameters.ConvertToAsciiString)
                    {
                        stringValue = ModbusClient.ConvertRegistersToString(registerValues, 0, length);

                    }
                    else
                    {
                        //float[] fValues = new float[2*registerValues.Length];
                        //for (int index = 0; index < registerValues.Length; index++)
                        //{
                        //    fValues[i] = Convert.ToSingle(registerValues[i]);
                            
                        //}
                        stringValue = string.Join("", registerValues);

                    }
                    
                    //if (!prop.Equals(Properties.Last()))
                    //{
                    //    startingAdress -= Convert.ToInt32(parameters.StartingAdress);
                    //}
                    startingAdress -= Convert.ToInt32(parameters.StartingAdress);
                    parameters.Value = stringValue;

                }
                
                startingAdress += Increment;
                DataCollection.Add(i, data);
            }
            int[] alindi = { (int)DataStatus.alindi };
            modbus.modbusClient.WriteMultipleRegisters((int)RegisterAdress.DataStatus, alindi);
            return DataCollection;
        }


    }
}
