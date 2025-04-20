using Microsoft.Win32.SafeHandles;
using PredaconsAppointmentManagement.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredaconsAppointmentManagement.View
{
    public partial class FormInvoice : Form
    {
        ControllerInvoice controller;
        public FormInvoice()
        {
            InitializeComponent();
            controller = new ControllerInvoice(this);
            this.textBoxCodeInvoice.Focus();
        }

        public TextBox textBoxCodeInvoicex
        {
            get { return textBoxCodeInvoice; }
            set { textBoxCodeInvoice = value; }
        }


        public TextBox textBoxCodeAppointmentx
        {
            get { return textBoxCodeAppointment; }
            set { textBoxCodeAppointment = value; }
        }

        public DateTimePicker dateTimePickerInvoiceDatex
        {
            get { return dateTimePickerInvoiceDate; }
            set { dateTimePickerInvoiceDate = value; }
        }

        public TextBox textBoxIVAx
        {
            get { return textBoxIVA; }
            set { textBoxIVA = value; }
        }

        public TextBox textBoxSalePricex
        {
            get { return textBoxSalePrice; }
            set { textBoxSalePrice = value; }
        }

        public TextBox textBoxBaseAmountx
        {
            get { return textBoxBaseAmount; }
            set { textBoxBaseAmount = value; }
        }


        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.SearchAppointment();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.Delete();
        }

        private void buttonInvoice_Click(object sender, EventArgs e)
        {
            controller.SearchInvoice();
        }

        private void buttonInclude_Click(object sender, EventArgs e)
        {
            controller.Include();
        }



        private void textBoxCodeAppointment_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
              textBoxCodeAppointment,
              "The field cannot be empty");
        }

        private void textBoxIVA_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
              textBoxIVA,
              "The field cannot be empty");
        }

        private void textBoxSalePrice_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
              textBoxSalePrice,
              "The field cannot be empty");
        }

        private void textBoxCodeInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoxCodeAppointment_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {

        }
    }
}
