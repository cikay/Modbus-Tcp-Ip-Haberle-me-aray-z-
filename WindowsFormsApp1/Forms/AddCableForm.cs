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
    public partial class AddCableForm : Form
    {
        public AddCableForm()
        {
            InitializeComponent();
        }
        Global global = new Global();
        SystemInfoControls infoControls = new SystemInfoControls();
     

        private void AddCableForm_Load(object sender, EventArgs e)
        {

        }
        private void btn_AddCable_Click(object sender, EventArgs e)
        {
            infoControls.comType = commandType.write;
            infoControls.requestDataType = RequestDataType.cables;
            DataTypeComStatus allowProtocol = global.dataExchange.DataExchangeProtocol(infoControls);
            if (allowProtocol == DataTypeComStatus.writeableCables)
            {
                Cable cable = new Cable();
                cable.Name.Value = txt_CableName.Text;
                cable.Section.Value = txt_CableSection.Text;
                cable.OuterDiameter.Value = txt_OuterDiameter.Text;
                cable.Direction.Value = txt_Direction.Text;
                cable.Color.Value = txt_Color.Text;
                global.dataExchange.SendData<Cable>(cable);
            }
        }
    }
}
