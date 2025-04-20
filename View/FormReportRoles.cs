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
    public partial class FormReportRoles : Form
    {
        ControllerReportRole controller;
        public FormReportRoles()
        {
            InitializeComponent();
            controller = new ControllerReportRole(this);
            controller.loadData();
        }

        public DataGridView dataGridViewReportRolesx
        {
            get { return dataGridViewReportRoles; }
            set { dataGridViewReportRoles = value; }
        }

        private void dataGridViewReportRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
