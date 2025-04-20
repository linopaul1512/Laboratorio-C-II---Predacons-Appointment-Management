namespace PredaconsAppointmentManagement.View
{
    partial class FormWorker
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.labeldatebirth = new System.Windows.Forms.Label();
            this.dateTimePickerDatebirth = new System.Windows.Forms.DateTimePicker();
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxPhonenumber = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelPhonenumber = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWorker = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.labelrsex = new System.Windows.Forms.Label();
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(315, 475);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(152, 53);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(565, 475);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(152, 53);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(687, 399);
            this.buttonModify.Margin = new System.Windows.Forms.Padding(4);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(152, 53);
            this.buttonModify.TabIndex = 42;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(433, 399);
            this.buttonClean.Margin = new System.Windows.Forms.Padding(4);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(152, 53);
            this.buttonClean.TabIndex = 41;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(193, 399);
            this.buttonInclude.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(152, 53);
            this.buttonInclude.TabIndex = 40;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // labeldatebirth
            // 
            this.labeldatebirth.AutoSize = true;
            this.labeldatebirth.Location = new System.Drawing.Point(123, 249);
            this.labeldatebirth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldatebirth.Name = "labeldatebirth";
            this.labeldatebirth.Size = new System.Drawing.Size(66, 17);
            this.labeldatebirth.TabIndex = 39;
            this.labeldatebirth.Text = "Datebirth";
            // 
            // dateTimePickerDatebirth
            // 
            this.dateTimePickerDatebirth.Location = new System.Drawing.Point(640, 249);
            this.dateTimePickerDatebirth.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerDatebirth.Name = "dateTimePickerDatebirth";
            this.dateTimePickerDatebirth.Size = new System.Drawing.Size(301, 22);
            this.dateTimePickerDatebirth.TabIndex = 38;
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(687, 289);
            this.textBoxAdress.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(252, 22);
            this.textBoxAdress.TabIndex = 37;
            this.textBoxAdress.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAdress_KeyPress);
            this.textBoxAdress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdress_Validating);
            // 
            // textBoxPhonenumber
            // 
            this.textBoxPhonenumber.Location = new System.Drawing.Point(692, 196);
            this.textBoxPhonenumber.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPhonenumber.Name = "textBoxPhonenumber";
            this.textBoxPhonenumber.Size = new System.Drawing.Size(252, 22);
            this.textBoxPhonenumber.TabIndex = 36;
            this.textBoxPhonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPhonenumber_KeyPress);
            this.textBoxPhonenumber.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPhonenumber_Validating);
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(692, 75);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(252, 22);
            this.textBoxID.TabIndex = 35;
            this.textBoxID.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxID_Validating);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(693, 118);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(252, 22);
            this.textBoxName.TabIndex = 34;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxName_Validating);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(123, 298);
            this.labelAdress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(52, 17);
            this.labelAdress.TabIndex = 33;
            this.labelAdress.Text = "Adress";
            // 
            // labelPhonenumber
            // 
            this.labelPhonenumber.AutoSize = true;
            this.labelPhonenumber.Location = new System.Drawing.Point(123, 199);
            this.labelPhonenumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhonenumber.Name = "labelPhonenumber";
            this.labelPhonenumber.Size = new System.Drawing.Size(97, 17);
            this.labelPhonenumber.TabIndex = 32;
            this.labelPhonenumber.Text = "Phonenumber";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(123, 84);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(21, 17);
            this.labelID.TabIndex = 31;
            this.labelID.Text = "ID";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(123, 123);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(95, 17);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Name Worker";
            // 
            // labelWorker
            // 
            this.labelWorker.AutoSize = true;
            this.labelWorker.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorker.Location = new System.Drawing.Point(447, 26);
            this.labelWorker.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorker.Name = "labelWorker";
            this.labelWorker.Size = new System.Drawing.Size(114, 31);
            this.labelWorker.TabIndex = 29;
            this.labelWorker.Text = "Worker";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(123, 160);
            this.labelLastname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(70, 17);
            this.labelLastname.TabIndex = 45;
            this.labelLastname.Text = "Lastname";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(693, 156);
            this.textBoxLastname.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(248, 22);
            this.textBoxLastname.TabIndex = 46;
            this.textBoxLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLastname_KeyPress);
            this.textBoxLastname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastname_Validating);
            // 
            // labelrsex
            // 
            this.labelrsex.AutoSize = true;
            this.labelrsex.Location = new System.Drawing.Point(123, 345);
            this.labelrsex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelrsex.Name = "labelrsex";
            this.labelrsex.Size = new System.Drawing.Size(31, 17);
            this.labelrsex.TabIndex = 47;
            this.labelrsex.Text = "Sex";
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(692, 351);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(59, 21);
            this.radioButtonMale.TabIndex = 48;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(828, 351);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(75, 21);
            this.radioButtonFemale.TabIndex = 49;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormWorker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.Controls.Add(this.labelrsex);
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
            this.Controls.Add(this.labelWorker);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormWorker";
            this.Text = "FormWorker";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.Label labeldatebirth;
        private System.Windows.Forms.DateTimePicker dateTimePickerDatebirth;
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxPhonenumber;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelPhonenumber;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWorker;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label labelrsex;
        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}