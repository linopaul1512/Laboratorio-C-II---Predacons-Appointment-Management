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
    public partial class FormLogin : Form
    {
        ControllerLogin controller;

        public FormLogin()
        {
            InitializeComponent();
            controller = new ControllerLogin(this);
        }


        public TextBox textBoxUsernamex
        {
            get { return textBoxUsername; }
            set { textBoxUsername = value; }
        }
        public TextBox textBoxPasswordx
        {
            get { return textBoxPassword; }
            set { textBoxPassword = value; }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.Clean();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            controller.Enter();
        }
    }
}
