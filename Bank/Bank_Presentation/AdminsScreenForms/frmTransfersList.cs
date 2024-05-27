using BankBuisnessTier;
using System;
using System.Data;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmTransferesList : Form
    {
        private DataView TransfersDV;
        public frmTransferesList()
        {
            InitializeComponent();

            LoadTranferesDataToDV();
            dgvTransferesList.DataSource = TransfersDV;
        }

        private void LoadTranferesDataToDV()
        {
            try
            {
                DataTable TransfersDT = clsRecords.GetAllTransfers();

                TransfersDV = TransfersDT.DefaultView;
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(mtbID.Text))
            {
                int AccountNumber = Convert.ToInt32(mtbID.Text.Trim());

                try
                {
                    if (clsAccount.IsAccountExist(AccountNumber))
                    {
                        TransfersDV.RowFilter = "SenderAccNumber = " + AccountNumber;
                        btnShowAllTransfers.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Account with number " + AccountNumber + " not found", "Find Account",
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

        private void btnShowAllTransfers_Click(object sender, EventArgs e)
        {
            mtbID.Clear();
            TransfersDV.RowFilter = "";
            btnShowAllTransfers.Visible = false;
        }
    }
}
