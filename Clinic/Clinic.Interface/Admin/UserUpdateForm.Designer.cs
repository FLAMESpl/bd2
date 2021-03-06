﻿namespace Clinic.Interface.Admin
{
    partial class UserUpdateForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.groupBoxRole = new System.Windows.Forms.GroupBox();
            this.userFilters = new Clinic.Interface.Admin.UserFilters();
            this.doneCancelDialog = new Clinic.Interface.Common.DoneCancelDialog();
            this.labelledTextBoxPassword = new Clinic.Interface.Common.LabelledTextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxUser, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxRole, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.doneCancelDialog, 0, 3);
            this.tableLayoutPanelMain.Controls.Add(this.labelledTextBoxPassword, 0, 2);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 4;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(366, 246);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.Controls.Add(this.userFilters);
            this.groupBoxUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxUser.Location = new System.Drawing.Point(3, 3);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(360, 69);
            this.groupBoxUser.TabIndex = 0;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "User";
            // 
            // groupBoxRole
            // 
            this.groupBoxRole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxRole.Location = new System.Drawing.Point(3, 78);
            this.groupBoxRole.Name = "groupBoxRole";
            this.groupBoxRole.Size = new System.Drawing.Size(360, 69);
            this.groupBoxRole.TabIndex = 1;
            this.groupBoxRole.TabStop = false;
            this.groupBoxRole.Text = "Role";
            // 
            // userFilters
            // 
            this.userFilters.AllRolesEnabled = false;
            this.userFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userFilters.Location = new System.Drawing.Point(3, 16);
            this.userFilters.Name = "userFilters";
            this.userFilters.Role = Clinic.Facades.Users.Role.Registrator;
            this.userFilters.Size = new System.Drawing.Size(354, 50);
            this.userFilters.TabIndex = 0;
            this.userFilters.Username = "";
            // 
            // doneCancelDialog
            // 
            this.doneCancelDialog.Dock = System.Windows.Forms.DockStyle.Right;
            this.doneCancelDialog.Location = new System.Drawing.Point(150, 205);
            this.doneCancelDialog.Name = "doneCancelDialog";
            this.doneCancelDialog.Size = new System.Drawing.Size(213, 38);
            this.doneCancelDialog.TabIndex = 2;
            this.doneCancelDialog.Cancel += new System.EventHandler(this.doneCancelDialog_Cancel);
            this.doneCancelDialog.Done += new System.EventHandler(this.doneCancelDialog_Done);
            // 
            // labelledTextBoxPassword
            // 
            this.labelledTextBoxPassword.Input = "pass";
            this.labelledTextBoxPassword.Label = "Password:";
            this.labelledTextBoxPassword.Location = new System.Drawing.Point(3, 153);
            this.labelledTextBoxPassword.Name = "labelledTextBoxPassword";
            this.labelledTextBoxPassword.Size = new System.Drawing.Size(351, 44);
            this.labelledTextBoxPassword.TabIndex = 3;
            // 
            // UserUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 246);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "UserUpdateForm";
            this.Text = "User";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.groupBoxUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private UserFilters userFilters;
        private System.Windows.Forms.GroupBox groupBoxRole;
        private Common.DoneCancelDialog doneCancelDialog;
        private Common.LabelledTextBox labelledTextBoxPassword;
    }
}