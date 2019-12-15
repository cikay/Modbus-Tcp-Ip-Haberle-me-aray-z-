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
            Parameters parameters;
            var allNud = Tools.GetAllChildControl(this, typeof(NumericUpDown));
           
            PropertyInfo[] properties = typeof(Product).GetProperties();


            foreach (NumericUpDown nud in allNud)
            {
                foreach (var prop in properties)
                {
                    if (nud.Name.Contains(prop.Name))
                    {
                        parameters = (Parameters)prop.GetValue(product);
                        parameters.Value = nud.Value.ToString();
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

      
      
    }
}
