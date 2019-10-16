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
    public partial class lb_Adress : Label
    {
        public lb_Adress()
        {
            InitializeComponent();
            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {

            base.OnPaint(pe);
        }



    }
}
