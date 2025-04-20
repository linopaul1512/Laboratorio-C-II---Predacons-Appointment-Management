using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PredaconsAppointmentManagement.Controller;

namespace PredaconsAppointmentManagement.View
{
    public partial class FormMaterials : Form
    {
        ControllerMaterial controller;
        public FormMaterials()
        {
            InitializeComponent();
            controller = new ControllerMaterial(this);
            this.textBoxCode.Focus();
        }


        public TextBox textBoxCodeX
        {
            get { return textBoxCode; }
            set { textBoxCode = value; }
        }
        public TextBox textBoxDescriptionX
        {
            get { return textBoxDescription; }
            set { textBoxDescription = value; }
        }

        public TextBox textBoxPuccharsePriceX
        {
            get { return textBoxPuccharsePrice; }
            set { textBoxPuccharsePrice = value; }
        }

        public TextBox textBoxSalePriceX
        {
            get { return textBoxSalePrice; }
            set { textBoxSalePrice = value; }
        }

        public TextBox textBoxQuantityAvailableX
        {
            get { return textBoxQuantityAvailable; }
            set { textBoxQuantityAvailable = value; }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            controller.Modify();
        }

        private void buttonInclude_Click(object sender, EventArgs e)
        {
            controller.Include();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.Search();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.Delete();
        }

        private void textBoxCode_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxCode,
               "The field cannot be empty");
        }

        private void textBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxDescription,
               "The field cannot be empty");
        }

        private void textBoxPuccharsePrice_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxPuccharsePrice,
               "The field cannot be empty");
        }



        private void textBoxQuantityAvailable_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxQuantityAvailable,
               "The field cannot be empty");
        }

      

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Lyricsonly(e);
        }

        private void textBoxPuccharsePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoxSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoxQuantityAvailable_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        
    }
}
