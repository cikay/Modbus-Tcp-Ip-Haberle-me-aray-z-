using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace WindowsFormsApp1
{
    public class Modbus
    {
        public static ModbusClient modbusClient = new ModbusClient() { IPAddress = "192.168.2.76", Port = 502 };


        public static void Connect(Label lb_ConnectionStatus)
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



        internal static void DisConnect(Label lb_ConnectionStatus)
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

      

    }
}
