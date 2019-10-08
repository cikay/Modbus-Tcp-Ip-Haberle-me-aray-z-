using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace WindowsFormsApp1
{
    internal class Modbus
    {
        static ModbusClient modbusClient;

        static internal void Connect(Label lb_ConnectionStatus)
        {
            try
            {
                modbusClient = new ModbusClient("192.168.2.76", 502);
                modbusClient.Connect();
                modbusClient.WriteMultipleCoils(0, new bool[] { true, true, true, true, true, true, true, true, true, true });    //Write Coils starting with Address 5
                lb_ConnectionStatus.Text = "Connected via Modbus Tcp/Ip Protokol";
               
               
            }
            catch(Exception ex)
            {
                lb_ConnectionStatus.Text = "Can not connact!";
            }

          
        }



        static internal void DisConnect(Label lb_ConnectionStatus)
        {
            try
            {

                modbusClient.Disconnect();
                lb_ConnectionStatus.Text = "Not connect";
            }
            catch
            {

            }

           
        }

        internal void Write(int adress, int value)
        {
            modbusClient.WriteSingleRegister(adress, value);
        }

    }
}
