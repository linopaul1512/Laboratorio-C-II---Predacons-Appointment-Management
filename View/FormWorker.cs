using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using PredaconsAppointmentManagement.Controller;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredaconsAppointmentManagement.View
{
    public partial class FormWorker : Form
    {
        ControllerWorker controller;
        public FormWorker()
        {
            InitializeComponent();
            controller = new ControllerWorker(this);
        }

        public TextBox textBoxIDx
        {
            get { return textBoxID; }
            set { textBoxID = value; }
        }

        public TextBox textBoxNamex
        {
            get { return textBoxName; }
            set { textBoxName = value; }
        }

        public TextBox textBoxLastnamex
        {
            get { return textBoxLastname; }
            set { textBoxLastname = value; }
        }

        public TextBox textBoxPhonenumberx
        {
            get { return textBoxPhonenumber; }
            set { textBoxPhonenumber = value; }
        }

        public DateTimePicker dateTimePickerDatebirthx
        {
            get { return dateTimePickerDatebirth; }
            set { dateTimePickerDatebirth = value; }
        }

        public TextBox textBoxAdressx
        {
            get { return textBoxAdress; }
            set { textBoxAdress = value; }
        }

        public RadioButton radioButtonMalex
        {
            get { return this.radioButtonMale; }
            set { this.radioButtonMale = value; }
        }

        public RadioButton radioButtonFemalex
        {
            get { return this.radioButtonFemale; }
            set { this.radioButtonFemale = value; }
        }
        private void buttonInclude_Click(object sender, EventArgs e)
        {
            controller.Include();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            controller.Modify();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.Search();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.Delete();
        }

        private void textBoxID_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxIDx,
               "The field cannot be empty");
        }

        private void textBoxName_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxNamex,
               "The field cannot be empty");
        }

        private void textBoxLastname_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxLastnamex,
               "The field cannot be empty");
        }

        private void textBoxPhonenumber_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxPhonenumberx,
               "The field cannot be empty");
        }

        private void textBoxAdress_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxAdressx,
               "The field cannot be empty");
        }

      

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Lyricsonly(e);
        }

        private void textBoxLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Lyricsonly(e);
        }

        private void textBoxPhonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Numberonly(e);
        }

        private void textBoxAdress_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Lyricsonly(e);
        }
    }
}
