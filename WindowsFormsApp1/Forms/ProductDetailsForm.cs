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
    public partial class ProductDetailsForm : Form
    {
        public ProductDetailsForm(Product product, string productName)
        {
            InitializeComponent();

            var allChild = Tools.GetAllChildControl(this, typeof(Label));
            lb_ProductName.Text = productName +" Ürününün Diğer Parametreleri";
            
            

            foreach (Control ctrl in allChild)
            {
                if ((ctrl is Label))
                {
                    foreach(var prop in product)
                    {
                        if (ctrl.Name.Contains(prop.Name))
                        {
                            ctrl.Text = prop.Value;
                        }
                    }
                }
            }
        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
