using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace LiMS.Database
{
    public partial class ServerForm : DevComponents.DotNetBar.Metro.MetroForm
    {
        public ServerModel Server { get; private set; }
        public ServerForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Server = new ServerModel()
            {
                UserID = userIdTextBox.Text, Password = passwordTextBox.Text, Server = serverTextBox.Text
            };
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}