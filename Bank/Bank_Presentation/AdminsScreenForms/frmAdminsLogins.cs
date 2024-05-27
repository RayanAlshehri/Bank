using BankBuisnessTier;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmAdminsLogins : Form
    {
        private DataView AdminsLoginsDV;
        public frmAdminsLogins()
        {
            InitializeComponent();

            LoadAdminsLoginsDataToDataView();
            dgvAdminsLogins.DataSource = AdminsLoginsDV;
        }

        private void LoadAdminsLoginsDataToDataView()
        {
            try
            {
                DataTable AdminsLoginsDT = clsRecords.GetAllAdminsLogins();

                AdminsLoginsDT.Columns.Remove("ID");

                AdminsLoginsDV = AdminsLoginsDT.DefaultView;
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
                    if (clsAdmin.IsAdminExist(ID))
                    {
                        AdminsLoginsDV.RowFilter = "AdminID = " + ID;
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
            AdminsLoginsDV.RowFilter = "";
            btnShowAllAdmins.Visible = false;
        }
    }
}
    

