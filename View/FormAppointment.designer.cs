namespace PredaconsAppointmentManagement.View
{
    partial class FormAppointment
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
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.labelinstalationdate = new System.Windows.Forms.Label();
            this.dateTimePickerInstalationdate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCodeService = new System.Windows.Forms.TextBox();
            this.textBoCodeAppointment = new System.Windows.Forms.TextBox();
            this.labelCodeService = new System.Windows.Forms.Label();
            this.labelCodeAppointment = new System.Windows.Forms.Label();
            this.labelAppointment = new System.Windows.Forms.Label();
            this.textBoxIDClient = new System.Windows.Forms.TextBox();
            this.labelIDClient = new System.Windows.Forms.Label();
            this.textBoxIDWorker = new System.Windows.Forms.TextBox();
            this.labelIDWorker = new System.Windows.Forms.Label();
            this.labelCodeMateral = new System.Windows.Forms.Label();
            this.textBoxCodeMaterial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxQuantyMaterial = new System.Windows.Forms.TextBox();
            this.buttonSearchMaterial = new System.Windows.Forms.Button();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.buttonsSearchService = new System.Windows.Forms.Button();
            this.labelpossibledate = new System.Windows.Forms.Label();
            this.dateTimePickerPossibledate = new System.Windows.Forms.DateTimePicker();
            this.dataGridViewReportMaterial = new System.Windows.Forms.DataGridView();
            this.ColumnCodeMaterialAPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNameMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxComands = new System.Windows.Forms.GroupBox();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonSearchWorker = new System.Windows.Forms.Button();
            this.buttonAddinAccount = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxQuantityAvailable = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportMaterial)).BeginInit();
            this.groupBoxComands.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(1, 129);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 20);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(1, 208);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(114, 21);
            this.buttonCancel.TabIndex = 43;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(2, 182);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(112, 20);
            this.buttonModify.TabIndex = 42;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(2, 285);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(114, 20);
            this.buttonClean.TabIndex = 41;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(0, 19);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(114, 23);
            this.buttonInclude.TabIndex = 40;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // labelinstalationdate
            // 
            this.labelinstalationdate.AutoSize = true;
            this.labelinstalationdate.Location = new System.Drawing.Point(61, 245);
            this.labelinstalationdate.Name = "labelinstalationdate";
            this.labelinstalationdate.Size = new System.Drawing.Size(79, 13);
            this.labelinstalationdate.TabIndex = 39;
            this.labelinstalationdate.Text = "Instalation date";
            // 
            // dateTimePickerInstalationdate
            // 
            this.dateTimePickerInstalationdate.Location = new System.Drawing.Point(546, 245);
            this.dateTimePickerInstalationdate.Name = "dateTimePickerInstalationdate";
            this.dateTimePickerInstalationdate.Size = new System.Drawing.Size(227, 20);
            this.dateTimePickerInstalationdate.TabIndex = 38;
            // 
            // textBoxCodeService
            // 
            this.textBoxCodeService.Location = new System.Drawing.Point(583, 135);
            this.textBoxCodeService.Name = "textBoxCodeService";
            this.textBoxCodeService.Size = new System.Drawing.Size(190, 20);
            this.textBoxCodeService.TabIndex = 37;
            this.textBoxCodeService.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCodeService_Validating);
            // 
            // textBoCodeAppointment
            // 
            this.textBoCodeAppointment.Location = new System.Drawing.Point(583, 57);
            this.textBoCodeAppointment.Name = "textBoCodeAppointment";
            this.textBoCodeAppointment.Size = new System.Drawing.Size(190, 20);
            this.textBoCodeAppointment.TabIndex = 35;
            this.textBoCodeAppointment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoCodeAppointment_KeyPress);
            this.textBoCodeAppointment.Validating += new System.ComponentModel.CancelEventHandler(this.textBoCodeAppointment_Validating);
            // 
            // labelCodeService
            // 
            this.labelCodeService.AutoSize = true;
            this.labelCodeService.Location = new System.Drawing.Point(61, 135);
            this.labelCodeService.Name = "labelCodeService";
            this.labelCodeService.Size = new System.Drawing.Size(71, 13);
            this.labelCodeService.TabIndex = 33;
            this.labelCodeService.Text = "Code Service";
            // 
            // labelCodeAppointment
            // 
            this.labelCodeAppointment.AutoSize = true;
            this.labelCodeAppointment.Location = new System.Drawing.Point(62, 57);
            this.labelCodeAppointment.Name = "labelCodeAppointment";
            this.labelCodeAppointment.Size = new System.Drawing.Size(94, 13);
            this.labelCodeAppointment.TabIndex = 31;
            this.labelCodeAppointment.Text = "Code Appointment";
            // 
            // labelAppointment
            // 
            this.labelAppointment.AutoSize = true;
            this.labelAppointment.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppointment.Location = new System.Drawing.Point(291, 9);
            this.labelAppointment.Name = "labelAppointment";
            this.labelAppointment.Size = new System.Drawing.Size(146, 25);
            this.labelAppointment.TabIndex = 29;
            this.labelAppointment.Text = "Appointment";
            // 
            // textBoxIDClient
            // 
            this.textBoxIDClient.Location = new System.Drawing.Point(583, 83);
            this.textBoxIDClient.Name = "textBoxIDClient";
            this.textBoxIDClient.Size = new System.Drawing.Size(190, 20);
            this.textBoxIDClient.TabIndex = 46;
            this.textBoxIDClient.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDClient_KeyPress);
            this.textBoxIDClient.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIDClient_Validating);
            // 
            // labelIDClient
            // 
            this.labelIDClient.AutoSize = true;
            this.labelIDClient.Location = new System.Drawing.Point(62, 83);
            this.labelIDClient.Name = "labelIDClient";
            this.labelIDClient.Size = new System.Drawing.Size(47, 13);
            this.labelIDClient.TabIndex = 45;
            this.labelIDClient.Text = "ID Client";
            // 
            // textBoxIDWorker
            // 
            this.textBoxIDWorker.Location = new System.Drawing.Point(583, 109);
            this.textBoxIDWorker.Name = "textBoxIDWorker";
            this.textBoxIDWorker.Size = new System.Drawing.Size(190, 20);
            this.textBoxIDWorker.TabIndex = 48;
            this.textBoxIDWorker.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIDWorker_KeyPress);
            this.textBoxIDWorker.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIDWorker_Validating);
            // 
            // labelIDWorker
            // 
            this.labelIDWorker.AutoSize = true;
            this.labelIDWorker.Location = new System.Drawing.Point(62, 109);
            this.labelIDWorker.Name = "labelIDWorker";
            this.labelIDWorker.Size = new System.Drawing.Size(56, 13);
            this.labelIDWorker.TabIndex = 47;
            this.labelIDWorker.Text = "ID Worker";
            // 
            // labelCodeMateral
            // 
            this.labelCodeMateral.AutoSize = true;
            this.labelCodeMateral.Location = new System.Drawing.Point(61, 164);
            this.labelCodeMateral.Name = "labelCodeMateral";
            this.labelCodeMateral.Size = new System.Drawing.Size(72, 13);
            this.labelCodeMateral.TabIndex = 49;
            this.labelCodeMateral.Text = "Code Material";
            // 
            // textBoxCodeMaterial
            // 
            this.textBoxCodeMaterial.Location = new System.Drawing.Point(583, 164);
            this.textBoxCodeMaterial.Name = "textBoxCodeMaterial";
            this.textBoxCodeMaterial.Size = new System.Drawing.Size(190, 20);
            this.textBoxCodeMaterial.TabIndex = 50;
            this.textBoxCodeMaterial.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCodeMaterial_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Quantity material";
            // 
            // textBoxQuantyMaterial
            // 
            this.textBoxQuantyMaterial.Location = new System.Drawing.Point(583, 219);
            this.textBoxQuantyMaterial.Name = "textBoxQuantyMaterial";
            this.textBoxQuantyMaterial.Size = new System.Drawing.Size(190, 20);
            this.textBoxQuantyMaterial.TabIndex = 52;
            this.textBoxQuantyMaterial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantyMaterial_KeyPress);
            // 
            // buttonSearchMaterial
            // 
            this.buttonSearchMaterial.Location = new System.Drawing.Point(1, 74);
            this.buttonSearchMaterial.Name = "buttonSearchMaterial";
            this.buttonSearchMaterial.Size = new System.Drawing.Size(114, 24);
            this.buttonSearchMaterial.TabIndex = 53;
            this.buttonSearchMaterial.Text = "Search Material";
            this.buttonSearchMaterial.UseVisualStyleBackColor = true;
            this.buttonSearchMaterial.Click += new System.EventHandler(this.buttonSearchMaterial_Click);
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(1, 104);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(114, 19);
            this.buttonSearchClient.TabIndex = 54;
            this.buttonSearchClient.Text = "Search Client";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // buttonsSearchService
            // 
            this.buttonsSearchService.Location = new System.Drawing.Point(1, 155);
            this.buttonsSearchService.Name = "buttonsSearchService";
            this.buttonsSearchService.Size = new System.Drawing.Size(114, 22);
            this.buttonsSearchService.TabIndex = 55;
            this.buttonsSearchService.Text = "Search Service";
            this.buttonsSearchService.UseVisualStyleBackColor = true;
            this.buttonsSearchService.Click += new System.EventHandler(this.buttonsSearchService_Click);
            // 
            // labelpossibledate
            // 
            this.labelpossibledate.AutoSize = true;
            this.labelpossibledate.Location = new System.Drawing.Point(61, 270);
            this.labelpossibledate.Name = "labelpossibledate";
            this.labelpossibledate.Size = new System.Drawing.Size(72, 13);
            this.labelpossibledate.TabIndex = 56;
            this.labelpossibledate.Text = "Possible Date";
            // 
            // dateTimePickerPossibledate
            // 
            this.dateTimePickerPossibledate.Location = new System.Drawing.Point(548, 270);
            this.dateTimePickerPossibledate.Name = "dateTimePickerPossibledate";
            this.dateTimePickerPossibledate.Size = new System.Drawing.Size(225, 20);
            this.dateTimePickerPossibledate.TabIndex = 57;
            // 
            // dataGridViewReportMaterial
            // 
            this.dataGridViewReportMaterial.AllowUserToAddRows = false;
            this.dataGridViewReportMaterial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReportMaterial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCodeMaterialAPP,
            this.ColumnNameMaterial,
            this.ColumnQuantity});
            this.dataGridViewReportMaterial.Location = new System.Drawing.Point(453, 377);
            this.dataGridViewReportMaterial.Name = "dataGridViewReportMaterial";
            this.dataGridViewReportMaterial.RowHeadersVisible = false;
            this.dataGridViewReportMaterial.RowHeadersWidth = 51;
            this.dataGridViewReportMaterial.Size = new System.Drawing.Size(320, 233);
            this.dataGridViewReportMaterial.TabIndex = 58;
            // 
            // ColumnCodeMaterialAPP
            // 
            this.ColumnCodeMaterialAPP.HeaderText = "Code Material";
            this.ColumnCodeMaterialAPP.MinimumWidth = 6;
            this.ColumnCodeMaterialAPP.Name = "ColumnCodeMaterialAPP";
            this.ColumnCodeMaterialAPP.Width = 125;
            // 
            // ColumnNameMaterial
            // 
            this.ColumnNameMaterial.HeaderText = "Name Material";
            this.ColumnNameMaterial.Name = "ColumnNameMaterial";
            // 
            // ColumnQuantity
            // 
            this.ColumnQuantity.HeaderText = "Quantity";
            this.ColumnQuantity.Name = "ColumnQuantity";
            // 
            // groupBoxComands
            // 
            this.groupBoxComands.Controls.Add(this.buttonInstall);
            this.groupBoxComands.Controls.Add(this.buttonSearchWorker);
            this.groupBoxComands.Controls.Add(this.buttonAddinAccount);
            this.groupBoxComands.Controls.Add(this.buttonInclude);
            this.groupBoxComands.Controls.Add(this.buttonSearchMaterial);
            this.groupBoxComands.Controls.Add(this.buttonClean);
            this.groupBoxComands.Controls.Add(this.buttonSearchClient);
            this.groupBoxComands.Controls.Add(this.buttonsSearchService);
            this.groupBoxComands.Controls.Add(this.buttonSearch);
            this.groupBoxComands.Controls.Add(this.buttonModify);
            this.groupBoxComands.Controls.Add(this.buttonCancel);
            this.groupBoxComands.Location = new System.Drawing.Point(65, 305);
            this.groupBoxComands.Name = "groupBoxComands";
            this.groupBoxComands.Size = new System.Drawing.Size(113, 311);
            this.groupBoxComands.TabIndex = 59;
            this.groupBoxComands.TabStop = false;
            this.groupBoxComands.Text = "Comands";
            // 
            // buttonInstall
            // 
            this.buttonInstall.Location = new System.Drawing.Point(0, 260);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(114, 19);
            this.buttonInstall.TabIndex = 60;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonSearchWorker
            // 
            this.buttonSearchWorker.Location = new System.Drawing.Point(-1, 48);
            this.buttonSearchWorker.Name = "buttonSearchWorker";
            this.buttonSearchWorker.Size = new System.Drawing.Size(114, 20);
            this.buttonSearchWorker.TabIndex = 60;
            this.buttonSearchWorker.Text = "Search Worker";
            this.buttonSearchWorker.UseVisualStyleBackColor = true;
            this.buttonSearchWorker.Click += new System.EventHandler(this.buttonSearchWorker_Click);
            // 
            // buttonAddinAccount
            // 
            this.buttonAddinAccount.Location = new System.Drawing.Point(1, 235);
            this.buttonAddinAccount.Name = "buttonAddinAccount";
            this.buttonAddinAccount.Size = new System.Drawing.Size(114, 20);
            this.buttonAddinAccount.TabIndex = 60;
            this.buttonAddinAccount.Text = "Add in Account";
            this.buttonAddinAccount.UseVisualStyleBackColor = true;
            this.buttonAddinAccount.Click += new System.EventHandler(this.buttonAddinAccount_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Quantity Available";
            // 
            // textBoxQuantityAvailable
            // 
            this.textBoxQuantityAvailable.Enabled = false;
            this.textBoxQuantityAvailable.Location = new System.Drawing.Point(583, 193);
            this.textBoxQuantityAvailable.Name = "textBoxQuantityAvailable";
            this.textBoxQuantityAvailable.Size = new System.Drawing.Size(190, 20);
            this.textBoxQuantityAvailable.TabIndex = 61;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(800, 632);
            this.Controls.Add(this.textBoxQuantityAvailable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBoxComands);
            this.Controls.Add(this.dataGridViewReportMaterial);
            this.Controls.Add(this.dateTimePickerPossibledate);
            this.Controls.Add(this.labelpossibledate);
            this.Controls.Add(this.textBoxQuantyMaterial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCodeMaterial);
            this.Controls.Add(this.labelCodeMateral);
            this.Controls.Add(this.textBoxIDWorker);
            this.Controls.Add(this.labelIDWorker);
            this.Controls.Add(this.textBoxIDClient);
            this.Controls.Add(this.labelIDClient);
            this.Controls.Add(this.labelinstalationdate);
            this.Controls.Add(this.dateTimePickerInstalationdate);
            this.Controls.Add(this.textBoxCodeService);
            this.Controls.Add(this.textBoCodeAppointment);
            this.Controls.Add(this.labelCodeService);
            this.Controls.Add(this.labelCodeAppointment);
            this.Controls.Add(this.labelAppointment);
            this.Name = "FormAppointment";
            this.Text = "FormAppointment";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReportMaterial)).EndInit();
            this.groupBoxComands.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.Label labelinstalationdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerInstalationdate;
        private System.Windows.Forms.TextBox textBoxCodeService;
        private System.Windows.Forms.TextBox textBoCodeAppointment;
        private System.Windows.Forms.Label labelCodeService;
        private System.Windows.Forms.Label labelCodeAppointment;
        private System.Windows.Forms.Label labelAppointment;
        private System.Windows.Forms.TextBox textBoxIDClient;
        private System.Windows.Forms.Label labelIDClient;
        private System.Windows.Forms.TextBox textBoxIDWorker;
        private System.Windows.Forms.Label labelIDWorker;
        private System.Windows.Forms.Label labelCodeMateral;
        private System.Windows.Forms.TextBox textBoxCodeMaterial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxQuantyMaterial;
        private System.Windows.Forms.Button buttonSearchMaterial;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.Button buttonsSearchService;
        private System.Windows.Forms.Label labelpossibledate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPossibledate;
        private System.Windows.Forms.DataGridView dataGridViewReportMaterial;
        private System.Windows.Forms.GroupBox groupBoxComands;
        private System.Windows.Forms.Button buttonAddinAccount;
        private System.Windows.Forms.Button buttonSearchWorker;
        private System.Windows.Forms.Button buttonInstall;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxQuantityAvailable;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCodeMaterialAPP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNameMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQuantity;
    }
}