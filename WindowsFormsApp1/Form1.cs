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
    public partial class Form1 : Form
    {

        Modbus ComModbus = new Modbus(); 


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {


            Modbus.Connect(lb_ConnectionStatus);


        }

        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            Modbus.DisConnect(lb_ConnectionStatus);

             
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
            ComModbus.Write(Convert.ToInt32(tB_Adress.Text), Convert.ToInt32(tB_Value.Text));

        }
    }
}
