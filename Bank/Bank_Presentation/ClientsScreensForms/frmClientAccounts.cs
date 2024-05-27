using BankBuisnessTier;
using System.Drawing;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmClientAccounts : Form
    {  
        
        public frmClientAccounts()
        {
            InitializeComponent();          

            LoadClientAccounts();
        }

        private void DisplayAccountInfoInGB(int AccountNumber, float Balance, int xAxisIncrement, int yAxisIncrement)
        {
            GroupBox GB = new GroupBox();
            GB.Size = new Size(180, 150);
            GB.Location = new Point(75 + xAxisIncrement, 30 + yAxisIncrement);
            GB.Text = "Account:";
            GB.Font = new Font(FontFamily.GenericSansSerif, 12);
            GB.AutoSize = true;

            Label lblAccountNumber = new Label();
            lblAccountNumber.Text = "Account number: " + AccountNumber;
            GB.Controls.Add(lblAccountNumber);
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(15, 25); 
            
            Label lblBalance = new Label();
            lblBalance.Text = "Balance: " + Balance;
            GB.Controls.Add(lblBalance);
            lblBalance.AutoSize = true;
            lblBalance.Location = new Point(15, 50);

            GB.Parent = this;
        }

        private void LoadClientAccounts()
        {
            int xAxisIncrement = 0;
            int yAxisIncrement = 0;
            int NumberOfAccountInEachRow = 0;

            foreach (clsAccount Account in clsLogedClient.Accounts)
            {
                DisplayAccountInfoInGB(Account.AccNumber, Account.Balance, xAxisIncrement, yAxisIncrement);
                xAxisIncrement += 200;
                NumberOfAccountInEachRow++;

                if (NumberOfAccountInEachRow == 3)
                {
                    yAxisIncrement += 180;
                    xAxisIncrement = 0;
                    NumberOfAccountInEachRow = 0;
                }
            }
        }
    }
}
