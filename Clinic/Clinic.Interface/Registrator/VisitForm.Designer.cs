using Clinic.Facades.Visits;

namespace Clinic.Interface.Registrator
{
    partial class VisitForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelDoctors = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.listBoxDoctors = new System.Windows.Forms.ListBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewDailyVisits = new System.Windows.Forms.DataGridView();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Reserve = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.bindingSourceDailyVisit = new System.Windows.Forms.BindingSource(this.components);
            this.groupBoxPatient = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanelDoctors.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDailyVisit)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelDoctors, 0, 1);
            this.tableLayoutPanelMain.Controls.Add(this.dataGridViewDailyVisits, 0, 2);
            this.tableLayoutPanelMain.Controls.Add(this.groupBoxPatient, 0, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 3;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 192F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(656, 425);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanelDoctors
            // 
            this.tableLayoutPanelDoctors.ColumnCount = 2;
            this.tableLayoutPanelDoctors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.47826F));
            this.tableLayoutPanelDoctors.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.52174F));
            this.tableLayoutPanelDoctors.Controls.Add(this.groupBoxDoctor, 0, 0);
            this.tableLayoutPanelDoctors.Controls.Add(this.groupBoxDate, 1, 0);
            this.tableLayoutPanelDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelDoctors.Location = new System.Drawing.Point(3, 60);
            this.tableLayoutPanelDoctors.Name = "tableLayoutPanelDoctors";
            this.tableLayoutPanelDoctors.RowCount = 1;
            this.tableLayoutPanelDoctors.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelDoctors.Size = new System.Drawing.Size(650, 186);
            this.tableLayoutPanelDoctors.TabIndex = 0;
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.listBoxDoctors);
            this.groupBoxDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDoctor.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(302, 180);
            this.groupBoxDoctor.TabIndex = 2;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor";
            // 
            // listBoxDoctors
            // 
            this.listBoxDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDoctors.FormattingEnabled = true;
            this.listBoxDoctors.Location = new System.Drawing.Point(3, 16);
            this.listBoxDoctors.Name = "listBoxDoctors";
            this.listBoxDoctors.Size = new System.Drawing.Size(296, 161);
            this.listBoxDoctors.TabIndex = 0;
            this.listBoxDoctors.SelectedValueChanged += new System.EventHandler(this.listBoxDoctors_SelectedValueChanged);
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.monthCalendar);
            this.groupBoxDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDate.Location = new System.Drawing.Point(311, 3);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(336, 180);
            this.groupBoxDate.TabIndex = 3;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Visit date";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.monthCalendar.Location = new System.Drawing.Point(3, 15);
            this.monthCalendar.MaxSelectionCount = 31;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            // 
            // dataGridViewDailyVisits
            // 
            this.dataGridViewDailyVisits.AllowUserToAddRows = false;
            this.dataGridViewDailyVisits.AllowUserToDeleteRows = false;
            this.dataGridViewDailyVisits.AutoGenerateColumns = false;
            this.dataGridViewDailyVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDailyVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitHourDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.Reserve,
            this.Cancel,
            this.Delete});
            this.dataGridViewDailyVisits.DataSource = this.bindingSourceDailyVisit;
            this.dataGridViewDailyVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDailyVisits.Location = new System.Drawing.Point(3, 252);
            this.dataGridViewDailyVisits.Name = "dataGridViewDailyVisits";
            this.dataGridViewDailyVisits.ReadOnly = true;
            this.dataGridViewDailyVisits.Size = new System.Drawing.Size(650, 170);
            this.dataGridViewDailyVisits.TabIndex = 1;
            this.dataGridViewDailyVisits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDailyVisits_CellContentClick);
            // 
            // visitHourDataGridViewTextBoxColumn
            // 
            this.visitHourDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.visitHourDataGridViewTextBoxColumn.DataPropertyName = "VisitHour";
            dataGridViewCellStyle1.Format = "t";
            dataGridViewCellStyle1.NullValue = null;
            this.visitHourDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "Hour";
            this.visitHourDataGridViewTextBoxColumn.Name = "visitHourDataGridViewTextBoxColumn";
            this.visitHourDataGridViewTextBoxColumn.ReadOnly = true;
            this.visitHourDataGridViewTextBoxColumn.Width = 50;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.ReadOnly = true;
            this.doctorDataGridViewTextBoxColumn.Width = 150;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.ReadOnly = true;
            this.patientDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Reserve
            // 
            this.Reserve.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Reserve.HeaderText = "";
            this.Reserve.Name = "Reserve";
            this.Reserve.ReadOnly = true;
            this.Reserve.Text = "Reserve";
            this.Reserve.UseColumnTextForButtonValue = true;
            this.Reserve.Width = 50;
            // 
            // Cancel
            // 
            this.Cancel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cancel.HeaderText = "";
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseColumnTextForButtonValue = true;
            this.Cancel.Width = 50;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // bindingSourceDailyVisit
            // 
            this.bindingSourceDailyVisit.DataSource = typeof(Clinic.Facades.Visits.DailyVisit);
            // 
            // groupBoxPatient
            // 
            this.groupBoxPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPatient.Location = new System.Drawing.Point(3, 3);
            this.groupBoxPatient.Name = "groupBoxPatient";
            this.groupBoxPatient.Size = new System.Drawing.Size(650, 51);
            this.groupBoxPatient.TabIndex = 2;
            this.groupBoxPatient.TabStop = false;
            this.groupBoxPatient.Text = "Patient";
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 425);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "VisitForm";
            this.Text = "Visists";
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanelDoctors.ResumeLayout(false);
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDailyVisit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelDoctors;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.BindingSource bindingSourceDailyVisit;
        private System.Windows.Forms.DataGridView dataGridViewDailyVisits;
        private System.Windows.Forms.ListBox listBoxDoctors;
        private System.Windows.Forms.GroupBox groupBoxPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Reserve;
        private System.Windows.Forms.DataGridViewButtonColumn Cancel;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}