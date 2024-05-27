using BankBuisnessTier;
using System;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{
    public partial class frmLogin : Form
    {
        enum enLoginAs {Admin, Client}

        enLoginAs LoginAs;
        bool FormClosedByLogin = false;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void MakeLoginControlsVisible()
        {
            ibUser.Visible = true;
            ibLock.Visible = true;
            lblUsername.Visible = true;
            lblPassword.Visible = true;
            tbUsername.Visible = true;
            tbPassword.Visible = true;
            btnLogin.Visible = true;
            btnBack.Visible = true;
        }

        private void MakeLoginControlsInVisible()
        {
            ibUser.Visible = false;
            ibLock.Visible = false;
            lblUsername.Visible = false;
            lblPassword.Visible = false;
            tbUsername.Visible = false;
            tbPassword.Visible = false;
            btnLogin.Visible = false;
            btnBack.Visible = false;
        }

        private void AccessAdminSystem(clsAdmin LogedAdmin)
        {
            Form frm = new frmAdminsMainScreen(LogedAdmin);
            frm.Show();
            FormClosedByLogin = true;
            this.Close();            
        }

        private void AccessClientSystem(clsClient LogedClient)
        {
            Form frm = new frmClientMainScreen(LogedClient);
            frm.Show();
            FormClosedByLogin = true;
            this.Close();           
        }

        private void ShowLoginFailedEffects()
        {
            tbPassword.PasswordChar = '*';
            MessageBox.Show("Invalid username or password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            tbPassword.Clear();
        }


        private void btnLoginAsAdmin_Click(object sender, EventArgs e)
        {
            btnLoginAsAdmin.Visible = false;
            btnLoginAsClient.Visible = false;
            LoginAs = enLoginAs.Admin;
            lblTitle.Text += "\nAdmin Login";

            MakeLoginControlsVisible();
        }

        private void btnLoginAsClient_Click(object sender, EventArgs e)
        {
            btnLoginAsAdmin.Visible = false;
            btnLoginAsClient.Visible = false;
            LoginAs = enLoginAs.Client;
            lblTitle.Text += "\nClient Login";

            MakeLoginControlsVisible();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string Username = tbUsername.Text.Trim();
            tbPassword.PasswordChar = '\0';
            string Password = tbPassword.Text.Trim();

            if (LoginAs == enLoginAs.Admin)
            {               
                try
                {
                    clsAdmin Admin = clsAdmin.Find(Username, Password);

                    if (Admin != null)
                    {
                        AccessAdminSystem(Admin);
                    }
                    else
                    {
                        ShowLoginFailedEffects();
                    }
                }
                catch (Exception DBerror)
                {
                    MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            } 
            else
            {
                try
                {
                    clsClient Client = clsClient.Find(Username, Password);

                    if (Client != null)
                    {
                        AccessClientSystem(Client);
                    }
                    else
                    {
                        ShowLoginFailedEffects();
                    }
                }
                catch (Exception DBerror)
                {
                    MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MakeLoginControlsInVisible();

            tbUsername.Clear();
            tbPassword.Clear();

            btnLoginAsAdmin.Visible = true;
            btnLoginAsClient.Visible = true;
            lblTitle.Text = "Bank System";
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!FormClosedByLogin)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
