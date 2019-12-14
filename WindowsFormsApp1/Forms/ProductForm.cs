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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        AddProductForm addProductForm = new AddProductForm();

        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            addProductForm.ShowDialog();
        }
    }
}
