using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ListData
    {
        public static ListView List<T>(Dictionary<int, T> dataCollection, ListView listView)
        {
            foreach (KeyValuePair<int, T> keyValuePair in dataCollection)
            {
                T cable = keyValuePair.Value;

                string[] row = { };
                int i = 0;
                //foreach (Parameters parameters in cable)
                //{
                //    row[i++] = parameters.Value;
                //}
                ListViewItem lvi = new ListViewItem(row);
                listView.Items.Add(lvi);
            }

            return listView;
        }
    }
}
