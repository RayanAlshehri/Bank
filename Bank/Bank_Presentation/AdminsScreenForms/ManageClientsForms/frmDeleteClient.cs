using BankBuisnessTier;
using System;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmDeleteClient : Form
    {
        private clsClient CurrentClient;
        public frmDeleteClient()
        {
            InitializeComponent();
        }


        private void LoadClientInfoToControls()
        {
            lblClientFullName.Text = CurrentClient.FullName();
            lblClientPhone.Text = CurrentClient.Phone;
        }

        private void MakeControlsVisible()
        {
            lblFullName.Visible = true;
            lblPhone.Visible = true;

            lblClientFullName.Visible = true;
            lblClientPhone.Visible = true;

            btnDelete.Visible = true;
        }

        private void ReturnControlsToDefault()
        {
            lblFullName.Visible = false;
            lblPhone.Visible = false;

            lblClientFullName.Text = "";
            lblClientPhone.Text = "";

            lblClientFullName.Visible = false;
            lblClientPhone.Visible = false;

            btnDelete.Visible = false;

            mtbID.Clear();
        }

        private bool DeleteClient()
        {
            bool IsDeleted = false;

            try
            {
                IsDeleted = clsClient.DeleteClient(CurrentClient.ID);
            }
            catch (Exception DBerror)
            {
                IsDeleted = false;

                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return IsDeleted;
        }
      

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbID.Text))
            {
                errorProvider1.SetError(mtbID, "");

                int ID = Convert.ToInt32(mtbID.Text.Trim());

                try
                {
                    if (clsClient.IsClientExist(ID))
                    {
                        CurrentClient = clsClient.Find(ID);
                        MakeControlsVisible();
                        LoadClientInfoToControls();
                    }
                    else
                    {
                        MessageBox.Show("Client with ID " + ID + " not found", "Find Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                errorProvider1.SetError(mtbID, "Enter ID to search for client");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this client?", "Confirmation", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if (DeleteClient())
                {
                    MessageBox.Show("Client deleted successully", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReturnControlsToDefault();
                    CurrentClient = null;
                }
            }
        }
    }
}
