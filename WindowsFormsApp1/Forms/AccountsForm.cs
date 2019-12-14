using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class AccountsForm : Form
    {
        SystemInfoControls systemInfo = new SystemInfoControls();
        Global global = new Global();
        AddAccountForm addAccountForm = new AddAccountForm();
        public AccountsForm()
        {
            InitializeComponent();
          
            systemInfo.lV_Users = lV_Users;
        }
      
       

        private void AccountsForm_Load(object sender, EventArgs e)
        {
           
            global.dataExchange.DataExchangeProtocol(systemInfo);
            
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

            global.dataExchange.ListUsers(ref systemInfo);
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            addAccountForm.ShowDialog();
        }
    }
}
