﻿using System;
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
    public partial class ListAccountsForm : Form
    {
        SystemInfoControls infoControls = new SystemInfoControls();
        Global global = new Global();
        Dictionary<int, Account> dataCollection;
       
        public ListAccountsForm()
        {
            InitializeComponent();

            infoControls.lV_Users = lV_Users;
        }

        private void AccountsForm_Load(object sender, EventArgs e)
        {
            ListAccounts();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            ListAccounts();
        }

        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            AddAccountForm addAccountForm = new AddAccountForm();
            addAccountForm.ShowDialog();
        }


        private void ListAccounts()
        {
            infoControls.comType = commandType.read;
            infoControls.requestDataType = RequestDataType.users;
            DataTypeComStatus protocolAllow = global.dataExchange.DataExchangeProtocol(infoControls);
            ListData listData = new ListData();
            if (protocolAllow == DataTypeComStatus.readableAccounts)
            {
               
                lV_Users = listData.List<Account>(lV_Users);
            }
        }
    }
}
