using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
using static EasyModbus.ModbusClient;

namespace WindowsFormsApp1
{
    public class Modbus
    {


        public ModbusClient modbusClient = new ModbusClient() { IPAddress = "192.168.2.86", Port = 502 };


        public Modbus()
        {
            modbusClient.ConnectedChanged += new ConnectedChangedHandler(UpdateConnectedChanged);
        }

        private void UpdateConnectedChanged(object sender)
        {
            IntPtr m = Application.OpenForms["ListProductsForm"].Handle;

            Button btn_Connect = Forms.ListProductsForm.FromHandle(m).Controls.Find("btn_Connect", true).FirstOrDefault() as Button;
            Button btn_DisConnect = Forms.ListProductsForm.FromHandle(m).Controls.Find("btn_DisConnect", true).FirstOrDefault() as Button;
            Label lb_ConnectionInfo = Forms.ListProductsForm.FromHandle(m).Controls.Find("lb_ConnectionStatus", true).FirstOrDefault() as Label;

            if (modbusClient.Connected)
            {
                lb_ConnectionInfo.Text = "Bağlandı!";
                btn_Connect.Enabled = false;
                btn_DisConnect.Enabled = true;
                btn_Connect.BackColor = Color.Gray;
                btn_DisConnect.BackColor = Color.DeepSkyBlue;
            }
            else
            {
                lb_ConnectionInfo.Text = "Bağlı değil!";
                btn_Connect.Enabled = true;
                btn_DisConnect.Enabled = false;
                btn_Connect.BackColor = Color.DeepSkyBlue;
                btn_DisConnect.BackColor = Color.Gray;
                MessageBox.Show("Bağlantı koptu!");
            }
        }

        public void Connect(Label lb_ConnectionStatus)
        {
            
            try
            {
                modbusClient.Connect();
                lb_ConnectionStatus.Text = "Bağlandı!";
            }
            catch(Exception ex)
            {
                lb_ConnectionStatus.Text = "Bağlanamadı!";
            }
        }



        internal void DisConnect(Label lb_ConnectionStatus)
        {
            try
            {
                modbusClient.Disconnect();
                lb_ConnectionStatus.Text = "Bağlı değil!";
            }
            catch
            {

            }
        }

        internal static void ConnectionStatus(Button btn_Connect, Button btn_DisConnect, Label lb_ConnectionInfo)
        {
           

        }
      

    }
}
