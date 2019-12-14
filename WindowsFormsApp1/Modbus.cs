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
        SqlCommand cmd;

        public ModbusClient modbusClient = new ModbusClient() { IPAddress = "192.168.2.86", Port = 502 };

        public Modbus()
        {
            modbusClient.Connect();
            modbusClient.ConnectedChanged += new ConnectedChangedHandler(UpdateConnectedChanged);
            cmd = new SqlCommand();

            
        }

        public void UpdateConnectedChanged(object sender)
        {

            IntPtr m = Application.OpenForms["TwistMainFormCUI"].Handle;

            //MenuStrip menuStrip = Forms.TwistMainFormCUI.FromHandle(m).Controls.Find("menuStrip1", true).FirstOrDefault() as MenuStrip;
            //Button btn_DisConnect = Forms.ListProductsForm.FromHandle(m).Controls.Find("btn_DisConnect", true).FirstOrDefault() as Button;
            //Button btn_Connect = Forms.ListProductsForm.FromHandle(m).Controls.Find("btn_Connect", true).FirstOrDefault() as Button;
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
        
        //public static void UpdateConnectionChanged<T>(T form) where T: Form 
        //{
        //    IntPtr m = Application.OpenForms[form.Name].Handle;

           

        //    T menuStrip = form.FromHandle(m).Controls.Find("btn_Connect", true).FirstOrDefault() as T;
        //    Button btn_DisConnect = MainFormCUI.FromHandle(m).Controls.Find("btn_DisConnect", true).FirstOrDefault() as Button;
        //    Label lb_ConnectionInfo = MainFormCUI.FromHandle(m).Controls.Find("lb_ConnectionStatus", true).FirstOrDefault() as Label;


        //    if (modbusClient.Connected)
        //    {
        //        lb_ConnectionInfo.Text = "Bağlandı!";
        //        menuStrip.Items["ConnectToolStripMenuItem"].Enabled = false;
        //        menuStrip.Items["DisConnectToolStripMenuItem"].Enabled = true;
        //        menuStrip.Items["ConnectToolStripMenuItem"].BackColor = Color.Gray;
        //        menuStrip.Items["DisConnectToolStripMenuItem"].BackColor = Color.DeepSkyBlue;
        //    }
        //    else
        //    {
        //        lb_ConnectionInfo.Text = "Bağlı değil!";
        //        menuStrip.Items["ConnectToolStripMenuItem"].Enabled = true;
        //        menuStrip.Items["DisConnectToolStripMenuItem"].Enabled = false;
        //        menuStrip.Items["ConnectToolStripMenuItem"].BackColor = Color.DeepSkyBlue;
        //        menuStrip.Items["DisConnectToolStripMenuItem"].BackColor = Color.Gray;
        //        MessageBox.Show("Bağlantı koptu!");
        //    }
        //}


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

        public void ChangeControlsInfo()
        {

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

    }
}
