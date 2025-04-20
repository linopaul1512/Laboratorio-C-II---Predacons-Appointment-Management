namespace PredaconsAppointmentManagement.View
{
    partial class FormReportRoles
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
            this.dataGridViewReportRoles = new System.Windows.Forms.DataGridView();
            this.ColumnCodeRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewReportRoles
            // 
            this.dataGridViewReportRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportRoles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodeRole,
            this.ColumnDescription});
            this.dataGridViewReportRoles.Location = new System.Drawing.Point(269, 126);
            this.dataGridViewReportRoles.Name = "dataGridViewReportRoles";
            this.dataGridViewReportRoles.RowHeadersWidth = 51;
            this.dataGridViewReportRoles.Size = new System.Drawing.Size(298, 163);
            this.dataGridViewReportRoles.TabIndex = 46;
            this.dataGridViewReportRoles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewReportRoles_CellContentClick);
            // 
            // ColumnCodeRole
            // 
            this.ColumnCodeRole.HeaderText = "Code Role";
            this.ColumnCodeRole.MinimumWidth = 6;
            this.ColumnCodeRole.Name = "ColumnCodeRole";
            this.ColumnCodeRole.Width = 125;
            // 
            // ColumnDescription
            // 
            this.ColumnDescription.HeaderText = "Description";
            this.ColumnDescription.MinimumWidth = 6;
            this.ColumnDescription.Name = "ColumnDescription";
            this.ColumnDescription.Width = 125;
            // 
            // FormReportRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewReportRoles);
            this.Name = "FormReportRoles";
            this.Text = "FormReportRoles";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReportRoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodeRole;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescription;
    }
}