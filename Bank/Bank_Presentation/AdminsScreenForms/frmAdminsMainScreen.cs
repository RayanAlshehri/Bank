using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BankBuisnessTier;
using FontAwesome.Sharp;


namespace Bank_Presentation_Tier
{
    public partial class frmAdminsMainScreen : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private clsAdmin LogedAdmin;
        private IconButton CurrentActivatedBtn;
        private Panel LeftBorderPanel;
        private Form CurrentChildForm;
        public frmAdminsMainScreen(clsAdmin LogedAdmin)
        {
            InitializeComponent();

            try
            {
                clsRecords.SaveAdminLogin(LogedAdmin.ID);
            }
            catch (Exception DBerror) 
            {
                MessageBox.Show(DBerror.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.LogedAdmin = LogedAdmin;

            LeftBorderPanel = new Panel();
            LeftBorderPanel.Size = new Size(7, 60);
            pnlMenu.Controls.Add(LeftBorderPanel);

            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;

            ibLogedAdminName.Text = "Hello " + LogedAdmin.FirstName + "!";
        }

    

        private bool IsButtonFromMenu(IconButton button)
        {
            return button.Parent == pnlManageAdminsMenu || button.Parent == pnlManageClientsMenu 
                || button.Parent == pnlMangeAccountsMenu;
        }

        private int GetMenuButtonYlocation(IconButton button)
        {
            int Y = 0;
            int YlocationRelativeToParent = button.Location.Y;
            
            if (button.Parent == pnlManageAdminsMenu)
            {
                Point ParentLocation = pnlManageAdminsMenu.Location;
                Y = ParentLocation.Y + YlocationRelativeToParent;

                return Y;
            }
            else if (button.Parent == pnlManageClientsMenu)
            {
                Point ParentLocation = pnlManageClientsMenu.Location;
                Y = ParentLocation.Y + YlocationRelativeToParent;

                return Y;
            }
            else
            {
                Point ParentLocation = pnlMangeAccountsMenu.Location;
                Y = ParentLocation.Y + YlocationRelativeToParent;

                return Y;
            }
        }

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

                if (IsButtonFromMenu(CurrentActivatedBtn))
                {
                    LeftBorderPanel.Location = new Point(0, GetMenuButtonYlocation(CurrentActivatedBtn));
                }
                else
                {
                    LeftBorderPanel.Location = new Point(0, CurrentActivatedBtn.Location.Y);
                } 
                
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

        private void MaximizeManageAdminsMenu()
        {                       
            pnlManageAdminsMenu.Size = pnlManageAdminsMenu.MaximumSize;
            btnManageClients.Location = new Point(0, 438);
            btnViewTransfers.Location = new Point(0, 498);
            btnViewAdminsLogins.Location = new Point(0, 558);
            btnViewClientsLogins.Location = new Point(0, 618);                   
        }

        private void MinimizeManageAdminsMenu()
        {           
            pnlManageAdminsMenu.Size = pnlManageAdminsMenu.MinimumSize;
            btnManageClients.Location = new Point(0, 442 - 240);
            btnViewTransfers.Location = new Point(0, 502 - 240);
            btnViewAdminsLogins.Location = new Point(0, 562 - 240);
            btnViewClientsLogins.Location = new Point(0, 622 - 240);           
        }
    
        private void MaximizeManageClientsMenu()
        {
            if (CurrentActivatedBtn != null)
            {
                if (IsButtonFromMenu(CurrentActivatedBtn))
                    return;
            }          

            pnlManageClientsMenu.Size = pnlManageClientsMenu.MaximumSize;
            btnViewTransfers.Location = new Point(0, 498);
            btnViewAdminsLogins.Location = new Point(0, 558);
            btnViewClientsLogins.Location = new Point(0, 618);

            if (CurrentActivatedBtn != null)
            {
                if (!IsButtonFromMenu(CurrentActivatedBtn))
                    LeftBorderPanel.Location = CurrentActivatedBtn.Location;
            }
        }

        private void MinimizeManageClientsMenu()
        {
            if (CurrentActivatedBtn != null)
            {
                if (IsButtonFromMenu(CurrentActivatedBtn))
                    return;
            }

            pnlManageClientsMenu.Size = pnlManageClientsMenu.MinimumSize;
            btnManageClients.Location = new Point(0, 442 - 240);
            btnViewTransfers.Location = new Point(0, 502 - 240);
            btnViewAdminsLogins.Location = new Point(0, 562 - 240);
            btnViewClientsLogins.Location = new Point(0, 622 - 240);

            if (CurrentActivatedBtn != null)
            {
                if (!IsButtonFromMenu(CurrentActivatedBtn))
                    LeftBorderPanel.Location = CurrentActivatedBtn.Location;
            }
        }

        private void MaximizeLogedAdminMenu()
        {
            pnlLogedAdminMenu.Size = pnlLogedAdminMenu.MaximumSize;
        }

        private void MinimizeLogedAdminMenu()
        {
            pnlLogedAdminMenu.Size = pnlLogedAdminMenu.MinimumSize;
        }

        private void MaximizeAccountsMenu()
        {
            if (CurrentActivatedBtn != null)
            {
                if (IsButtonFromMenu(CurrentActivatedBtn))
                    return;
            }

            pnlMangeAccountsMenu.Size = pnlMangeAccountsMenu.MaximumSize;
            btnViewTransfers.Location = new Point(0, 498);
            btnViewAdminsLogins.Location = new Point(0, 558);
            btnViewClientsLogins.Location = new Point(0, 618);



            if (CurrentActivatedBtn != null)
            {
                if (!IsButtonFromMenu(CurrentActivatedBtn))
                    LeftBorderPanel.Location = CurrentActivatedBtn.Location;
            }
        }

        private void MinimizeAccountsMenu()
        {
            if (CurrentActivatedBtn != null)
            {
                if (IsButtonFromMenu(CurrentActivatedBtn))
                    return;
            }

            pnlMangeAccountsMenu.Size = pnlMangeAccountsMenu.MinimumSize;
            btnViewTransfers.Location = new Point(0, 498 - 240);
            btnViewAdminsLogins.Location = new Point(0, 558 - 240);
            btnViewClientsLogins.Location = new Point(0, 618 - 240);



            if (CurrentActivatedBtn != null)
            {
                if (!IsButtonFromMenu(CurrentActivatedBtn))
                    LeftBorderPanel.Location = CurrentActivatedBtn.Location;
            }
        }

        private void ShowAccessDeniedMessage(string Operation)
        {
            MessageBox.Show("Access denied. You don't have permission on this operation.", Operation, 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
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


        //Manage admins buttons:
        private void btnMangeAdmins_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn != null)
            {
                if (IsButtonFromMenu(CurrentActivatedBtn))
                    return;
            }

            if (pnlManageAdminsMenu.Size == pnlManageAdminsMenu.MinimumSize)
            {
                MaximizeManageAdminsMenu();

                pnlManageClientsMenu.Size = pnlManageClientsMenu.MinimumSize;
                pnlMangeAccountsMenu.Size = pnlMangeAccountsMenu.MinimumSize;              
            }
           else
            {
                MinimizeManageAdminsMenu();
            }

            if (CurrentActivatedBtn != null)
            {
                if (!IsButtonFromMenu(CurrentActivatedBtn))
                    LeftBorderPanel.Location = CurrentActivatedBtn.Location;
            }
        }

        private void btnViewAdminsList_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            if (!LogedAdmin.CheckPermissionOnAdmins(clsAdmin.enAdminsPermissions.ViewAdminsList))
            {
                ShowAccessDeniedMessage("View Admins");
                return;
            }

            ActivateBtn(sender, RGBColors.color1);
            OpenChildForm(new frmAdminsList());
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            if (!LogedAdmin.CheckPermissionOnAdmins(clsAdmin.enAdminsPermissions.AddNewAdmin))
            {
                ShowAccessDeniedMessage("Add Admin");
                return;
            }

            ActivateBtn(sender, RGBColors.color1);
            OpenChildForm(new frmAddAdmin());
        }

        private void btnUpdateAdmin_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            if (!LogedAdmin.CheckPermissionOnAdmins(clsAdmin.enAdminsPermissions.UpdateAdmin))
            {
                ShowAccessDeniedMessage("Update Admin");
                return;
            }

            ActivateBtn(sender, RGBColors.color1);
            OpenChildForm(new frmUpdateAdmin());
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            if (!LogedAdmin.CheckPermissionOnAdmins(clsAdmin.enAdminsPermissions.DeleteAdmin))
            {
                ShowAccessDeniedMessage("Delete Admin");
                return;
            }

            ActivateBtn(sender, RGBColors.color1);   
            OpenChildForm(new frmDeleteAdmin());
        }


