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
using static System.Windows.Forms.ListView;

namespace WindowsFormsApp1.Forms
{
    public partial class ListProductForm : Form
    {
        public ListProductForm()
        {
            InitializeComponent();
        }
        DataExchange dataExchange = new DataExchange();
        SystemInfoControls infoControls = new SystemInfoControls();
        Product productData = new Product();
        
        private void ListProductForm_Load(object sender, EventArgs e)
        {
            
            infoControls.comType = commandType.read;
            infoControls.requestDataType = RequestDataType.products;
            DataTypeComStatus allowProtocol=dataExchange.DataExchangeProtocol(infoControls);
            
            
            if (allowProtocol==DataTypeComStatus.readableProducts)
            {
                productData = dataExchange.ListProduct<Product>(productData);
                string[] row = 
                {
                    productData.ProductName.Value, productData.LabelName.Value, productData.Cable1Color.Value,
                    productData.Cable2Color.Value, productData.Quantity.Value, productData.CableSection.Value,
                    productData.CableDiameter.Value, productData.CableDirection.Value
                };
                var lvi = new ListViewItem(row);
                listView_Products.Items.Add(lvi);
            }
  
        }

        private void detailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView_Products.SelectedItems.Count == 1)
            {
                foreach (Parameters parameters in productData)
                {
                    if (string.Compare(parameters.Value, listView_Products.SelectedItems[0].Text) == 0)
                    {
                        ProductDetailsForm detailsForm = new ProductDetailsForm(productData, parameters.Value);
                        detailsForm.ShowDialog();
                        break;
                    }
                }
            }
        }
    }
}

