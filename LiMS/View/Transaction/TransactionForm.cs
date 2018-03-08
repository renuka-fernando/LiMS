using DevComponents.DotNetBar;
using LiMS.MyControl.TransactionPanel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LiMS.View.Transaction
{
    public partial class TransactionForm : DevComponents.DotNetBar.Metro.MetroAppForm
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void TransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void lendingTab_TabItemClose(object sender, SuperTabStripTabItemCloseEventArgs e)
        {
            if(e.Tab.Text == "New") e.Cancel = true;
            //TODO : if the tab is not saved then cancel else don't
        }

        private void addTabButton_Click(object sender, EventArgs e)
        {
            foreach(BaseItem tab in transactionSuperTab.Tabs)
            {
                if(tab.Text == "New") return;
            }
            addTab(transactionSuperTab);
            transactionSuperTab.SelectedTabIndex = transactionSuperTab.Tabs.Count - 2;
        }

        private void addTab(SuperTabControl tabControl)
        {
            SuperTabItem tabItem = new SuperTabItem();
            SuperTabControlPanel tabPanel = new SuperTabControlPanel();

            tabControl.Controls.Add(tabPanel);
            tabControl.Tabs.Insert(tabControl.Tabs.Count - 1, tabItem);

            //tabPanel
            tabPanel.Dock = DockStyle.Fill;
            tabPanel.TabItem = tabItem;

            //tabItem
            tabItem.AttachedControl = tabPanel;
            tabItem.GlobalItem = false;
            tabItem.Text = "New";

            addTransactionTabPanel(tabPanel);
        }

        private void addTransactionTabPanel(SuperTabControlPanel tabPanel)
        {
            TransactionTabPanel transactionTab = new TransactionTabPanel();
            transactionTab.Dock = DockStyle.Fill;
            transactionTab.ParentTransForm = this;

            tabPanel.Controls.Add(transactionTab);

            transactionTab.Name = "lendingTabPanel1";
            transactionTab.Select();
        }

        private void lendingTab_SelectedTabChanged(object sender, SuperTabStripSelectedTabChangedEventArgs e)
        {
            SuperTabItem tabItem = (SuperTabItem)e.NewValue;
            if(tabItem.AttachedControl != null)
                tabItem.AttachedControl.Controls[0].Select();
        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
            addTransactionTabPanel(transactionSuperTab.SelectedPanel);
            transactionSuperTab.SelectedTabIndex = 0;
        }

        public void SetSelectedTabDisplayText(string text)
        {
            transactionSuperTab.SelectedTab.Text = text;
        }

        public SubItemsCollection GetOpenedTabs()
        {
            return transactionSuperTab.Tabs;
        }

        public void closeThisTab()
        {
            transactionSuperTab.SelectedTab.Close();
            addTabButton_Click(null, null);
        }
    }
}