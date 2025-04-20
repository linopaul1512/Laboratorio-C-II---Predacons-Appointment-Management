using Microsoft.Data.SqlClient;
using PredaconsAppointmentManagement.Models;
using PredaconsAppointmentManagement.View;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredaconsAppointmentManagement.Controller
{
    internal class ControllerLogin
    {
        FormLogin formlogin;
        Userx user;
        

        public ControllerLogin(FormLogin form)
        {
            formlogin = form;
        }

        public void Enter()
        {
            var db = new textC12Context();
            //var found = db.Userx.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            var found = db.Userx.FirstOrDefault(u => u.Username == formlogin.textBoxUsernamex.Text && u.Password == formlogin.textBoxPasswordx.Text);
            

            if (found != null)
            {
                string rol = found.Coderole;
                var foundrole = db.Role.Find(rol);
                string roleDB = foundrole.Descriptionrole;
                MessageBox.Show("The user has been found successfully", "User Found");
                FormMenu CL = new FormMenu(roleDB);
                CL.Show();
                Clean();
            }
            else if(found == null)
            {
                MessageBox.Show("The user has not been found successfully", "User not Found");
            }
        }


        public void Clean()
        {
            formlogin.textBoxUsernamex.Text = "";
            formlogin.textBoxPasswordx.Text = "";
        }
    }
}
