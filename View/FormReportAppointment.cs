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
    public partial class FormReportAppointment : Form
    {
        ControllerReportAppointment controller;
        public FormReportAppointment()
        {
            InitializeComponent();
            controller = new ControllerReportAppointment(this);
            controller.loadData();
        }

        public DataGridView dataGridViewReportAppintmentx
        {
            get { return dataGridViewReportAppintment; }
            set { dataGridViewReportAppintment = value; }
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
            controller.clean();
        }
    } 
}
