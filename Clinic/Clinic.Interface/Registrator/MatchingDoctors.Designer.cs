namespace Clinic.Interface.Registrator
{
    partial class MatchingDoctors
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelInputs = new System.Windows.Forms.FlowLayoutPanel();
            this.labelledInputFirstName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputLastName = new Clinic.Interface.Common.LabelledInput();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.dataGridViewDoctors = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSourceDoctors = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel.SuspendLayout();
            this.flowLayoutPanelInputs.SuspendLayout();
            this.flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoctors)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 1;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelInputs, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.flowLayoutPanelButtons, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.dataGridViewDoctors, 0, 2);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(444, 268);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // flowLayoutPanelInputs
            // 
            this.flowLayoutPanelInputs.Controls.Add(this.labelledInputFirstName);
            this.flowLayoutPanelInputs.Controls.Add(this.labelledInputLastName);
            this.flowLayoutPanelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelInputs.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelInputs.Name = "flowLayoutPanelInputs";
            this.flowLayoutPanelInputs.Size = new System.Drawing.Size(438, 49);
            this.flowLayoutPanelInputs.TabIndex = 0;
            // 
            // labelledInputFirstName
            // 
            this.labelledInputFirstName.Input = "";
            this.labelledInputFirstName.Label = "First name";
            this.labelledInputFirstName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputFirstName.Name = "labelledInputFirstName";
            this.labelledInputFirstName.Size = new System.Drawing.Size(112, 44);
            this.labelledInputFirstName.TabIndex = 0;
            // 
            // labelledInputLastName
            // 
            this.labelledInputLastName.Input = "";
            this.labelledInputLastName.Label = "Last name";
            this.labelledInputLastName.Location = new System.Drawing.Point(121, 3);
            this.labelledInputLastName.Name = "labelledInputLastName";
            this.labelledInputLastName.Size = new System.Drawing.Size(112, 44);
            this.labelledInputLastName.TabIndex = 1;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonClear);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(3, 58);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(438, 34);
            this.flowLayoutPanelButtons.TabIndex = 1;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(3, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 23);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // dataGridViewDoctors
            // 
            this.dataGridViewDoctors.AutoGenerateColumns = false;
            this.dataGridViewDoctors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDoctors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn});
            this.dataGridViewDoctors.DataSource = this.bindingSourceDoctors;
            this.dataGridViewDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDoctors.Location = new System.Drawing.Point(3, 98);
            this.dataGridViewDoctors.Name = "dataGridViewDoctors";
            this.dataGridViewDoctors.Size = new System.Drawing.Size(438, 167);
            this.dataGridViewDoctors.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // bindingSourceDoctors
            // 
            this.bindingSourceDoctors.DataSource = typeof(Clinic.Data.Doctor);
            // 
            // MatchingDoctors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "MatchingDoctors";
            this.Size = new System.Drawing.Size(444, 268);
            this.tableLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanelInputs.ResumeLayout(false);
            this.flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDoctors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDoctors)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInputs;
        private Common.LabelledInput labelledInputFirstName;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private Common.LabelledInput labelledInputLastName;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.DataGridView dataGridViewDoctors;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bindingSourceDoctors;
    }
}
