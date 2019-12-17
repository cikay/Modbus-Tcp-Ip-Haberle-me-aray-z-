using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1.Forms
{
    public partial class ListCablesForm : Form
    {
        public ListCablesForm()
        {
            InitializeComponent();
        }
        Global global = new Global();
        SystemInfoControls infoControls = new SystemInfoControls();
        Dictionary<int, Cable> dataCollection = new Dictionary<int, Cable>();
        private void ListCablesForm_Load(object sender, EventArgs e)
        {
            ListCables();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ListCables();
        }

        private void ListCables()
        {
            infoControls.comType = commandType.read;
            infoControls.requestDataType = RequestDataType.cables;
            DataTypeComStatus allowProtocol = global.dataExchange.DataExchangeProtocol(infoControls);
            if (allowProtocol == DataTypeComStatus.readableCables)
            {
                dataCollection = global.dataExchange.GetData<Cable>();
                if(dataCollection!= null) List(dataCollection);

            }
        }

        public void List(Dictionary<int, Cable> dataCollection)
        {
            foreach (KeyValuePair<int, Cable> keyValuePair in dataCollection)
            {
                Cable cable = keyValuePair.Value;

                string[] row = { };
                int i = 0;
                foreach (Parameters parameters in cable)
                {
                    row[i++] = parameters.Value;
                }
                ListViewItem lvi = new ListViewItem(row);
                lV_Cables.Items.Add(lvi);
            }
        }
    }
}
