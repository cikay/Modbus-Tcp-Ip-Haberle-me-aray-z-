using System;
using System.Windows.Forms;
using System.Collections.Generic;
using EasyModbus;

namespace WindowsFormsApp1
{
    public partial class MainFormCUI : Form
    {
        //Plc plc = new Plc();

        private Dictionary<Type, Form> ActiveForms;

      
        //ModbusClient modbusClient = new ModbusClient();
        Global global = new Global();

        public MainFormCUI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.ActiveForms = new Dictionary<Type, Form>();

        }

       
        private void MainFormCUI_Load(object sender, System.EventArgs e)
        {
           
            //SystemInfoControls s = new SystemInfoControls();
            //s.lbAccesSystem = lbAccesSystem;
            //s.lbRequestData = lbRequestData;

            //global.dataExchange.modbus.modbusClient.Connect();

            //if (global.dataExchange.modbus.modbusClient.Connected) global.dataExchange.DataExchangeProtocol(s);
            //else MessageBox.Show("Bağlantı yok");
        }

      
       
        private void plcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<Plc>();
        }

        private void ShowForm<TSourse>() where TSourse:Form
        {
            Form form = null;

            if (this.ActiveForms.ContainsKey(typeof(TSourse)))
            {
                form = this.ActiveForms[typeof(TSourse)];
                form.WindowState = FormWindowState.Normal;
                form.Activate();
            }
            else
            {

                form = Activator.CreateInstance<TSourse>();
                form.MdiParent = this;
                form.FormClosed += form_FormClosed;
                form.Show();

                this.ActiveForms.Add(typeof(TSourse), form);
            }

            form.SetBounds(0, 0, this.Width, this.Height);

        }

        private void form_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.ActiveForms.Remove(sender.GetType());
        }

        private void ürünleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<Forms.ListProductsForm>();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             
        }

        private void CommonControls()
        {

        }

        private void ConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.dataExchange.modbus.modbusClient.Connect();//try bloğuna alınacak
            if (!global.dataExchange.modbus.modbusClient.Connected) MessageBox.Show("bağlantı yapılamadı");
        }

        private void DisConnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            global.dataExchange.modbus.modbusClient.Disconnect();
            if (!global.dataExchange.modbus.modbusClient.Connected) ; /*lb_ConnectionStatus.Text = "Bağlı değil!";*/
        }

        private void AccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SystemInfoControls infoControls = new SystemInfoControls();
            //infoControls.lbAccesSystem = lbAccesSystem;
            //infoControls.lbRequestData = lbRequestData;
            global.dataExchange.ListUsers(ref infoControls);
        }

        private void ProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panelFill_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
