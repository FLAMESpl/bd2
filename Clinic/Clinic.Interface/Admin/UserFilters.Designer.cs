namespace Clinic.Interface.Admin
{
    partial class UserFilters
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.inputUsername = new Clinic.Interface.Common.LabelledTextBox();
            this.inputRoles = new Clinic.Interface.Common.LabelledComboBox(this.components);
            this.buttonClear = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.inputUsername, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.inputRoles, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonClear, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(299, 52);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // inputUsername
            // 
            this.inputUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputUsername.Input = "";
            this.inputUsername.Label = "Username";
            this.inputUsername.Location = new System.Drawing.Point(3, 3);
            this.inputUsername.Name = "inputUsername";
            this.inputUsername.Size = new System.Drawing.Size(114, 144);
            this.inputUsername.TabIndex = 0;
            // 
            // inputRoles
            // 
            this.inputRoles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputRoles.Label = "Role";
            this.inputRoles.Location = new System.Drawing.Point(123, 3);
            this.inputRoles.Name = "inputRoles";
            this.inputRoles.Size = new System.Drawing.Size(94, 144);
            this.inputRoles.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(223, 25);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(3, 25, 3, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(44, 23);
            this.buttonClear.TabIndex = 2;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // UserFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "UserFilters";
            this.Size = new System.Drawing.Size(299, 52);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Common.LabelledTextBox inputUsername;
        private Common.LabelledComboBox inputRoles;
        private System.Windows.Forms.Button buttonClear;
    }
}
