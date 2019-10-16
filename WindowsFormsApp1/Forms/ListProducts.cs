using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;
namespace WindowsFormsApp1.Forms
{
    public partial class ListProducts : Form
    {
        public ListProducts()
        {
            InitializeComponent();
        }

        private void ListProducts_Load(object sender, EventArgs e)
        {
        

            
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Modbus.modbusClient.Connect();
                lb_ConnectionStatus.Text = "Bağlı!";
            }
            catch
            {
                lb_ConnectionStatus.Text = "Bağlanamadı!";
            }
            
        }

        private async Task ListAsync()
        {
            await Task.Run(() => Products());
            await Task.Delay(1000);
            await Task.Run(() => ListAsync());
        }

        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            Modbus.modbusClient.Disconnect();
            lb_ConnectionStatus.Text = "Bağlantı değil!";
        }

        private void btn_ListProducts_Click(object sender, EventArgs e)
        {
            Products();
        }

        private void Products()
        {
             int[] registerValues = new int[16];
            
            string productName;
            int i = dGV_ListProducts.Rows.Add();

            try
            {
                Modbus.modbusClient.Connect();
                lb_ConnectionStatus.Text = "Bağlandı!";

                registerValues =Modbus.modbusClient.ReadHoldingRegisters(0, 14);
                productName=ModbusClient.ConvertRegistersToString(registerValues, 0, 15);

                dGV_ListProducts.Rows[i].Cells[0].Value = productName;
            }
            catch
            {
                lb_ConnectionStatus.Text = "Bağlanamadı!";
            }

        }
    }
}
