namespace PredaconsAppointmentManagement.View
{
    partial class FormMaterials
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
            this.textBoxPuccharsePrice = new System.Windows.Forms.TextBox();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelPuccharsePrice = new System.Windows.Forms.Label();
            this.labelCode = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelMaterials = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSalePrice = new System.Windows.Forms.Label();
            this.textBoxSalePrice = new System.Windows.Forms.TextBox();
            this.textBoxQuantityAvailable = new System.Windows.Forms.TextBox();
            this.labelQuantity = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(241, 374);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(114, 43);
            this.buttonSearch.TabIndex = 44;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(429, 374);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(114, 43);
            this.buttonDelete.TabIndex = 43;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonModify
            // 
            this.buttonModify.Location = new System.Drawing.Point(520, 312);
            this.buttonModify.Name = "buttonModify";
            this.buttonModify.Size = new System.Drawing.Size(114, 43);
            this.buttonModify.TabIndex = 42;
            this.buttonModify.Text = "Modify";
            this.buttonModify.UseVisualStyleBackColor = true;
            this.buttonModify.Click += new System.EventHandler(this.buttonModify_Click);
            // 
            // buttonClean
            // 
            this.buttonClean.Location = new System.Drawing.Point(330, 312);
            this.buttonClean.Name = "buttonClean";
            this.buttonClean.Size = new System.Drawing.Size(114, 43);
            this.buttonClean.TabIndex = 41;
            this.buttonClean.Text = "Clean";
            this.buttonClean.UseVisualStyleBackColor = true;
            this.buttonClean.Click += new System.EventHandler(this.buttonClean_Click);
            // 
            // buttonInclude
            // 
            this.buttonInclude.Location = new System.Drawing.Point(150, 312);
            this.buttonInclude.Name = "buttonInclude";
            this.buttonInclude.Size = new System.Drawing.Size(114, 43);
            this.buttonInclude.TabIndex = 40;
            this.buttonInclude.Text = "Include";
            this.buttonInclude.UseVisualStyleBackColor = true;
            this.buttonInclude.Click += new System.EventHandler(this.buttonInclude_Click);
            // 
            // textBoxPuccharsePrice
            // 
            this.textBoxPuccharsePrice.Location = new System.Drawing.Point(524, 141);
            this.textBoxPuccharsePrice.Name = "textBoxPuccharsePrice";
            this.textBoxPuccharsePrice.Size = new System.Drawing.Size(190, 20);
            this.textBoxPuccharsePrice.TabIndex = 36;
            this.textBoxPuccharsePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPuccharsePrice_KeyPress);
            this.textBoxPuccharsePrice.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxPuccharsePrice_Validating);
            // 
            // textBoxCode
            // 
            this.textBoxCode.Location = new System.Drawing.Point(524, 49);
            this.textBoxCode.Name = "textBoxCode";
            this.textBoxCode.Size = new System.Drawing.Size(190, 20);
            this.textBoxCode.TabIndex = 35;
            this.textBoxCode.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxCode_Validating);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(524, 92);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(190, 20);
            this.textBoxDescription.TabIndex = 34;
            this.textBoxDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDescription_KeyPress);
            this.textBoxDescription.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDescription_Validating);
            // 
            // labelPuccharsePrice
            // 
            this.labelPuccharsePrice.AutoSize = true;
            this.labelPuccharsePrice.Location = new System.Drawing.Point(97, 141);
            this.labelPuccharsePrice.Name = "labelPuccharsePrice";
            this.labelPuccharsePrice.Size = new System.Drawing.Size(85, 13);
            this.labelPuccharsePrice.TabIndex = 32;
            this.labelPuccharsePrice.Text = "Puccharse Price";
            // 
            // labelCode
            // 
            this.labelCode.AutoSize = true;
            this.labelCode.Location = new System.Drawing.Point(97, 56);
            this.labelCode.Name = "labelCode";
            this.labelCode.Size = new System.Drawing.Size(32, 13);
            this.labelCode.TabIndex = 31;
            this.labelCode.Text = "Code";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(97, 95);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(60, 13);
            this.labelDescription.TabIndex = 30;
            this.labelDescription.Text = "Description";
            // 
            // labelMaterials
            // 
            this.labelMaterials.AutoSize = true;
            this.labelMaterials.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaterials.Location = new System.Drawing.Point(325, 18);
            this.labelMaterials.Name = "labelMaterials";
            this.labelMaterials.Size = new System.Drawing.Size(113, 25);
            this.labelMaterials.TabIndex = 29;
            this.labelMaterials.Text = "Materials";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 45;
            // 
            // labelSalePrice
            // 
            this.labelSalePrice.AutoSize = true;
            this.labelSalePrice.Location = new System.Drawing.Point(97, 239);
            this.labelSalePrice.Name = "labelSalePrice";
            this.labelSalePrice.Size = new System.Drawing.Size(55, 13);
            this.labelSalePrice.TabIndex = 46;
            this.labelSalePrice.Text = "Sale Price";
            // 
            // textBoxSalePrice
            // 
            this.textBoxSalePrice.Enabled = false;
            this.textBoxSalePrice.Location = new System.Drawing.Point(524, 239);
            this.textBoxSalePrice.Name = "textBoxSalePrice";
            this.textBoxSalePrice.Size = new System.Drawing.Size(190, 20);
            this.textBoxSalePrice.TabIndex = 47;
            this.textBoxSalePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSalePrice_KeyPress);
            // 
            // textBoxQuantityAvailable
            // 
            this.textBoxQuantityAvailable.Location = new System.Drawing.Point(524, 189);
            this.textBoxQuantityAvailable.Name = "textBoxQuantityAvailable";
            this.textBoxQuantityAvailable.Size = new System.Drawing.Size(190, 20);
            this.textBoxQuantityAvailable.TabIndex = 68;
            this.textBoxQuantityAvailable.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxQuantityAvailable_KeyPress);
            this.textBoxQuantityAvailable.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxQuantityAvailable_Validating);
            // 
            // labelQuantity
            // 
            this.labelQuantity.AutoSize = true;
            this.labelQuantity.Location = new System.Drawing.Point(97, 189);
            this.labelQuantity.Name = "labelQuantity";
            this.labelQuantity.Size = new System.Drawing.Size(95, 13);
            this.labelQuantity.TabIndex = 67;
            this.labelQuantity.Text = "Quantity  Available";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FormMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxQuantityAvailable);
            this.Controls.Add(this.labelQuantity);
            this.Controls.Add(this.textBoxSalePrice);
            this.Controls.Add(this.labelSalePrice);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonModify);
            this.Controls.Add(this.buttonClean);
            this.Controls.Add(this.buttonInclude);
            this.Controls.Add(this.textBoxPuccharsePrice);
            this.Controls.Add(this.textBoxCode);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.labelPuccharsePrice);
            this.Controls.Add(this.labelCode);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelMaterials);
            this.Name = "FormMaterials";
            this.Text = "FormMaterials";
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
        private System.Windows.Forms.TextBox textBoxPuccharsePrice;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelPuccharsePrice;
        private System.Windows.Forms.Label labelCode;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label labelMaterials;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSalePrice;
        private System.Windows.Forms.TextBox textBoxSalePrice;
        private System.Windows.Forms.TextBox textBoxQuantityAvailable;
        private System.Windows.Forms.Label labelQuantity;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}