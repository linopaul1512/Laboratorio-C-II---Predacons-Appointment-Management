namespace PredaconsAppointmentManagement.View
{
    partial class FormUser
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
            this.textBoxAdress = new System.Windows.Forms.TextBox();
            this.textBoxPersonalName = new System.Windows.Forms.TextBox();
            this.textBoxCodeUser = new System.Windows.Forms.TextBox();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelPersonalName = new System.Windows.Forms.Label();
            this.labelCodeUser = new System.Windows.Forms.Label();
            this.labelTypeRole = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelLastname = new System.Windows.Forms.Label();
            this.textBoxLastname = new System.Windows.Forms.TextBox();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioButtonAdministrator = new System.Windows.Forms.RadioButton();
            this.radioButtonOperator = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(221, 376);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 43);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(461, 376);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 43);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(581, 376);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(114, 43);
            this.buttonModify.TabIndex = 42;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(341, 376);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(114, 43);
            this.buttonClean.TabIndex = 41;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(101, 376);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(114, 43);
            this.buttonInclude.TabIndex = 40;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(519, 270);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(190, 20);
            this.textBoxAdress.TabIndex = 37;
            this.textBoxAdress.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAdress_Validating);
            // 
            // textBoxPersonalName
            // 
            this.textBoxPersonalName.Location = new System.Drawing.Point(520, 140);
            this.textBoxPersonalName.Name = "textBoxPersonalName";
            this.textBoxPersonalName.Size = new System.Drawing.Size(190, 20);
            this.textBoxPersonalName.TabIndex = 36;
            this.textBoxPersonalName.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPersonalName_Validating);
            // 
            // textBoxCodeUser
            // 
            this.textBoxCodeUser.Location = new System.Drawing.Point(520, 49);
            this.textBoxCodeUser.Name = "textBoxCodeUser";
            this.textBoxCodeUser.Size = new System.Drawing.Size(190, 20);
            this.textBoxCodeUser.TabIndex = 35;
            this.textBoxCodeUser.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCodeUser_Validating);
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Location = new System.Drawing.Point(97, 270);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(39, 13);
            this.labelAdress.TabIndex = 33;
            this.labelAdress.Text = "Adress";
            // 
            // labelPersonalName
            // 
            this.labelPersonalName.AutoSize = true;
            this.labelPersonalName.Location = new System.Drawing.Point(97, 140);
            this.labelPersonalName.Name = "labelPersonalName";
            this.labelPersonalName.Size = new System.Drawing.Size(79, 13);
            this.labelPersonalName.TabIndex = 32;
            this.labelPersonalName.Text = "Personal Name";
            // 
            // labelCodeUser
            // 
            this.labelCodeUser.AutoSize = true;
            this.labelCodeUser.Location = new System.Drawing.Point(99, 56);
            this.labelCodeUser.Name = "labelCodeUser";
            this.labelCodeUser.Size = new System.Drawing.Size(57, 13);
            this.labelCodeUser.TabIndex = 31;
            this.labelCodeUser.Text = "Code User";
            // 
            // labelTypeRole
            // 
            this.labelTypeRole.AutoSize = true;
            this.labelTypeRole.Location = new System.Drawing.Point(97, 99);
            this.labelTypeRole.Name = "labelTypeRole";
            this.labelTypeRole.Size = new System.Drawing.Size(68, 13);
            this.labelTypeRole.TabIndex = 30;
            this.labelTypeRole.Text = "Type of Role";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(336, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(61, 25);
            this.labelUser.TabIndex = 29;
            this.labelUser.Text = "User";
            // 
            // labelLastname
            // 
            this.labelLastname.AutoSize = true;
            this.labelLastname.Location = new System.Drawing.Point(99, 186);
            this.labelLastname.Name = "labelLastname";
            this.labelLastname.Size = new System.Drawing.Size(53, 13);
            this.labelLastname.TabIndex = 45;
            this.labelLastname.Text = "Lastname";
            // 
            // textBoxLastname
            // 
            this.textBoxLastname.Location = new System.Drawing.Point(519, 186);
            this.textBoxLastname.Name = "textBoxLastname";
            this.textBoxLastname.Size = new System.Drawing.Size(190, 20);
            this.textBoxLastname.TabIndex = 46;
            this.textBoxLastname.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLastname_Validating);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(98, 228);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(55, 13);
            this.LabelUsername.TabIndex = 47;
            this.LabelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(518, 228);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(190, 20);
            this.textBoxUsername.TabIndex = 48;
            this.textBoxUsername.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxUsername_Validating);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(97, 318);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 49;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(519, 315);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(189, 20);
            this.textBoxPassword.TabIndex = 50;
            this.textBoxPassword.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPassword_Validating);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // radioButtonAdministrator
            // 
            this.radioButtonAdministrator.AutoSize = true;
            this.radioButtonAdministrator.Location = new System.Drawing.Point(520, 99);
            this.radioButtonAdministrator.Name = "radioButtonAdministrator";
            this.radioButtonAdministrator.Size = new System.Drawing.Size(85, 17);
            this.radioButtonAdministrator.TabIndex = 51;
            this.radioButtonAdministrator.TabStop = true;
            this.radioButtonAdministrator.Text = "Administrator";
            this.radioButtonAdministrator.UseVisualStyleBackColor = true;
            // 
            // radioButtonOperator
            // 
            this.radioButtonOperator.AutoSize = true;
            this.radioButtonOperator.Location = new System.Drawing.Point(620, 98);
            this.radioButtonOperator.Name = "radioButtonOperator";
            this.radioButtonOperator.Size = new System.Drawing.Size(66, 17);
            this.radioButtonOperator.TabIndex = 52;
            this.radioButtonOperator.TabStop = true;
            this.radioButtonOperator.Text = "Operator";
            this.radioButtonOperator.UseVisualStyleBackColor = true;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonOperator);
            this.Controls.Add(this.radioButtonAdministrator);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.textBoxLastname);
            this.Controls.Add(this.labelLastname);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonInclude);
            this.Controls.Add(this.textBoxAdress);
            this.Controls.Add(this.textBoxPersonalName);
            this.Controls.Add(this.textBoxCodeUser);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.labelPersonalName);
            this.Controls.Add(this.labelCodeUser);
            this.Controls.Add(this.labelTypeRole);
            this.Controls.Add(this.labelUser);
            this.Name = "FormUser";
            this.Text = "FormUser";
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
        private System.Windows.Forms.TextBox textBoxAdress;
        private System.Windows.Forms.TextBox textBoxPersonalName;
        private System.Windows.Forms.TextBox textBoxCodeUser;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelPersonalName;
        private System.Windows.Forms.Label labelCodeUser;
        private System.Windows.Forms.Label labelTypeRole;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelLastname;
        private System.Windows.Forms.TextBox textBoxLastname;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton radioButtonOperator;
        private System.Windows.Forms.RadioButton radioButtonAdministrator;
    }
}