        //Manage clients buttons:
        private void ManageClients_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn != null)
            {
                if (IsButtonFromMenu(CurrentActivatedBtn))
                    return;
            }

            if (pnlManageClientsMenu.Size == pnlManageClientsMenu.MinimumSize)
            {
                MaximizeManageClientsMenu();

                pnlManageAdminsMenu.Size = pnlManageAdminsMenu.MinimumSize;
                pnlMangeAccountsMenu.Size = pnlMangeAccountsMenu.MinimumSize;
            }
            else
            {
                MinimizeManageClientsMenu();
            }


            if (CurrentActivatedBtn != null)
            {
                if (!IsButtonFromMenu(CurrentActivatedBtn))
                    LeftBorderPanel.Location = CurrentActivatedBtn.Location;
            }
        }

        private void btnViewClientsList_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            if (!LogedAdmin.CheckPermissionOnClients(clsAdmin.enClientsPermissions.ViewClientsList))
            {
                ShowAccessDeniedMessage("View Clients");
                return;
            }

            ActivateBtn(sender, RGBColors.color2);
            OpenChildForm(new frmClientsList());
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            if (!LogedAdmin.CheckPermissionOnClients(clsAdmin.enClientsPermissions.AddNewClient))
            {
                ShowAccessDeniedMessage("Add Client");
                return;
            }

            ActivateBtn(sender, RGBColors.color2);
            OpenChildForm(new frmAddClient());
        }

        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }


            if (!LogedAdmin.CheckPermissionOnClients(clsAdmin.enClientsPermissions.UpdateClient))
            {
                ShowAccessDeniedMessage("Update Client");
                return;
            }

            ActivateBtn(sender, RGBColors.color2);
            OpenChildForm(new frmUpdateClient());
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }


            if (!LogedAdmin.CheckPermissionOnClients(clsAdmin.enClientsPermissions.DeleteClient))
            {
                ShowAccessDeniedMessage("Delete Client");
                return;
            }

            ActivateBtn(sender, RGBColors.color2);
            OpenChildForm(new frmDeleteClient());
        }


        //Manage accounts buttons:
        private void ibManageAccounts_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn != null)
            {
                if (IsButtonFromMenu(CurrentActivatedBtn))
                    return;
            }

            if (pnlMangeAccountsMenu.Size == pnlMangeAccountsMenu.MinimumSize)
            {
                MaximizeAccountsMenu();

                pnlManageAdminsMenu.Size = pnlManageAdminsMenu.MinimumSize;
                pnlManageClientsMenu.Size = pnlManageClientsMenu.MinimumSize;
            }
            else
            {
                MinimizeAccountsMenu();
            }

            if (CurrentActivatedBtn != null)
            {
                if (!IsButtonFromMenu(CurrentActivatedBtn))
                    LeftBorderPanel.Location = CurrentActivatedBtn.Location;
            }
        }

        private void ibViewAccounts_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color6);
            OpenChildForm(new frmViewAccounts());
        }

        private void ibAddAcount_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color6);
            OpenChildForm(new frmAddAccount());
        }

        private void ibDeleteAccount_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color6);
            OpenChildForm(new frmDeleteAccount());
        }


        //Other buttons in menu;
        private void btnViewTransfers_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color3);
            OpenChildForm(new frmTransferesList());
        }

        private void btnViewAdminsLogins_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color4);
            OpenChildForm(new frmAdminsLogins());
        }

        private void btnViewClientsLogins_Click(object sender, EventArgs e)
        {
            if (CurrentActivatedBtn == (IconButton)sender)
            {
                Restart();
                return;
            }

            ActivateBtn(sender, RGBColors.color5);        
            OpenChildForm(new frmClientsLogins());
        }

        private void ibLogedAdminName_Click(object sender, EventArgs e)
        {
            if (pnlLogedAdminMenu.Size == pnlLogedAdminMenu.MinimumSize)
            {
                MaximizeLogedAdminMenu();
            }
            else
            {
                MinimizeLogedAdminMenu();
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
