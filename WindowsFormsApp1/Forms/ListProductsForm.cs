using System;
using System.Timers;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;
using Timer = System.Timers.Timer;
using WindowsFormsApp1.Enums;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace WindowsFormsApp1.Forms
{
    public partial class ListProductsForm : Form
    {

        Timer timer_SytemAccessInfo=new Timer();
        Timer timer_ProductionStatus = new Timer();
        ListViewItem lVI_Urun = new ListViewItem();
        Global global = new Global();

        public ListProductsForm()
        {
           
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            timer_SytemAccessInfo.Enabled = true;
            timer_SytemAccessInfo.Interval = 3*60*100;
            timer_SytemAccessInfo.Start();
            timer_SytemAccessInfo.Elapsed += timer_SytemAccessInfo_Elapsed;

            timer_ProductionStatus.Enabled = true;
            timer_ProductionStatus.Interval = 60000;
            timer_ProductionStatus.Start();
            timer_ProductionStatus.Elapsed += timer_ProductionStatus_Elapsed;
        }

        private void timer_ProductionStatus_Elapsed(object sender, ElapsedEventArgs e)
        {
            //ProductionStatus();
        }

        private void timer_SytemAccessInfo_Elapsed(object sender, ElapsedEventArgs e)
        {
            //timer_SytemAccessInfo = new Thread(new ThreadStart(UpdateListProducts));
            //timer_SytemAccessInfo.Start();
            //ConnectionControl();

        }

        private void ListProductsForm_Load(object sender, EventArgs e)
        {

            lVI_Urun.Text = "Muzaffer";
            lV_UrunListele.Items.Add(lVI_Urun);
            global.dataExchange.modbus.modbusClient.Connect();
           
            if (global.dataExchange.modbus.modbusClient.Connected) DataExchangeProtocol();
            else MessageBox.Show("Bağlantı yok");
  
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            global.dataExchange.modbus.modbusClient.Connect();
            if (!global.dataExchange.modbus.modbusClient.Connected) MessageBox.Show("bağlantı yapılamadı");
        }


        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            global.dataExchange.modbus.modbusClient.Disconnect();
            if (!global.dataExchange.modbus.modbusClient.Connected) lb_ConnectionStatus.Text = "Bağlı değil!";
        }

        private void DataExchangeProtocol()
        {
            int[] Values = new int[100];
            if (Values[0] != (int)AccessSystem.onay)
            {
                lbAccesSystem.Text = "Sisteme erişim yok";
                global.dataExchange.modbus.modbusClient.WriteSingleRegister((int)RegisterAdress.AccessSystem, (int)AccessSystem.talep); //sistem erişim talebi
                global.dataExchange.modbus.modbusClient.WriteSingleCoil(135, true);
                Thread.Sleep(250);
             
            }
            Values = global.dataExchange.modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.AccessSystem, 4); //sistem erişim durumu
            global.dataExchange.modbus.modbusClient.WriteSingleRegister((int)RegisterAdress.DataStatus, 0); //veri talebi
            global.dataExchange.modbus.modbusClient.WriteSingleCoil(135, true);
            Thread.Sleep(250);

            if (Values[0]== (int)AccessSystem.onay )
            {
                lbAccesSystem.Text="Sisteme erişim sağlandı";

                int[] reqData  = new int[] { (int)RequestData.talep, (int)commandType.read, (int)RequestDataType.users };

                global.dataExchange.modbus.modbusClient.WriteMultipleRegisters((int)RegisterAdress.RequestData, reqData); //veri talebi
                global.dataExchange.modbus.modbusClient.WriteSingleCoil(135, true);
                Thread.Sleep(250);
                Values = global.dataExchange.modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.RequestData, 2); //veri talebi durumu

                if (Values[0] == (int)RequestData.onay)
                {
                    lbRequestData.Text = "Veri talebi onaylandı";
                    ListUsers();
                }
                else if (Values[0] == (int)RequestData.red)
                {
                    lbRequestData.Text = "Veri talebi reddedildi!";
                }
            }
            else if (Values[0]==(int)AccessSystem.red)
            {
                lbAccesSystem.Text = "Sistem erişim talebi reddedildi!";
            }
        }

        private void ListUsers()
        {

            int[] AccountCount = global.dataExchange.modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataCount, 1);

            int[] dataStatus = global.dataExchange.modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataStatus, 1);

            int[] Values= new int[120];


            for (int i = 0; i < AccountCount[0]; i++)
            {
                int increment = i * 30;

                if (increment % 120 == 0)
                {
                    Values = global.dataExchange.modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.usersDataOffSet + increment, 120);
                    increment = 0;
                }

                ListViewItem lvi = new ListViewItem();
                lvi.Text = ModbusClient.ConvertRegistersToString(Values, increment%120, (int)EUser.nameLenght);
                lvi.SubItems.Add(ModbusClient.ConvertRegistersToString(Values, 13+ (increment % 120), (int)EUser.barcodPinLength));
                lvi.SubItems.Add(Values[27+ (increment % 120)].ToString());
                lvi.SubItems.Add(Values[28+ (increment % 120)].ToString());
                lvi.SubItems.Add(Values[29+ (increment % 120)].ToString());
                lV_Users.Items.Add(lvi);
                
            }


            global.dataExchange.modbus.modbusClient.WriteSingleRegister((int)RegisterAdress.DataStatus, 2);
            global.dataExchange.modbus.modbusClient.WriteSingleCoil(135, true);
            Thread.Sleep(250);
        }

        private void SystemCurrentValues()
        {
            if (global.dataExchange.modbus.modbusClient.Connected)
            {
                global.dataExchange.modbus.modbusClient.WriteMultipleRegisters((int)RegisterAdress.AccessSystem, new int[] { (int)AccessSystem.talep, (int)RequestData.talep});
                global.dataExchange.modbus.modbusClient.WriteSingleCoil(135, true);
                Thread.Sleep(250);
                int[] accessSystemInfo = global.dataExchange.modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.AccessSystem, 2);
                lbAccesSystem.Text=ModbusClient.ConvertRegistersToString(accessSystemInfo, 0, 1);//buralar değişecek
                lbRequestData.Text= ModbusClient.ConvertRegistersToString(accessSystemInfo, 1, 1);

                foreach(int currentData in (RequestCurrentDataType[])Enum.GetValues(typeof(RequestCurrentDataType)))
                {
                    global.dataExchange.modbus.modbusClient.WriteSingleRegister((int)RegisterAdress.DataType, currentData);
                    global.dataExchange.modbus.modbusClient.WriteSingleCoil(135, true);
                    Thread.Sleep(250);
                    int[] systemInfo = global.dataExchange.modbus.modbusClient.ReadHoldingRegisters((int)RegisterAdress.DataType, 1);
                    lbCurrentPage.Text = ModbusClient.ConvertRegistersToString(systemInfo, 0, 30);

                }

            }
        }

        private void btn_Connect_Click_1(object sender, EventArgs e)
        {
            try
            {
                global.dataExchange.modbus.modbusClient.Connect();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {

            if (lV_UrunListele.SelectedItems.Count == 0)
            {
                MessageBox.Show("lütfen bir seçim yapınız!");
                return;

            }

            int selectedIndex = lV_UrunListele.Items.IndexOf(lV_UrunListele.SelectedItems[0]);
            int[] WritingValues = new int[] { selectedIndex, Convert.ToInt32(tB_Quantity.Text) };

            global.dataExchange.modbus.modbusClient.WriteMultipleRegisters(0, WritingValues);
            global.dataExchange.modbus.modbusClient.WriteSingleCoil(135, true);
            Thread.Sleep(250);
            tB_Quantity.Text = string.Empty;
        }
    }

    
    
}
