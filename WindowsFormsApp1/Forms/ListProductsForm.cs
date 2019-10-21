using System;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using EasyModbus;
using System.Threading;
using Timer = System.Timers.Timer;
using System.Drawing;

namespace WindowsFormsApp1.Forms
{
    public partial class ListProductsForm : Form
    {

        Timer timer_ListProducts = new Timer();
        Thread th_ListProducts;
        Modbus modbus = new Modbus();

        public ListProductsForm()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            timer_ListProducts.Enabled = true;
            timer_ListProducts.Interval = 2000;
            timer_ListProducts.Start();
            timer_ListProducts.Elapsed += timer_ListProducts_Elapsed;
           
        }

        private void timer_ListProducts_Elapsed(object sender, ElapsedEventArgs e)
        {
            th_ListProducts = new Thread(new ThreadStart(UpdateListProducts));
            th_ListProducts.Start();

        }

        private void ListProductsForm_Load(object sender, EventArgs e)
        {
            ListViewItem lVI_Urun = new ListViewItem();
            lVI_Urun.Text = "";
            lV_UrunListele.Items.Add(lVI_Urun);
            try
            {
                modbus.modbusClient.Connect();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                modbus.modbusClient.Connect();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
           
        }

      

        private void btn_DisConnect_Click(object sender, EventArgs e)
        {
            modbus.modbusClient.Disconnect();
            lb_ConnectionStatus.Text = "Bağlı değil!";
        }

        private void btn_ListProducts_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateListProducts()
        {


            if (modbus.modbusClient.Connected)
            {
                ListViewItem lVI_Urun = new ListViewItem();
                ListViewItem selectedListItem = new ListViewItem();
                int[] registerValues = new int[120];

                string Product, CurrentProduct;

                registerValues = modbus.modbusClient.ReadHoldingRegisters(0, 30);
                Product = ModbusClient.ConvertRegistersToString(registerValues, 0, 30);

               

                CurrentProduct = lV_UrunListele.Items[0].Text;
                if (String.Compare(Product, CurrentProduct) == 1)
                {
                    lVI_Urun.Text = Product;
                    lV_UrunListele.Items.RemoveAt(0);
                    lV_UrunListele.Items.Insert(0, lVI_Urun);
                }


            }

        
        }

        private void btn_Write_Click(object sender, EventArgs e)
        {
           // lV_UrunListele.  //lV_UrunListele.SelectedItems[0];
        }

        private void btn_Connect_Click_1(object sender, EventArgs e)
        {
            try
            {
                modbus.modbusClient.Connect();
               
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }
    }
}
