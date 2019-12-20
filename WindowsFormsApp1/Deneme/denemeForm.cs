using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class denemeForm : Form
    {
        Modbus modbus = new Modbus();

        public denemeForm()
        {
            InitializeComponent();
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            modbus.modbusClient.WriteSingleRegister(Convert.ToInt32(tB_Adress.Text), Convert.ToInt32(tB_Value.Text));
            tB_Adress.Text = string.Empty;
            tB_Value.Text = string.Empty;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            modbus.Connect(lb_ConnectionStatus);
        }

        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            modbus.DisConnect(lb_ConnectionStatus);
        }

        private void denemeForm_Load(object sender, EventArgs e)
        {
            lb_ConnectionStatus.Text = "not Connect";
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            int[] register = modbus.modbusClient.ReadHoldingRegisters(Convert.ToInt32(tB_Adress.Text), 1);


        }
    }
}
