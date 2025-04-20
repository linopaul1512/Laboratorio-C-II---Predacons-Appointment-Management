namespace PredaconsAppointmentManagement.View
{
    partial class FormInvoice
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
            this.textBoxCodeInvoice = new System.Windows.Forms.TextBox();
            this.labelCodeInvoice = new System.Windows.Forms.Label();
            this.buttonSearchAppointment = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonClean = new System.Windows.Forms.Button();
            this.buttonInclude = new System.Windows.Forms.Button();
            this.labelInvoiceDate = new System.Windows.Forms.Label();
            this.dateTimePickerInvoiceDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxCodeAppointment = new System.Windows.Forms.TextBox();
            this.labelCodeAppointment = new System.Windows.Forms.Label();
            this.labelInvoice = new System.Windows.Forms.Label();
            this.labelIVA = new System.Windows.Forms.Label();
            this.textBoxIVA = new System.Windows.Forms.TextBox();
            this.labelSalePrice = new System.Windows.Forms.Label();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.buttonInvoice = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelbaseamount = new System.Windows.Forms.Label();
            this.textBoxBaseAmount = new System.Windows.Forms.TextBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCodeInvoice
            // 
            this.textBoxCodeInvoice.Location = new System.Drawing.Point(516, 59);
            this.textBoxCodeInvoice.Name = "textBoxCodeInvoice";
            this.textBoxCodeInvoice.Size = new System.Drawing.Size(190, 20);
            this.textBoxCodeInvoice.TabIndex = 62;
            this.textBoxCodeInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodeInvoice_KeyPress);
            // 
            // labelCodeInvoice
            // 
            this.labelCodeInvoice.AutoSize = true;
            this.labelCodeInvoice.Location = new System.Drawing.Point(99, 62);
            this.labelCodeInvoice.Name = "labelCodeInvoice";
            this.labelCodeInvoice.Size = new System.Drawing.Size(70, 13);
            this.labelCodeInvoice.TabIndex = 61;
            this.labelCodeInvoice.Text = "Code Invoice";
            // 
            // buttonSearchAppointment
            // 
            this.buttonSearchAppointment.Location = new System.Drawing.Point(224, 338);
            this.buttonSearchAppointment.Name = "buttonSearchAppointment";
            this.buttonSearchAppointment.Size = new System.Drawing.Size(114, 43);
            this.buttonSearchAppointment.TabIndex = 60;
            this.buttonSearchAppointment.Text = "Search Appointment";
            this.buttonSearchAppointment.UseVisualStyleBackColor = true;
            this.buttonSearchAppointment.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(464, 338);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 43);
            this.buttonDelete.TabIndex = 59;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(584, 338);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(114, 43);
            this.buttonClean.TabIndex = 57;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(104, 338);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(114, 43);
            this.buttonInclude.TabIndex = 56;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // labelInvoiceDate
            // 
            this.labelInvoiceDate.AutoSize = true;
            this.labelInvoiceDate.Location = new System.Drawing.Point(99, 149);
            this.labelInvoiceDate.Name = "labelInvoiceDate";
            this.labelInvoiceDate.Size = new System.Drawing.Size(66, 13);
            this.labelInvoiceDate.TabIndex = 55;
            this.labelInvoiceDate.Text = "Invoice date";
            // 
            // dateTimePickerInvoiceDate
            // 
            this.dateTimePickerInvoiceDate.Enabled = false;
            this.dateTimePickerInvoiceDate.Location = new System.Drawing.Point(479, 149);
            this.dateTimePickerInvoiceDate.Name = "dateTimePickerInvoiceDate";
            this.dateTimePickerInvoiceDate.Size = new System.Drawing.Size(227, 20);
            this.dateTimePickerInvoiceDate.TabIndex = 54;
            // 
            // textBoxCodeAppointment
            // 
            this.textBoxCodeAppointment.Location = new System.Drawing.Point(516, 102);
            this.textBoxCodeAppointment.Name = "textBoxCodeAppointment";
            this.textBoxCodeAppointment.Size = new System.Drawing.Size(190, 20);
            this.textBoxCodeAppointment.TabIndex = 52;
            this.textBoxCodeAppointment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCodeAppointment_KeyPress);
            this.textBoxCodeAppointment.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCodeAppointment_Validating);
            // 
            // labelCodeAppointment
            // 
            this.labelCodeAppointment.AutoSize = true;
            this.labelCodeAppointment.Location = new System.Drawing.Point(99, 102);
            this.labelCodeAppointment.Name = "labelCodeAppointment";
            this.labelCodeAppointment.Size = new System.Drawing.Size(94, 13);
            this.labelCodeAppointment.TabIndex = 50;
            this.labelCodeAppointment.Text = "Code Appointment";
            // 
            // labelInvoice
            // 
            this.labelInvoice.AutoSize = true;
            this.labelInvoice.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvoice.Location = new System.Drawing.Point(329, 19);
            this.labelInvoice.Name = "labelInvoice";
            this.labelInvoice.Size = new System.Drawing.Size(88, 25);
            this.labelInvoice.TabIndex = 49;
            this.labelInvoice.Text = "Invoice";
            // 
            // labelIVA
            // 
            this.labelIVA.AutoSize = true;
            this.labelIVA.Location = new System.Drawing.Point(99, 219);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(24, 13);
            this.labelIVA.TabIndex = 63;
            this.labelIVA.Text = "IVA";
            // 
            // textBoxIVA
            // 
            this.textBoxIVA.Enabled = false;
            this.textBoxIVA.Location = new System.Drawing.Point(479, 219);
            this.textBoxIVA.Name = "textBoxIVA";
            this.textBoxIVA.Size = new System.Drawing.Size(226, 20);
            this.textBoxIVA.TabIndex = 64;
            this.textBoxIVA.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxIVA_Validating);
            // 
            // labelSalePrice
            // 
            this.labelSalePrice.AutoSize = true;
            this.labelSalePrice.Location = new System.Drawing.Point(99, 259);
            this.labelSalePrice.Name = "labelSalePrice";
            this.labelSalePrice.Size = new System.Drawing.Size(55, 13);
            this.labelSalePrice.TabIndex = 65;
            this.labelSalePrice.Text = "Sale Price";
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Enabled = false;
            this.textBoxSalePrice.Location = new System.Drawing.Point(480, 259);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.Size = new System.Drawing.Size(226, 20);
            this.textBoxSalePrice.TabIndex = 66;
            this.textBoxSalePrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxSalePrice_Validating);
            // 
            // buttonInvoice
            // 
            this.buttonInvoice.Location = new System.Drawing.Point(344, 338);
            this.buttonInvoice.Name = "buttonInvoice";
            this.buttonInvoice.Size = new System.Drawing.Size(114, 43);
            this.buttonInvoice.TabIndex = 67;
            this.buttonInvoice.Text = "Search Invoice";
            this.buttonInvoice.UseVisualStyleBackColor = true;
            this.buttonInvoice.Click += new System.EventHandler(this.buttonInvoice_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // labelbaseamount
            // 
            this.labelbaseamount.AutoSize = true;
            this.labelbaseamount.Location = new System.Drawing.Point(99, 187);
            this.labelbaseamount.Name = "labelbaseamount";
            this.labelbaseamount.Size = new System.Drawing.Size(70, 13);
            this.labelbaseamount.TabIndex = 68;
            this.labelbaseamount.Text = "Base Amount";
            // 
            // textBoxBaseAmount
            // 
            this.textBoxBaseAmount.Enabled = false;
            this.textBoxBaseAmount.Location = new System.Drawing.Point(480, 187);
            this.textBoxBaseAmount.Name = "textBoxBaseAmount";
            this.textBoxBaseAmount.Size = new System.Drawing.Size(226, 20);
            this.textBoxBaseAmount.TabIndex = 69;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(310, 403);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(106, 24);
            this.buttonCalculate.TabIndex = 70;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // FormInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.textBoxBaseAmount);
            this.Controls.Add(this.labelbaseamount);
            this.Controls.Add(this.buttonInvoice);
            this.Controls.Add(this.textBoxSalePrice);
            this.Controls.Add(this.labelSalePrice);
            this.Controls.Add(this.textBoxIVA);
            this.Controls.Add(this.labelIVA);
            this.Controls.Add(this.textBoxCodeInvoice);
            this.Controls.Add(this.labelCodeInvoice);
            this.Controls.Add(this.buttonSearchAppointment);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonInclude);
            this.Controls.Add(this.labelInvoiceDate);
            this.Controls.Add(this.dateTimePickerInvoiceDate);
            this.Controls.Add(this.textBoxCodeAppointment);
            this.Controls.Add(this.labelCodeAppointment);
            this.Controls.Add(this.labelInvoice);
            this.Name = "FormInvoice";
            this.Text = "FormInvoice";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxCodeInvoice;
        private System.Windows.Forms.Label labelCodeInvoice;
        private System.Windows.Forms.Button buttonSearchAppointment;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonClean;
        private System.Windows.Forms.Button buttonInclude;
        private System.Windows.Forms.Label labelInvoiceDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerInvoiceDate;
        private System.Windows.Forms.TextBox textBoxCodeAppointment;
        private System.Windows.Forms.Label labelCodeAppointment;
        private System.Windows.Forms.Label labelInvoice;
        private System.Windows.Forms.Label labelIVA;
        private System.Windows.Forms.TextBox textBoxIVA;
        private System.Windows.Forms.Label labelSalePrice;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.Button buttonInvoice;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label labelbaseamount;
        private System.Windows.Forms.TextBox textBoxBaseAmount;
        private System.Windows.Forms.Button buttonCalculate;
    }
}