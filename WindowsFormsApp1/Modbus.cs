using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            try
            {
                modbusClient.Connect();
            }
            catch (Exception)
            {
                MessageBox.Show("Bağlantı sağlanamadı!");
            }
            
            modbusClient.ConnectedChanged += new ConnectedChangedHandler(UpdateConnectedChanged);
        }

        public void UpdateConnectedChanged(object sender)
        {

            ConnectionStatus();
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

        public void DisConnect(Label lb_ConnectionStatus)
        {
            
            try
            {
                modbusClient.Disconnect();
                lb_ConnectionStatus.Text = "Bağlı değil!";
            }
            catch
            {
                MessageBox.Show("Bağlantı kesilemedi!!");
            }
        }

        public void ConnectionStatus()
        {
            try
            {
                IntPtr m = Application.OpenForms["TwistMainFormCUI"].Handle;
                ToolStrip tStrip_Connection = Forms.TwistMainFormCUI.FromHandle(m).Controls.Find("tStrip_Connection", true).FirstOrDefault() as ToolStrip;
                ToolStripItem Label_ConnectionStatus = tStrip_Connection.Items["tStripL_ConnectionStatus"];
                ToolStripItem Btn_Connect = tStrip_Connection.Items["tStripBtn_Connect"];
                ToolStripItem Btn_DisConnect = tStrip_Connection.Items["tStripBtn_DisConnect"];
                if (modbusClient.Connected)
                {
                    Label_ConnectionStatus.Text = "!Bağlandı";
                    Btn_Connect.Enabled = false;
                    Btn_DisConnect.Enabled = true;
                    Btn_Connect.BackColor = Color.Gray;
                    Btn_DisConnect.BackColor = Color.DeepSkyBlue;
                }
                else
                {
                    Label_ConnectionStatus.Text = "!Bağlı değil";
                    Btn_Connect.Enabled = true;
                    Btn_DisConnect.Enabled = false;
                    Btn_Connect.BackColor = Color.DeepSkyBlue;
                    Btn_DisConnect.BackColor = Color.Gray;
                    MessageBox.Show("Bağlantı koptu!");
                }
            }
            catch (Exception)
            {

                throw;
            }
      
           
        }


    }
}
