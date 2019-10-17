using System;
using System.Windows.Forms;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    public partial class MainFormCUI : Form
    {
        //Plc plc = new Plc();

        private Dictionary<Type, Form> ActiveForms;

        public MainFormCUI()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.ActiveForms = new Dictionary<Type, Form>();

        }

       
        private void MainFormCUI_Load(object sender, System.EventArgs e)
        {

        }

      
       
        private void plcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<Plc>();
        }

        private void ShowForm<TSourse>() where TSourse:Form
        {
            Form form = null;
            if (this.ActiveForms.ContainsKey(typeof(TSourse)))
            {
                form = this.ActiveForms[typeof(TSourse)];
                form.WindowState = FormWindowState.Normal;
                form.Activate();
            }
            else
            {

                form = Activator.CreateInstance<TSourse>();
                form.MdiParent = this;
                form.FormClosed += form_FormClosed;
                form.Show();

                this.ActiveForms.Add(typeof(TSourse), form);
            }

            form.SetBounds(0, 0, this.Width, this.Height);

        }

        private void form_FormClosed(Object sender, FormClosedEventArgs e)
        {
            this.ActiveForms.Remove(sender.GetType());
        }

        private void ürünleriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowForm<Forms.ListProductsForm>();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
