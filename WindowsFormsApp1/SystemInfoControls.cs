using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Enums;

namespace WindowsFormsApp1
{
    public class SystemInfoControls
    {
        public ToolStripLabel lbAccesSystem { get; set; } = new ToolStripLabel();
        public ToolStripLabel lbRequestData { get; set; } = new ToolStripLabel();
        public ListView lV_Users { get; set; } = new ListView();

        public commandType comType { get; set; }
        public RequestDataType requestDataType { get; set; }
        
    }
}
