using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Deneme
{
    public partial class DDD : Form
    {
        public DDD()
        {
            InitializeComponent();
        }

        private void DDD_Load(object sender, EventArgs e)
        {
            string[] row = new string[] { "muza", "ffer", "cikay" };

            for (int i = 0; 1 < 3; i++)
            {
                
                ListViewItem lvi = new ListViewItem();

                
                foreach (var xx in row)
                {
                    lvi.SubItems.Add(xx);
                }
                if (!listView1.Items.Contains(lvi))
                {
                    listView1.Items.Add(lvi);

                }

                //listView1.Items[]
                //row[0] = "mc";

            }
        }
    }
}
