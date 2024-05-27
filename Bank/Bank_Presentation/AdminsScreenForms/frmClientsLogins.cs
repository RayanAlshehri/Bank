using BankBuisnessTier;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmClientsLogins : Form
    {
        private DataView ClientsLoginsData;
        public frmClientsLogins()
        {
            InitializeComponent();

            LoadClientsLoginsDataToDataView();
            dgvClientsLogins.DataSource = ClientsLoginsData;
        }

        private void LoadClientsLoginsDataToDataView()
        {
            try
            {
                DataTable ClientsLoginsDT = clsRecords.GetAllClientsLogins();

                ClientsLoginsDT.Columns.Remove("ID");

                ClientsLoginsData = ClientsLoginsDT.DefaultView;
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbID.Text))
            {
                int ID = Convert.ToInt32(mtbID.Text.Trim());

                try
                {
                    if (clsClient.IsClientExist(ID))
                    {
                        ClientsLoginsData.RowFilter = "ClientID = " + ID;
                        btnShowAllClients.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Client with ID " + ID + " not found", "Find Client",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                        mtbID.Clear();
                    }
                }
                catch (Exception DBerror)
                {
                    MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                mtbID.Clear();
        }

        private void btnShowAllClients_Click(object sender, EventArgs e)
        {
            mtbID.Clear();
            ClientsLoginsData.RowFilter = "";
            btnShowAllClients.Visible = false;
        }
    }
}
