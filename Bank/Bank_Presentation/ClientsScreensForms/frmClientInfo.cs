using System;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmClientInfo : Form
    {
        public frmClientInfo()
        {
            InitializeComponent();

            LoadClientInfoToControls();
        }

        private void LoadClientInfoToControls()
        {
            tbFirstName.Text = clsLogedClient.Client.FirstName;
            tbMiddleName.Text = clsLogedClient.Client.MiddleName;
            tbLastName.Text = clsLogedClient.Client.LastName;
            tbPhone.Text = clsLogedClient.Client.Phone;
            tbAddress.Text = clsLogedClient.Client.Address;
            tbUsername.Text = clsLogedClient.Client.Username;
        }

        private bool IsInfoChanged()
        {
            return clsLogedClient.Client.FirstName != tbFirstName.Text.Trim() 
                || clsLogedClient.Client.MiddleName != tbMiddleName.Text.Trim()
                || clsLogedClient.Client.LastName != tbLastName.Text.Trim() 
                || clsLogedClient.Client.Phone != tbPhone.Text.Trim()
                || clsLogedClient.Client.Address != tbAddress.Text.Trim();
        }

        private void UpdateChengedInfo()
        {
            if (!string.IsNullOrWhiteSpace(tbFirstName.Text))
                clsLogedClient.Client.FirstName = tbFirstName.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tbMiddleName.Text))
                clsLogedClient.Client.MiddleName = tbMiddleName.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tbLastName.Text))
                clsLogedClient.Client.LastName = tbLastName.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tbPhone.Text))
                clsLogedClient.Client.Phone = tbPhone.Text.Trim();

            if (!string.IsNullOrWhiteSpace(tbAddress.Text))
                clsLogedClient.Client.Address = tbAddress.Text.Trim();
        }

        private bool UpdateClientInfo()
        {
            bool IsUpdated = false;

           UpdateChengedInfo();

            try
            { 
                IsUpdated =  clsLogedClient.Client.Save(); 
            }
            catch (Exception DBerror)
            {
                IsUpdated = false;
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsUpdated;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (IsInfoChanged())
            {
                if (UpdateClientInfo())
                {
                    MessageBox.Show("Information updated successfully", "Information Update",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }              
            }
        }
    }
}
