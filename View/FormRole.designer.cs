namespace PredaconsAppointmentManagement.View
{
    partial class FormRole
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
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.textBoxCodeRole = new System.Windows.Forms.TextBox();
            this.labelCodeRole = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonSearch = new System.Windows.Forms.Button();
            this.buttonModify = new System.Windows.Forms.Button();
            this.radioButtonOperator = new System.Windows.Forms.RadioButton();
            this.radioButtonAdministrator = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(309, 324);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 43);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(189, 324);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(114, 43);
            this.buttonClean.TabIndex = 41;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(69, 324);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(114, 43);
            this.buttonInclude.TabIndex = 40;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // textBoxCodeRole
            // 
            this.textBoxCodeRole.Location = new System.Drawing.Point(519, 61);
            this.textBoxCodeRole.Name = "textBoxCodeRole";
            this.textBoxCodeRole.Size = new System.Drawing.Size(190, 20);
            this.textBoxCodeRole.TabIndex = 35;
            this.textBoxCodeRole.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCodeRole_Validating);
            // 
            // labelCodeRole
            // 
            this.labelCodeRole.AutoSize = true;
            this.labelCodeRole.Location = new System.Drawing.Point(92, 68);
            this.labelCodeRole.Name = "labelCodeRole";
            this.labelCodeRole.Size = new System.Drawing.Size(57, 13);
            this.labelCodeRole.TabIndex = 31;
            this.labelCodeRole.Text = "Code Role";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(92, 104);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 30;
            this.labelDescription.Text = "Description";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(353, 9);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(60, 25);
            this.labelRole.TabIndex = 29;
            this.labelRole.Text = "Role";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(429, 324);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 43);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(549, 324);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(114, 43);
            this.buttonModify.TabIndex = 45;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // radioButtonOperator
            // 
            this.radioButtonOperator.AutoSize = true;
            this.radioButtonOperator.Location = new System.Drawing.Point(619, 103);
            this.radioButtonOperator.Name = "radioButtonOperator";
            this.radioButtonOperator.Size = new System.Drawing.Size(66, 17);
            this.radioButtonOperator.TabIndex = 54;
            this.radioButtonOperator.TabStop = true;
            this.radioButtonOperator.Text = "Operator";
            this.radioButtonOperator.UseVisualStyleBackColor = true;
            // 
            // radioButtonAdministrator
            // 
            this.radioButtonAdministrator.AutoSize = true;
            this.radioButtonAdministrator.Location = new System.Drawing.Point(519, 104);
            this.radioButtonAdministrator.Name = "radioButtonAdministrator";
            this.radioButtonAdministrator.Size = new System.Drawing.Size(85, 17);
            this.radioButtonAdministrator.TabIndex = 53;
            this.radioButtonAdministrator.TabStop = true;
            this.radioButtonAdministrator.Text = "Administrator";
            this.radioButtonAdministrator.UseVisualStyleBackColor = true;
            // 
            // FormRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButtonOperator);
            this.Controls.Add(this.radioButtonAdministrator);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonInclude);
            this.Controls.Add(this.textBoxCodeRole);
            this.Controls.Add(this.labelCodeRole);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelRole);
            this.Name = "FormRole";
            this.Text = "FormRole";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.TextBox textBoxCodeRole;
        private System.Windows.Forms.Label labelCodeRole;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Button buttonModify;
        private System.Windows.Forms.RadioButton radioButtonOperator;
        private System.Windows.Forms.RadioButton radioButtonAdministrator;
    }
}