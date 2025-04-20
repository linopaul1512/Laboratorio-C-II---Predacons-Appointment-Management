namespace PredaconsAppointmentManagement
{
    partial class FormClient
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
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxPhonenumber = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelPhonenumber = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelClient = new System.Windows.Forms.Label();
            this.dateTimePickerDatebirth = new System.Windows.Forms.DateTimePicker();
            this.labeldatebirth = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(522, 252);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(190, 20);
            this.textBoxAdress.TabIndex = 21;
            this.textBoxAdress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdress_Validating);
            // 
            // textBoxPhonenumber
            // 
            this.textBoxPhonenumber.Location = new System.Drawing.Point(522, 185);
            this.textBoxPhonenumber.Name = "textBoxPhonenumber";
            this.textBoxPhonenumber.Size = new System.Drawing.Size(190, 20);
            this.textBoxPhonenumber.TabIndex = 20;
            this.textBoxPhonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhonenumber_KeyPress);
            this.textBoxPhonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPhonenumber_Validating);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(522, 65);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(190, 20);
            this.textBoxID.TabIndex = 18;
            this.textBoxID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxID_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(522, 105);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(190, 20);
            this.textBoxName.TabIndex = 17;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(99, 259);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(39, 13);
            this.labelAdress.TabIndex = 16;
            this.labelAdress.Text = "Adress";
            // 
            // labelPhonenumber
            // 
            this.labelPhonenumber.AutoSize = true;
            this.labelPhonenumber.Location = new System.Drawing.Point(99, 185);
            this.labelPhonenumber.Name = "labelPhonenumber";
            this.labelPhonenumber.Size = new System.Drawing.Size(73, 13);
            this.labelPhonenumber.TabIndex = 15;
            this.labelPhonenumber.Text = "Phonenumber";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(99, 68);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 13;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(98, 108);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(64, 13);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name Client";
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClient.Location = new System.Drawing.Point(342, 9);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(75, 25);
            this.labelClient.TabIndex = 11;
            this.labelClient.Text = "Client";
            // 
            // dateTimePickerDatebirth
            // 
            this.dateTimePickerDatebirth.Location = new System.Drawing.Point(485, 215);
            this.dateTimePickerDatebirth.Name = "dateTimePickerDatebirth";
            this.dateTimePickerDatebirth.Size = new System.Drawing.Size(227, 20);
            this.dateTimePickerDatebirth.TabIndex = 22;
            // 
            // labeldatebirth
            // 
            this.labeldatebirth.AutoSize = true;
            this.labeldatebirth.Location = new System.Drawing.Point(98, 221);
            this.labeldatebirth.Name = "labeldatebirth";
            this.labeldatebirth.Size = new System.Drawing.Size(50, 13);
            this.labeldatebirth.TabIndex = 23;
            this.labeldatebirth.Text = "Datebirth";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(243, 374);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 43);
            this.buttonSearch.TabIndex = 28;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(431, 374);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 43);
            this.buttonDelete.TabIndex = 27;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(522, 312);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(114, 43);
            this.buttonModify.TabIndex = 26;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(332, 312);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(114, 43);
            this.buttonClean.TabIndex = 25;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(152, 312);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(114, 43);
            this.buttonInclude.TabIndex = 24;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(99, 145);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(53, 13);
            this.labelLastname.TabIndex = 29;
            this.labelLastname.Text = "Lastname";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(522, 142);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(190, 20);
            this.textBoxLastname.TabIndex = 30;
            this.textBoxLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastname_KeyPress);
            this.textBoxLastname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastname_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonInclude);
            this.Controls.Add(this.labeldatebirth);
            this.Controls.Add(this.dateTimePickerDatebirth);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxPhonenumber);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelPhonenumber);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelClient);
            this.Name = "FormClient";
            this.Text = "7";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxPhonenumber;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelPhonenumber;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatebirth;
        private System.Windows.Forms.Label labeldatebirth;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

