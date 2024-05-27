using BankBuisnessTier;
using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Bank_Presentation_Tier
{  
    public partial class frmClientMainScreen : Form
    {      
        private IconButton CurrentActivatedBtn;
        private Panel LeftBorderPanel;
        private Form CurrentChildForm;
        public frmClientMainScreen(clsClient LogedClient)
        {
            InitializeComponent();

            try
            {
                clsRecords.SaveClientLogin(LogedClient.ID);
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clsLogedClient.Client = LogedClient;

            try
            {
                clsLogedClient.LoadClientAccounts();
            }
            catch (Exception DBerror)
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ibLogedClientName.Text = "Hi " + LogedClient.FirstName + "!";

            LeftBorderPanel = new Panel();
            LeftBorderPanel.Size = new Size(7, 60);
            pnlMenu.Controls.Add(LeftBorderPanel);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void ActivateBtn(object SenderBtn, Color color)
        {
            DisableBtn();

            if (SenderBtn != null)
            {
                CurrentActivatedBtn = (IconButton)SenderBtn;

                CurrentActivatedBtn.BackColor = Color.FromArgb(37, 36, 81);
                CurrentActivatedBtn.ForeColor = color;
                CurrentActivatedBtn.TextAlign = ContentAlignment.MiddleCenter;
                CurrentActivatedBtn.IconColor = color;
                CurrentActivatedBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                CurrentActivatedBtn.ImageAlign = ContentAlignment.MiddleRight;

                LeftBorderPanel.BackColor = color;
                LeftBorderPanel.Location = new Point(0, CurrentActivatedBtn.Location.Y);               
                LeftBorderPanel.Visible = true;
                LeftBorderPanel.BringToFront();

                pbCurrentChildFormIcon.IconChar = CurrentActivatedBtn.IconChar;
                pbCurrentChildFormIcon.IconColor = color;

                lblCurrentChildFormTitle.Text = CurrentActivatedBtn.Text;
            }
        }

        private void DisableBtn()
        {
            if (CurrentActivatedBtn != null)
            {
                CurrentActivatedBtn.BackColor = Color.FromArgb(31, 30, 68);
                CurrentActivatedBtn.ForeColor = Color.Gainsboro;
                CurrentActivatedBtn.TextAlign = ContentAlignment.MiddleLeft;
                CurrentActivatedBtn.IconColor = Color.Gainsboro; ;
                CurrentActivatedBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                CurrentActivatedBtn.ImageAlign = ContentAlignment.MiddleLeft;

                CurrentChildForm.Close();
            }
        }

        private void OpenChildForm(Form ChildForm)
        {
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
            }

            CurrentChildForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            pnlChildFormContainer.Controls.Add(ChildForm);
            pnlChildFormContainer.Tag = ChildForm;
            ChildForm.BringToFront();
            ChildForm.Show();
            ChildForm.Focus();
        }

        private void Restart()
        {
            DisableBtn();
            pbCurrentChildFormIcon.IconChar = IconChar.Home;
            pbCurrentChildFormIcon.IconColor = Color.MediumPurple;
            lblCurrentChildFormTitle.Text = "Home";
            LeftBorderPanel.Visible = false;
            CurrentActivatedBtn = null;
        }

        private void MaximizeLogedClientMenu()
        {
            pnlLogedClientMenu.Size = pnlLogedClientMenu.MaximumSize;
        }

        private void MinimizeLogedClientMenu()
        {
            pnlLogedClientMenu.Size = pnlLogedClientMenu.MinimumSize;
        }


        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblLogo_Click(object sender, EventArgs e)
        {
            Restart();
        }

        private void lblLogo_MouseEnter(object sender, EventArgs e)
        {
            lblLogo.Cursor = Cursors.Hand;
        }


        private void btnAccounts_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color1);
            OpenChildForm(new frmClientAccounts());    
        }

        private void ibDeposit_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color4);
            OpenChildForm(new frmDeposit());
        }

        private void ibWithdraw_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color5);
            OpenChildForm(new frmWithdraw());
        }

        private void btnTransfere_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color6);
            OpenChildForm(new frmTransfer());
        }

        private void btnMyInformation_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color3);
            OpenChildForm(new frmClientInfo());
        }

        private void ibLogedClientName_Click(object sender, EventArgs e)
        {
            if (pnlLogedClientMenu.Size == pnlLogedClientMenu.MinimumSize)
            {
                MaximizeLogedClientMenu();
            }
            else
            {
                MinimizeLogedClientMenu();
            }
        }

        private void ibLogout_Click(object sender, EventArgs e)
        {
            Form frm = new frmLogin();
            frm.Show();
            this.Close();
        }
    }
}
