using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using ADUsers.Code;

namespace ADUsers
{
    public partial class FrmMain : Form
    {
        private int _totalUsers;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnGetUsers_Click(object sender, EventArgs e)
        {
            txtDomainController.Enabled = txtOuPath.Enabled = btnGetUsers.Enabled = false;
            dataGridView.DataSource = null;
            lblStatus.Text = "Please wait! Initializing user retrieving process...";
            bgWorkerGetUsers.RunWorkerAsync();
        }

        private void bgWorkerGetUsers_DoWork(object sender, DoWorkEventArgs e)
        {
            var paths = txtOuPath.Text.Split(';');

            e.Result = ADUtilities.InitiateRetrievingADUsers(txtDomainController.Text.Trim(), paths, "Administrator", "Pass99", bgWorkerGetUsers, ref _totalUsers);
        }

        private void bgWorkerGetUsers_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblStatus.Text = (string)e.UserState;
        }

        private void bgWorkerGetUsers_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Text = "Error was reported.";
                MessageBox.Show("Error:- " + e.Error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (_totalUsers > 0)
                {
                    lblStatus.Text = string.Format("{0} users were imported successfully!", _totalUsers);
                    var users = (List<ADPhotoUser>)e.Result;

                    // Sort users based on full name
                    users.Sort((a, b) => String.Compare(a.UserName, b.UserName, StringComparison.Ordinal));

                    // Bind to gridview
                    dataGridView.DataSource = users;
                }
                else
                    lblStatus.Text = "No user found!";
            }

            txtDomainController.Enabled = txtOuPath.Enabled = btnGetUsers.Enabled = true;
        }
    }
}


