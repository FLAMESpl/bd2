﻿using Clinic.Facades.Visits;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxDoctor = new System.Windows.Forms.GroupBox();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.dataGridViewDailyVisits = new System.Windows.Forms.DataGridView();
            this.bindingSourceDailyVisit = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonBack = new System.Windows.Forms.Button();
            this.labelPatientName = new System.Windows.Forms.Label();
            this.labelPatient = new System.Windows.Forms.Label();
            this.visitHourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnButtonAddVisit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.listBoxDoctors = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBoxDoctor.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDailyVisit)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewDailyVisits, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 205F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.05882F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(601, 425);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.47826F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.52174F));
            this.tableLayoutPanel2.Controls.Add(this.groupBoxDoctor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupBoxDate, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(595, 199);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupBoxDoctor
            // 
            this.groupBoxDoctor.Controls.Add(this.listBoxDoctors);
            this.groupBoxDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDoctor.Location = new System.Drawing.Point(3, 3);
            this.groupBoxDoctor.Name = "groupBoxDoctor";
            this.groupBoxDoctor.Size = new System.Drawing.Size(276, 193);
            this.groupBoxDoctor.TabIndex = 2;
            this.groupBoxDoctor.TabStop = false;
            this.groupBoxDoctor.Text = "Doctor";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.monthCalendar);
            this.groupBoxDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDate.Location = new System.Drawing.Point(285, 3);
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.Size = new System.Drawing.Size(307, 193);
            this.groupBoxDate.TabIndex = 3;
            this.groupBoxDate.TabStop = false;
            this.groupBoxDate.Text = "Visit date";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.monthCalendar.Location = new System.Drawing.Point(3, 28);
            this.monthCalendar.MaxSelectionCount = 31;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            // 
            // dataGridViewDailyVisits
            // 
            this.dataGridViewDailyVisits.AutoGenerateColumns = false;
            this.dataGridViewDailyVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDailyVisits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitHourDataGridViewTextBoxColumn,
            this.doctorDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.ColumnButtonAddVisit});
            this.dataGridViewDailyVisits.DataSource = this.bindingSourceDailyVisit;
            this.dataGridViewDailyVisits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDailyVisits.Location = new System.Drawing.Point(3, 244);
            this.dataGridViewDailyVisits.Name = "dataGridViewDailyVisits";
            this.dataGridViewDailyVisits.Size = new System.Drawing.Size(595, 178);
            this.dataGridViewDailyVisits.TabIndex = 1;
            // 
            // bindingSourceDailyVisit
            // 
            this.bindingSourceDailyVisit.DataSource = typeof(Clinic.Facades.Visits.DailyVisit);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.Controls.Add(this.buttonBack, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPatientName, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPatient, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(595, 30);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(518, 3);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(74, 23);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // labelPatientName
            // 
            this.labelPatientName.AutoSize = true;
            this.labelPatientName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPatientName.Location = new System.Drawing.Point(377, 0);
            this.labelPatientName.Name = "labelPatientName";
            this.labelPatientName.Size = new System.Drawing.Size(135, 30);
            this.labelPatientName.TabIndex = 1;
            this.labelPatientName.Text = "Patient name";
            this.labelPatientName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPatient
            // 
            this.labelPatient.AutoSize = true;
            this.labelPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPatient.Location = new System.Drawing.Point(312, 0);
            this.labelPatient.Name = "labelPatient";
            this.labelPatient.Size = new System.Drawing.Size(59, 30);
            this.labelPatient.TabIndex = 2;
            this.labelPatient.Text = "Patient:";
            this.labelPatient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // visitHourDataGridViewTextBoxColumn
            // 
            this.visitHourDataGridViewTextBoxColumn.DataPropertyName = "VisitHour";
            dataGridViewCellStyle2.Format = "t";
            dataGridViewCellStyle2.NullValue = null;
            this.visitHourDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.visitHourDataGridViewTextBoxColumn.HeaderText = "VisitHour";
            this.visitHourDataGridViewTextBoxColumn.Name = "visitHourDataGridViewTextBoxColumn";
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Doctor";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.Width = 150;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Patient";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // ColumnButtonAddVisit
            // 
            this.ColumnButtonAddVisit.HeaderText = "";
            this.ColumnButtonAddVisit.Name = "ColumnButtonAddVisit";
            this.ColumnButtonAddVisit.ReadOnly = true;
            this.ColumnButtonAddVisit.Text = "Add";
            this.ColumnButtonAddVisit.UseColumnTextForButtonValue = true;
            this.ColumnButtonAddVisit.Width = 50;
            // 
            // listBoxDoctors
            // 
            this.listBoxDoctors.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxDoctors.FormattingEnabled = true;
            this.listBoxDoctors.Location = new System.Drawing.Point(3, 16);
            this.listBoxDoctors.Name = "listBoxDoctors";
            this.listBoxDoctors.Size = new System.Drawing.Size(270, 174);
            this.listBoxDoctors.TabIndex = 0;
            // 
            // VisitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 425);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "VisitForm";
            this.Text = "Visists";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBoxDoctor.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDailyVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDailyVisit)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBoxDoctor;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.BindingSource bindingSourceDailyVisit;
        private System.Windows.Forms.DataGridView dataGridViewDailyVisits;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label labelPatientName;
        private System.Windows.Forms.Label labelPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitHourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnButtonAddVisit;
        private System.Windows.Forms.ListBox listBoxDoctors;
    }
}