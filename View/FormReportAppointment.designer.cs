namespace PredaconsAppointmentManagement.View
{
    partial class FormReportAppointment
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
            this.dataGridViewReportAppintment = new System.Windows.Forms.DataGridView();
            this.ColumnCodeAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIDWorker = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPossibleDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnInstalationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportAppintment)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportAppintment
            // 
            this.dataGridViewReportAppintment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportAppintment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodeAP,
            this.ColumnIDClient,
            this.ColumnIDWorker,
            this.ColumnPossibleDate,
            this.ColumnInstalationDate,
            this.ColumnStatus});
            this.dataGridViewReportAppintment.Location = new System.Drawing.Point(31, 53);
            this.dataGridViewReportAppintment.Name = "dataGridViewReportAppintment";
            this.dataGridViewReportAppintment.RowHeadersWidth = 51;
            this.dataGridViewReportAppintment.Size = new System.Drawing.Size(726, 334);
            this.dataGridViewReportAppintment.TabIndex = 0;
            // 
            // ColumnCodeAP
            // 
            this.ColumnCodeAP.HeaderText = "Code Appointment";
            this.ColumnCodeAP.MinimumWidth = 6;
            this.ColumnCodeAP.Name = "ColumnCodeAP";
            this.ColumnCodeAP.Width = 125;
            // 
            // ColumnIDClient
            // 
            this.ColumnIDClient.HeaderText = "ID Client";
            this.ColumnIDClient.Name = "ColumnIDClient";
            // 
            // ColumnIDWorker
            // 
            this.ColumnIDWorker.HeaderText = "ID Worker";
            this.ColumnIDWorker.Name = "ColumnIDWorker";
            // 
            // ColumnPossibleDate
            // 
            this.ColumnPossibleDate.HeaderText = "Possible Date";
            this.ColumnPossibleDate.MinimumWidth = 6;
            this.ColumnPossibleDate.Name = "ColumnPossibleDate";
            this.ColumnPossibleDate.Width = 125;
            // 
            // ColumnInstalationDate
            // 
            this.ColumnInstalationDate.HeaderText = "Instalation Date";
            this.ColumnInstalationDate.MinimumWidth = 6;
            this.ColumnInstalationDate.Name = "ColumnInstalationDate";
            this.ColumnInstalationDate.Width = 125;
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Status";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(643, 393);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(114, 27);
            this.buttonClean.TabIndex = 26;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // FormReportAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.dataGridViewReportAppintment);
            this.Name = "FormReportAppointment";
            this.Text = "FormReportAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportAppintment)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReportAppintment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodeAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIDWorker;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPossibleDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnInstalationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.Button buttonClean;
    }
}