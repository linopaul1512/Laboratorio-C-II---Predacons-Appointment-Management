using PredaconsAppointmentManagement.Models;
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
    public partial class FormMenu : Form
    {
        
        FormLogin formlogin;
        Userx user;
        string codrole;

        public FormMenu(string rol)
        {
            InitializeComponent();
            codrole = rol;

            if (rol == "Operator")
            {
                this.reportOfRolesToolStripMenuItem.Enabled = false;
                this.reportAppointmentToolStripMenuItem.Enabled = false;
                this.roleToolStripMenuItem.Enabled = false;
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clientToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormClient CL = new FormClient();
            CL.Show();
            CL.textBoxIDx.Focus();
        }

        private void workerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormWorker WO = new FormWorker();
            WO.Show();
            WO.textBoxIDx.Focus();
        }

        private void materialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMaterials FA = new FormMaterials();
            FA.Show();
            FA.textBoxCodeX.Focus();
        }

        private void serviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormService SE = new FormService();
            SE.Show();
            SE.textBoxCodex.Focus();
        }

        private void invoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInvoice IN = new FormInvoice();
            IN.Show();
            IN.textBoxCodeInvoicex.Focus();
        }

        private void appoimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAppointment FA = new FormAppointment();
            FA.Show();
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportAppointment RE = new FormReportAppointment();
            RE.Show();
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUser US = new FormUser();
            US.Show();
        }

        private void roleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormRole FA = new FormRole();
            FA.Show();
        }

        private void closeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void reportOfRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportRoles RR = new FormReportRoles();
            RR.Show();
        }

       

        private void reportAppointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReportAppointment RA = new FormReportAppointment();
            RA.Show();
        }

        
    }
}
