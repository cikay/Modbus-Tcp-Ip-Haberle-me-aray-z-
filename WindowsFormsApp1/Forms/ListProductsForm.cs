using System;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;
using Timer = System.Timers.Timer;

namespace WindowsFormsApp1.Forms
{
    public partial class ListProductsForm : Form
    {

        Timer timer_ListProducts = new Timer();
        Thread th_ListProducts;

        public ListProductsForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            timer_ListProducts.Enabled = true;
            timer_ListProducts.Interval = 2000;
            timer_ListProducts.Start();
            timer_ListProducts.Elapsed += timer_ListProducts_Elapsed;
            dGV_ListProducts.ColumnCount = 1;
            dGV_ListProducts.RowCount = 120;

        }

        private void timer_ListProducts_Elapsed(object sender, ElapsedEventArgs e)
        {
            th_ListProducts = new Thread(new ThreadStart(ListProducts));
            th_ListProducts.Start();
        }

        private void ListProductsForm_Load(object sender, EventArgs e)
        {
            try
            {
                Modbus.modbusClient.Connect();
                lb_ConnectionStatus.Text = "Bağlandı!";
            }
            catch
            {
                lb_ConnectionStatus.Text = "Bağlanamadı!";
            }
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                Modbus.modbusClient.Connect();
                lb_ConnectionStatus.Text = "Bağlandı!";
            }
            catch
            {
                lb_ConnectionStatus.Text = "Bağlanamadı!";
            }
            
        }

      

        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            Modbus.modbusClient.Disconnect();
            lb_ConnectionStatus.Text = "Bağlı değil!";
        }

        private void btn_ListProducts_Click(object sender, EventArgs e)
        {
            //ListProducts();
        }

        private void ListProducts()
        {
             int[] registerValues = new int[16];
            
            string Products;
            string productName;
           
            int row = dGV_ListProducts.Rows.Add();

            try
            {

                registerValues = Modbus.modbusClient.ReadHoldingRegisters(0, 120);
                Products = ModbusClient.ConvertRegistersToString(registerValues, 0, 120);
                

                for(int i = 0; i < 120; i++)
                {
                    productName=Products.Substring(i*3+1, 3);
                    dGV_ListProducts.Rows[row].Cells[0].Value = Products;

                }


            }
            catch
            {
                lb_ConnectionStatus.Text = "Bağlı değil!";
            } 
        }
    }
}
