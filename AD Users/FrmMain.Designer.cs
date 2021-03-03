namespace ADUsers
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.bgWorkerGetUsers = new System.ComponentModel.BackgroundWorker();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.lblDomainController = new System.Windows.Forms.Label();
            this.btnGetUsers = new System.Windows.Forms.Button();
            this.txtOuPath = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblOuPath = new System.Windows.Forms.Label();
            this.txtDomainController = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgWorkerGetUsers
            // 
            this.bgWorkerGetUsers.WorkerReportsProgress = true;
            this.bgWorkerGetUsers.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorkerGetUsers_DoWork);
            this.bgWorkerGetUsers.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorkerGetUsers_ProgressChanged);
            this.bgWorkerGetUsers.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorkerGetUsers_RunWorkerCompleted);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightCyan;
            this.dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(15, 113);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.ShowRowErrors = false;
            this.dataGridView.Size = new System.Drawing.Size(381, 475);
            this.dataGridView.TabIndex = 6;
            // 
            // lblDomainController
            // 
            this.lblDomainController.AutoSize = true;
            this.lblDomainController.Location = new System.Drawing.Point(12, 22);
            this.lblDomainController.Name = "lblDomainController";
            this.lblDomainController.Size = new System.Drawing.Size(108, 15);
            this.lblDomainController.TabIndex = 1;
            this.lblDomainController.Text = "Domain Controller:";
            // 
            // btnGetUsers
            // 
            this.btnGetUsers.Location = new System.Drawing.Point(321, 84);
            this.btnGetUsers.Name = "btnGetUsers";
            this.btnGetUsers.Size = new System.Drawing.Size(75, 23);
            this.btnGetUsers.TabIndex = 5;
            this.btnGetUsers.Text = "Show Users";
            this.btnGetUsers.UseVisualStyleBackColor = true;
            this.btnGetUsers.Click += new System.EventHandler(this.btnGetUsers_Click);
            // 
            // txtOuPath
            // 
            this.txtOuPath.Location = new System.Drawing.Point(126, 50);
            this.txtOuPath.Name = "txtOuPath";
            this.txtOuPath.Size = new System.Drawing.Size(270, 23);
            this.txtOuPath.TabIndex = 4;
            this.txtOuPath.Text = "CN=Users,DC=domain,DC=com";
            this.toolTip.SetToolTip(this.txtOuPath, "Set empty for getting all users.");
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 610);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(407, 22);
            this.statusStrip.TabIndex = 7;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(26, 17);
            this.lblStatus.Text = "Idle";
            // 
            // lblOuPath
            // 
            this.lblOuPath.AutoSize = true;
            this.lblOuPath.Location = new System.Drawing.Point(12, 58);
            this.lblOuPath.Name = "lblOuPath";
            this.lblOuPath.Size = new System.Drawing.Size(92, 15);
            this.lblOuPath.TabIndex = 3;
            this.lblOuPath.Text = "Path to look for:";
            // 
            // txtDomainController
            // 
            this.txtDomainController.Location = new System.Drawing.Point(126, 14);
            this.txtDomainController.Name = "txtDomainController";
            this.txtDomainController.Size = new System.Drawing.Size(270, 23);
            this.txtDomainController.TabIndex = 2;
            this.txtDomainController.Text = "DC1.domain.com";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 632);
            this.Controls.Add(this.lblDomainController);
            this.Controls.Add(this.txtDomainController);
            this.Controls.Add(this.lblOuPath);
            this.Controls.Add(this.txtOuPath);
            this.Controls.Add(this.btnGetUsers);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.statusStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(423, 671);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(423, 671);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AD Users";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWorkerGetUsers;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblDomainController;
        private System.Windows.Forms.Button btnGetUsers;
        private System.Windows.Forms.TextBox txtOuPath;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.Label lblOuPath;
        private System.Windows.Forms.TextBox txtDomainController;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

