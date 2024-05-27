using BankBuisnessTier;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmViewAccounts : Form
    {
        private enum enFilters {None, ActiveAccounts, DeletedAccounts};

        private DataView AccountsDV;
        private int ClientID = -1;
        enFilters Filter;
        private bool AreAccountsForOneClients = false;
        public frmViewAccounts()
        {
            InitializeComponent();

            LoadDataToDV();
            dataGridView1.DataSource = AccountsDV;          
        }

        private void LoadDataToDV()
        {
            try
            {
                DataTable DT = clsAccount.GetAllAccounts();
                AccountsDV = DT.DefaultView;
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                   
        }

        private void SetFilterEnum()
        {
            switch (cbFilter.SelectedIndex)
            {
                case 0:
                    Filter = enFilters.None;
                    break;

                case 1:
                    Filter = enFilters.ActiveAccounts;
                    break;

                case 2:
                    Filter = enFilters.DeletedAccounts;
                    break;
            }
        }
           
        private void FilterDGVdata()
        {
            if (!AreAccountsForOneClients)
            {
                switch (Filter)
                {
                    case enFilters.None:
                        AccountsDV.RowFilter = "";                       
                        break;

                    case enFilters.ActiveAccounts:
                        AccountsDV.RowFilter = "DeletionDate IS NULL";                      
                        break;

                    case enFilters.DeletedAccounts:
                        AccountsDV.RowFilter = "DeletionDate IS NOT NULL";                       
                        break;
                }
            }
            else
            {
                switch (Filter)
                {
                    case enFilters.None:                       
                        AccountsDV.RowFilter = "ClientID = " + ClientID;
                        dataGridView1.DataSource = AccountsDV;
                        break;

                    case enFilters.ActiveAccounts:
                        AccountsDV.RowFilter = "ClientID = " + ClientID + " AND DeletionDate IS NULL";
                        dataGridView1.DataSource = AccountsDV;
                        break;

                    case enFilters.DeletedAccounts:
                        AccountsDV.RowFilter = "ClientID = " + ClientID + " AND DeletionDate IS NOT NULL";
                        dataGridView1.DataSource = AccountsDV;
                        break;
                }
            }
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFilterEnum();
            FilterDGVdata();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbID.Text))
            {
               ClientID = Convert.ToInt32(mtbID.Text.Trim());

                try
                {
                    if (clsClient.IsClientExist(ClientID))
                    {
                        AreAccountsForOneClients = true;
                        cbFilter.SelectedIndex = 0;
                        FilterDGVdata();
                        btnShowAllAccounts.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Client with ID " + ClientID + " not found", "Find Client",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        mtbID.Clear();
                        ClientID = -1;
                    }
                }
                catch (Exception DBerror)
                {
                    MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnShowAllAccounts_Click(object sender, EventArgs e)
        {
            ClientID = -1;
            AreAccountsForOneClients = false;
            cbFilter.SelectedIndex = 0;
            FilterDGVdata();
            btnShowAllAccounts.Visible = false;
            mtbID.Clear();
        }
    }
}
