using EasyModbus;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class CommonControls
    {
        static ModbusClient modbusClient = new ModbusClient();
        public static void CreateControls<T>(Form childForm)
        {
            Button btnConnect = new Button();
            createButton(ref btnConnect, 60,40, "Bağlan");
            Button btnDisConnect = new Button();
            createButton(ref btnDisConnect, 170,40, "Bağlantıyı kes");

            btnConnect.Click += new EventHandler(btnConnect_Click);
            btnDisConnect.Click += new EventHandler(btnDisConnect_Click);
            IntPtr m = Application.OpenForms[childForm.Name].Handle;

           // btnConnect.Parent = childForm.FromHandle(m).Controls.Find("ButonBox", true).FirstOrDefault();
        }

        private static void btnDisConnect_Click(object sender, EventArgs e)
        {
            modbusClient.Disconnect();
        }

        private static void btnConnect_Click(object sender, EventArgs e)
        {
            modbusClient.Connect();
        }

        public static void createButton(ref Button btn, int pointX, int pointY, string Text)
        {
            btn.BackColor = Color.Gray;
            btn.Text = Text;
            btn.ForeColor = Color.Black;
            btn.Width = 100;
            btn.Height = 100;
            btn.Location = new Point(pointX, pointY);
            btn.Visible = true;
            
        }
    }
}
