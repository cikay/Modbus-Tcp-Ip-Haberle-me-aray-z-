using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class ListData
    {
        public static void List<T>(Dictionary<int, T> dataCollection, ListView listView)
        {
            foreach (KeyValuePair<int, T> keyValuePair in dataCollection)
            {
                T data = keyValuePair.Value;
                PropertyInfo[] Properties=typeof(T).GetProperties();

                string[] row = { };
                int i = 0;
                foreach (PropertyInfo prop in Properties)
                {
                    Parameters parameters=(Parameters)prop.GetValue(data);
                    row[i++] = parameters.Value;
                }
                ListViewItem lvi = new ListViewItem(row);
                listView.Items.Add(lvi);
            }
        }
    }
}
