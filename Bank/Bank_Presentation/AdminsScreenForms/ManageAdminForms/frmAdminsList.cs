using System;
using System.Data;
using System.Windows.Forms;
using BankBuisnessTier;

namespace Bank_Presentation_Tier
{
    public partial class frmAdminsList : Form
    {
        private DataView AdminsDV;
        public frmAdminsList()
        {
            InitializeComponent();

            LoadDataToDataView();
            dgvAdminsList.DataSource = AdminsDV;
        }

        private void LoadDataToDataView()
        {           
            try 
            {
                DataTable AdminsDT = clsAdmin.GetAllAdmins();

                AdminsDT.Columns.Remove("MiddleName");
                AdminsDT.Columns.Remove("LastName");

                AdminsDT.Columns["FirstName"].ColumnName = "Full Name";
                AdminsDT.Columns["PermissionsOnAdmins"].ColumnName = "Permissions On Admins";
                AdminsDT.Columns["PermissionsOnClients"].ColumnName = "Permissions On Clients";

                foreach (DataRow Row in AdminsDT.Rows)
                {
                    Row["Full Name"] = clsAdmin.Find((int)Row["ID"]).FullName();
                }

                AdminsDV = AdminsDT.DefaultView;
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                     
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbID.Text))
            {
                int ID = Convert.ToInt32(mtbID.Text.Trim());

                try
                {
                    if (clsAdmin.IsAdminExist(ID))
                    {
                        AdminsDV.RowFilter = "ID = " + ID;
                        btnShowAllAdmins.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Admin with ID " + ID + " not found", "Find Admin",
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
            {
                mtbID.Clear();
            }
                    
        }

        private void btnShowAllAdmins_Click(object sender, EventArgs e)
        {
            mtbID.Clear();
            AdminsDV.RowFilter = "";          
            btnShowAllAdmins.Visible = false;
        }
    }
}
