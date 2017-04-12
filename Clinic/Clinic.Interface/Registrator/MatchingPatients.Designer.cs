namespace Clinic.Interface.Registrator
{
    partial class MatchingPatients
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelInputs = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanelButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonNewPatient = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSearchPatients = new System.Windows.Forms.Button();
            this.bindingSourcePatients = new System.Windows.Forms.BindingSource(this.components);
            this.labelledInputFirstName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputLastName = new Clinic.Interface.Common.LabelledInput();
            this.labelledInputEvidenceNumber = new Clinic.Interface.Common.LabelledInput();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanelMain.SuspendLayout();
            this.flowLayoutPanelInputs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            this.flowLayoutPanelButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatients)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelInputs, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewPatients, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.flowLayoutPanelButtons, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(476, 337);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // flowLayoutPanelInputs
            // 
            this.flowLayoutPanelInputs.Controls.Add(this.labelledInputFirstName);
            this.flowLayoutPanelInputs.Controls.Add(this.labelledInputLastName);
            this.flowLayoutPanelInputs.Controls.Add(this.labelledInputEvidenceNumber);
            this.flowLayoutPanelInputs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelInputs.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanelInputs.Name = "flowLayoutPanelInputs";
            this.flowLayoutPanelInputs.Size = new System.Drawing.Size(470, 49);
            this.flowLayoutPanelInputs.TabIndex = 0;
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AllowUserToAddRows = false;
            this.dataGridViewPatients.AllowUserToDeleteRows = false;
            this.dataGridViewPatients.AutoGenerateColumns = false;
            this.dataGridViewPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dataGridViewPatients.DataSource = this.bindingSourcePatients;
            this.dataGridViewPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatients.Location = new System.Drawing.Point(3, 98);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.ReadOnly = true;
            this.dataGridViewPatients.Size = new System.Drawing.Size(470, 236);
            this.dataGridViewPatients.TabIndex = 2;
            // 
            // flowLayoutPanelButtons
            // 
            this.flowLayoutPanelButtons.Controls.Add(this.buttonNewPatient);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonSearchPatients);
            this.flowLayoutPanelButtons.Controls.Add(this.buttonClear);
            this.flowLayoutPanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelButtons.Location = new System.Drawing.Point(3, 58);
            this.flowLayoutPanelButtons.Name = "flowLayoutPanelButtons";
            this.flowLayoutPanelButtons.Size = new System.Drawing.Size(470, 34);
            this.flowLayoutPanelButtons.TabIndex = 3;
            // 
            // buttonNewPatient
            // 
            this.buttonNewPatient.Location = new System.Drawing.Point(3, 3);
            this.buttonNewPatient.Name = "buttonNewPatient";
            this.buttonNewPatient.Size = new System.Drawing.Size(75, 23);
            this.buttonNewPatient.TabIndex = 0;
            this.buttonNewPatient.Text = "Add";
            this.buttonNewPatient.UseVisualStyleBackColor = true;
            this.buttonNewPatient.Click += new System.EventHandler(this.buttonAddPatient_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(165, 3);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSearchPatients
            // 
            this.buttonSearchPatients.Location = new System.Drawing.Point(84, 3);
            this.buttonSearchPatients.Name = "buttonSearchPatients";
            this.buttonSearchPatients.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchPatients.TabIndex = 2;
            this.buttonSearchPatients.Text = "Search";
            this.buttonSearchPatients.UseVisualStyleBackColor = true;
            // 
            // bindingSourcePatients
            // 
            this.bindingSourcePatients.DataSource = typeof(Clinic.Data.Patient);
            // 
            // labelledInputFirstName
            // 
            this.labelledInputFirstName.Input = "";
            this.labelledInputFirstName.Label = "First name";
            this.labelledInputFirstName.Location = new System.Drawing.Point(3, 3);
            this.labelledInputFirstName.Name = "labelledInputFirstName";
            this.labelledInputFirstName.Size = new System.Drawing.Size(133, 44);
            this.labelledInputFirstName.TabIndex = 0;
            this.labelledInputFirstName.InputChanged += new System.EventHandler(this.labelledInputFirstName_InputChanged);
            // 
            // labelledInputLastName
            // 
            this.labelledInputLastName.Input = "";
            this.labelledInputLastName.Label = "Last name";
            this.labelledInputLastName.Location = new System.Drawing.Point(142, 3);
            this.labelledInputLastName.Name = "labelledInputLastName";
            this.labelledInputLastName.Size = new System.Drawing.Size(143, 44);
            this.labelledInputLastName.TabIndex = 1;
            this.labelledInputLastName.InputChanged += new System.EventHandler(this.labelledInputLastName_InputChanged);
            // 
            // labelledInputEvidenceNumber
            // 
            this.labelledInputEvidenceNumber.Input = "";
            this.labelledInputEvidenceNumber.Label = "Evidence number";
            this.labelledInputEvidenceNumber.Location = new System.Drawing.Point(291, 3);
            this.labelledInputEvidenceNumber.Name = "labelledInputEvidenceNumber";
            this.labelledInputEvidenceNumber.Size = new System.Drawing.Size(149, 44);
            this.labelledInputEvidenceNumber.TabIndex = 2;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 82.45425F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "surname";
            this.surnameDataGridViewTextBoxColumn.FillWeight = 82.45425F;
            this.surnameDataGridViewTextBoxColumn.HeaderText = "surname";
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            this.surnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.FillWeight = 82.45425F;
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Edit.FillWeight = 125.7337F;
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 50;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.FillWeight = 126.9036F;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // MatchingPatients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "MatchingPatients";
            this.Size = new System.Drawing.Size(476, 337);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.flowLayoutPanelInputs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            this.flowLayoutPanelButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourcePatients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInputs;
        private Common.LabelledInput labelledInputFirstName;
        private Common.LabelledInput labelledInputLastName;
        private Common.LabelledInput labelledInputEvidenceNumber;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.BindingSource bindingSourcePatients;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtons;
        private System.Windows.Forms.Button buttonNewPatient;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSearchPatients;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}
