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

            lb_ProductName.Text = productName +" Ürününün Diğer Parametreleri";
            lb_FowardSpeed.Text = product.FowardSpeed.Value;
            lb_BackSpeed.Text = product.BackSpeed.Value;
            lb_FowardAcceleration.Text = product.FowardAcceleration.Value;
            lb_BackAcceleretion.Text = product.BackAcceleration.Value;
            lb_FowardDeceleration.Text = product.FowardDeceleration.Value;
            lb_BackDeceleration.Text = product.BackDeceleration.Value;
            lb_ForwardCircuit.Text = product.FowardCircuit.Value;
            lb_BackCircuit.Text = product.BackCircuit.Value;
            lb_TurArasiBekleme.Text = product.TurArasiBekletme.Value;
            lb_PitchDimension.Text = product.PitchDimension.Value;
            lb_SolAcikBoy.Text = product.SolAcikBoy.Value;
            lb_SagAcikBoy.Text = product.SagAcikBoy.Value;
            lb_BurulmaSonrasiBoy.Text = product.BurulmaSonrasiBoy1.Value;
            lb_BurulmaSonrasiBoy2.Text = product.BurulmaSonrasiBoy2.Value;
            lb_KabloBirakmaSuresi.Text = product.KabloBirakmaSuresi.Value;

        }

        private void ProductDetailsForm_Load(object sender, EventArgs e)
        {
            
        }

    }
}
