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
    public partial class FormServiceAppointment : Form
    {
        public FormServiceAppointment()
        {
            InitializeComponent();
        }

        public TextBox textBoxCodeServiceAppointmentx
        {
            get { return textBoxCodeServiceAppointment; }
            set { textBoxCodeServiceAppointment = value; }
        }

        public TextBox textBoxCodeServicex
        {
            get { return textBoxCodeService; }
            set { textBoxCodeService = value; }
        }

        public TextBox textBoxAppointmentx
        {
            get { return textBoxAppointment; }
            set { textBoxAppointment = value; }
        }

        private void buttonInclude_Click(object sender, EventArgs e)
        {

        }
    }
}
