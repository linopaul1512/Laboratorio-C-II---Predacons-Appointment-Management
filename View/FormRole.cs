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
    public partial class FormRole : Form
    {

        ControllerRole controller;
        public FormRole()
        {
            InitializeComponent();
            controller = new ControllerRole(this);
        }

        public TextBox textBoxCodeRolex
        {
            get { return textBoxCodeRolex; }
            set { textBoxCodeRolex = value; }
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

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            controller.Delete();
        }

        private void textBoxCodeRole_Validating(object sender, CancelEventArgs e)
        {
            Validations.validateTextBoxNoEmpty(errorProvider,
               textBoxCodeRole,
               "The field cannot be empty");
        }

       

        private void textBoxDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validations.Lyricsonly(e);
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            controller.Modify();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            controller.Search();
        }
    }
}
