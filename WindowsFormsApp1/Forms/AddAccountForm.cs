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
    public partial class AddAccountForm : Form
    {
        public AddAccountForm()
        {
            InitializeComponent();
        }
        Account account = new Account();
        DataExchange dataExchange = new DataExchange();
        SystemInfoControls infoControls = new SystemInfoControls();

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            infoControls.comType = commandType.write;
            infoControls.requestDataType = RequestDataType.users;
            DataTypeComStatus protocolAllow =dataExchange.DataExchangeProtocol(infoControls);

            if (protocolAllow == DataTypeComStatus.writeableAccounts)
            {
                account.userName[1] = txt_userName.Text;
                account.Pin[1] = txt_Pin.Text;
                account.barcodPin[1] = txt_BarcodPin.Text;
                account.Level[1] = cb_Level.Text;
                account.protectInfo[1] = cb_ProtecInfo.Text;
                dataExchange.Add<Account>(account);
                MessageBox.Show("Kuulanıcı başarlı bir şekilde eklendi.");
            }
            else
            {
                MessageBox.Show("Haberleşme protokolünde hata oluştu!");
            }

        }

        private void AddAccountForm_Load(object sender, EventArgs e)
        {

        }
    }
}
