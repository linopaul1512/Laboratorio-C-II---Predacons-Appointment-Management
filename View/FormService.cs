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
    public partial class FormService : Form
    {
        ControllerService controller;
        public FormService()
        {
            InitializeComponent();
            controller = new ControllerService(this);
            this.textBoxCode.Focus();
        }


        public TextBox textBoxDescriptionx
        {
            get { return textBoxDescription; }
            set { textBoxDescription = value; }
        }


        public TextBox textBoxCodex
        {
            get { return textBoxCode; }
            set { textBoxCode = value; }
        }


        public TextBox textBoxSalePricex
        {
            get { return textBoxSalePrice; }
            set { textBoxSalePrice = value; }
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
             textBoxCodex,
             "The field cannot be empty");
        }

        private void textBoxDescription_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxDescriptionx,
               "The field cannot be empty");
        }

        private void textBoxSalePrice_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxSalePricex,
               "The field cannot be empty");
        }

        private void textBoxCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoxSalePrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }
    }
}
