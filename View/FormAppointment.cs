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
    public partial class FormAppointment : Form
    {
        ControllerAppointment controller;

        public FormAppointment()
        {
            InitializeComponent();
            controller = new ControllerAppointment(this);
        }

        

        public TextBox textBoxCodeAppointmentx
        {
            get { return textBoCodeAppointment; }
            set { textBoCodeAppointment = value; }
        }
        public TextBox textBoxIDClientx
        {
            get { return textBoxIDClient; }
            set { textBoxIDClient = value; }
        }
        public TextBox textBoxIDWorkerx
        {
            get { return textBoxIDWorker; }
            set { textBoxIDWorker = value; }
        }
        public TextBox textBoxCodeServicex
        {
            get { return textBoxCodeService; }
            set { textBoxCodeService = value; }
        }
        public TextBox textBoxCodeMaterialx
        {
            get { return textBoxCodeMaterial; }
            set { textBoxCodeMaterial = value; }
        }

        public TextBox textBoxQuantityAvailablex
        {
            get { return textBoxQuantityAvailable; }
            set { textBoxQuantityAvailable = value; }
        }

        public TextBox textBoxQuantyMaterialx
        {
            get { return textBoxQuantyMaterial; }
            set { textBoxQuantyMaterial = value; }
        }
        public DateTimePicker dateTimePickerInstalationdatex
        {
            get { return dateTimePickerInstalationdate; }
            set { dateTimePickerInstalationdate = value; }
        }
        public DateTimePicker dateTimePickerPossibledatex
        {
            get { return dateTimePickerPossibledate; }
            set { dateTimePickerPossibledate = value; }
        }
        public DataGridView dataGridViewReportMaterialx
        {
            get { return dataGridViewReportMaterial; }
            set { dataGridViewReportMaterial = value; }
        }

        private void buttonInclude_Click(object sender, EventArgs e)
        {
            controller.Include();
        }

        private void buttonSearchMaterial_Click(object sender, EventArgs e)
        {
            controller.SearchMaterial();
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            controller.SearchClient();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.SearchAppointment();
        }

    
        private void buttonModify_Click(object sender, EventArgs e)
        {
            controller.Modify();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.Cancel();
        }

        private void buttonAddinAccount_Click(object sender, EventArgs e)
        {
            controller.AddinAccount();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonsSearchService_Click(object sender, EventArgs e)
        {
            controller.SearchService();
        }

        private void buttonSearchWorker_Click(object sender, EventArgs e)
        {
            controller.SearchWorker();
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            controller.Install();
        }

        private void textBoxQuantyMaterial_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoCodeAppointment_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoxIDClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoxIDWorker_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoCodeAppointment_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
              textBoCodeAppointment,
              "The field cannot be empty");
        }

        private void textBoxIDClient_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
              textBoxIDClient,
              "The field cannot be empty");
        }

        private void textBoxIDWorker_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
              textBoxIDWorker,
              "The field cannot be empty");
        }

        private void textBoxCodeService_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
              textBoxCodeService,
              "The field cannot be empty");
        }

        private void textBoxCodeMaterial_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
              textBoxCodeMaterial,
              "The field cannot be empty");
        }

      
    }
}
