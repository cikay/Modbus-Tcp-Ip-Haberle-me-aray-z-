using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Forms
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_Load(object sender, EventArgs e)
        {

        }
        DataExchange dataExchange = new DataExchange();
        Product product = new Product();
        SystemInfoControls infoControls = new SystemInfoControls();

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            object[] property;
            var allNud = GetAll(this, typeof(NumericUpDown));
           
            PropertyInfo[] properties = typeof(Product).GetProperties();


            foreach (NumericUpDown nud in allNud)
            {
                foreach (var prop in properties)
                {
                    if (nud.Name.Contains(prop.Name))
                    {
                        property = (object[])prop.GetValue(product);
                        property[1] = nud.Value.ToString();
                        break;
                    }
                }

            }
            DataTypeComStatus protocolAllow = dataExchange.DataExchangeProtocol(infoControls);
            if (protocolAllow == DataTypeComStatus.writeableProducts)
            {
                dataExchange.Add<Product>(product);
            }

        }

      
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
    }
}
