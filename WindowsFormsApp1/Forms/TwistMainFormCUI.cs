using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class TwistMainFormCUI : Form
    {
        

        private Dictionary<Type, Form> ActiveForms;
        Global global = new Global();


        public TwistMainFormCUI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.ActiveForms = new Dictionary<Type, Form>();
        }

        private void TwistMainFormCUI_Load(object sender, EventArgs e)
        {
            SystemInfoControls s = new SystemInfoControls();
            s.lbAccesSystem = tStripL_AccessSystem;
            s.lbRequestData = tStripL_ReqData;

            global.dataExchange.modbus.modbusClient.Connect();

            if (global.dataExchange.modbus.modbusClient.Connected) global.dataExchange.DataExchangeProtocol(s);
            else MessageBox.Show("Bağlantı yok");
        }

        private void tStripBtn_Connect_Click(object sender, EventArgs e)
        {
            global.dataExchange.modbus.modbusClient.Connect();//try bloğuna alınacak
            if (!global.dataExchange.modbus.modbusClient.Connected) MessageBox.Show("bağlantı yapılamadı");
        }
        private void tStripBtn_DisConnect_Click(object sender, EventArgs e)
        {
            global.dataExchange.modbus.modbusClient.Disconnect();
            if (!global.dataExchange.modbus.modbusClient.Connected) ; /*lb_ConnectionStatus.Text = "Bağlı değil!";*/
        }
     

        private void form_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.ActiveForms.Remove(sender.GetType());
        }

        private void tStripBtn_Products_Click(object sender, EventArgs e)
        {

        }
        private void tStripBtn_Cables_Click(object sender, EventArgs e)
        {

        }
        private void tStripBtn_Accounts_Click(object sender, EventArgs e)
        {
            ShowForm<AccountsForm>();
        }
        private void ShowForm<TSourse>() where TSourse : Form
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
    }
}
