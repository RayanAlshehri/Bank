using BankBuisnessTier;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmClientsList : Form
    {
        private DataView ClientsDV;
        public frmClientsList()
        {
            InitializeComponent();

            LoadDataToDataView();
            dgvClientsList.DataSource = ClientsDV;
        }

        private void LoadDataToDataView()
        {
            try
            {
                DataTable ClientsDT = clsClient.GetAllClients();

                ClientsDT.Columns["FirstName"].ColumnName = "Full Name";
                ClientsDT.Columns.Remove("MiddleName");
                ClientsDT.Columns.Remove("LastName");

                foreach (DataRow Row in ClientsDT.Rows)
                {
                    Row["Full Name"] = clsClient.Find((int)Row["ID"]).FullName();
                }

                ClientsDV = ClientsDT.DefaultView;
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
                        ClientsDV.RowFilter = "ID = " + ID;
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
            ClientsDV.RowFilter = "";
            btnShowAllClients.Visible = false;
        }
    }
}
