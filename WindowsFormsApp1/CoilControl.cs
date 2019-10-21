using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CoilControl : Label
    {

        

        public int Adress { get; set; }
        public bool Value { get; set; }

        Modbus modbus = new Modbus();

        public CoilControl()
        {
            InitializeComponent();
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnDoubleClick(EventArgs e)
        {
           

            try
            {
                if (String.Compare(this.Text, "0") == 0)
                {

                    this.Text = "1";
                    this.BackColor = Color.DeepSkyBlue;
                    Value = true;
                    modbus.modbusClient.WriteSingleCoil(Adress, Value);
                }
                else if (String.Compare(this.Text, "1") == 0)
                {

                    this.Text = "0";
                    this.BackColor = Color.DimGray;
                    Value = false;
                    modbus.modbusClient.WriteSingleCoil(Adress, Value);
                    
                }

              
            }
            catch(Exception ex)
            {
                MessageBox.Show("Bağlı değilsiniz!");
            }

            base.OnDoubleClick(e);

        }

        public void Write(int startingAdress, int quantity)
        {
            modbus.modbusClient.ReadCoils(startingAdress, quantity);
        }

    }
}
