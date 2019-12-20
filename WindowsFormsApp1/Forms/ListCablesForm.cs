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
        Dictionary<int, Cable> dataCollection;
        private void ListCablesForm_Load(object sender, EventArgs e)
        {
            ListCables();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            lV_Cables.Items.Clear();
            lV_Cables.Refresh();
            ListCables();
        }

        private void ListCables()
        {
            infoControls.comType = commandType.read;
            infoControls.requestDataType = RequestDataType.cables;
            DataTypeComStatus allowProtocol = global.dataExchange.DataExchangeProtocol(infoControls);
            ListData listData = new ListData();
            if (allowProtocol == DataTypeComStatus.readableCables)
            {
                Cable cable = new Cable();
               
                lV_Cables= listData.List<Cable>(lV_Cables);
               
            }
        }

        private void btn_AddCable_Click(object sender, EventArgs e)
        {
            AddCableForm addCable = new AddCableForm();
            addCable.ShowDialog();
        }
    }
}
