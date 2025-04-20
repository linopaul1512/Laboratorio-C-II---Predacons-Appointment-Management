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
    public partial class FormUser : Form
    {
        ControllerUser controller;
        public FormUser()
        {
            InitializeComponent();
            controller = new ControllerUser(this);
        }

        public TextBox textBoxCodeUserx
        {
            get { return textBoxCodeUser; }
            set { textBoxCodeUser = value; }
        }

        public TextBox textBoxPersonalNamex
        {
            get { return textBoxPersonalName; }
            set { textBoxPersonalName = value; }
        }
        public TextBox textBoxLastnamex
        {
            get { return textBoxLastname; }
            set { textBoxLastname = value; }
        }
        public TextBox textBoxAdressx
        {
            get { return textBoxAdress; }
            set { textBoxAdress = value; }
        }
        public TextBox textBoxPasswordx
        {
            get { return textBoxPassword; }
            set { textBoxPassword = value; }
        }

        public TextBox textBoxUsernamex
        {
            get { return textBoxUsername; }
            set { textBoxUsername = value; }
        }
        public RadioButton radioButtonAdministratorx
        {
            get { return this.radioButtonAdministrator; }
            set { this.radioButtonAdministrator = value; }
        }

        public RadioButton radioButtonOperatorx
        {
            get { return this.radioButtonOperator; }
            set { this.radioButtonOperator = value; }
        }


        private void buttonInclude_Click(object sender, EventArgs e)
        {
            controller.Include();
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            controller.Modify();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.Search();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }


        private void textBoxCodeUser_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxCodeUser,
               "The field cannot be empty");
        }


        private void textBoxPersonalName_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxPersonalName,
               "The field cannot be empty");
        }

        private void textBoxLastname_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxLastname,
               "The field cannot be empty");
        }

        private void textBoxUsername_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxLastname,
               "The field cannot be empty");
        }

        private void textBoxAdress_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxAdressx,
               "The field cannot be empty");
        }

        private void textBoxPassword_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxPassword,
               "The field cannot be empty");
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.Delete();
        }

   
    }
}
