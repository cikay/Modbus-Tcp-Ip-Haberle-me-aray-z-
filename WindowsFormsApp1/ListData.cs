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
        static Global global = new Global();
        public ListView List<T>(ListView listView)
        {
            //ListView listView = new ListView();
            Dictionary<int, T> dataCollection = global.dataExchange.GetData<T>();
            if (dataCollection == null) return listView;
            foreach (KeyValuePair<int, T> keyValuePair in dataCollection)
            {
                T data = keyValuePair.Value;
                PropertyInfo[] Properties=typeof(T).GetProperties();
                ListViewItem lvi = new ListViewItem();
                string[] row = new string[dataCollection.Values.Count];
                bool exist = false;
                
                Parameters parameters = (Parameters)Properties[1].GetValue(data);
                lvi.Text = parameters.Value;
                for(int index=0;index<listView.Items.Count;index++)
                {
                    if (string.Compare(listView.Items[index].Text, lvi.Text) == 0)
                    {
                        exist = true;
                        break;
                    }
                }

                if (!exist)
                {
                    for (int i = 0; i < Properties.Length; ++i)
                    {
                        if (string.Compare(Properties[i].Name, "Increment") == 0) continue;
                        parameters = (Parameters)Properties[i].GetValue(data);
                        lvi.SubItems.Add(parameters.Value);
                    }
                    listView.Items.Add(lvi);
                }
            }
            return listView;
        }

        public Dictionary<int, T> dene<T>(T a)
        {
            Dictionary<int, T> datacolection = new Dictionary<int, T>();

            return datacolection;
        }
    }
}
