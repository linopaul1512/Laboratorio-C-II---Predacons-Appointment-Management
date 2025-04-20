using PredaconsAppointmentManagement.Models;
using PredaconsAppointmentManagement.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredaconsAppointmentManagement.Controller
{
    class ControllerRole
    {
        FormRole formrole;
        Role role;

        public ControllerRole(FormRole form)
        {
            formrole = form;
        }

        public void Include()
        {
            string description;
            textC12Context dbx = new textC12Context();
            string found = formrole.textBoxCodeRolex.Text;
            role = dbx.Role.Find(found);
            string coderole;

            if (formrole.textBoxCodeRolex==null && role == null)
            {
                using (var db = new textC12Context())
                {
                    if (formrole.radioButtonAdministratorx.Checked)
                    {
                        description = "Administrator";
                    }
                    else
                    {
                        description = "Operator";
                    }

                  
                    Role role = new Role()
                    {
                        Coderole = formrole.textBoxCodeRolex.Text,
                        Descriptionrole = description,
                        Statusrole = "A"
                    };
                    MessageBox.Show("The role has been successfully included", "Role Included");
                    db.Role.Add(role);
                    db.SaveChanges();

                }
            }
            else if (!ValidateForm() && role == null)
            {
                MessageBox.Show("The form is not filled", "Role not Included");

            }
            else if (!ValidateForm() && formrole.textBoxCodeRolex.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Role not Included");
            }
            else if(role != null)
            {
                MessageBox.Show("The role was not included because it already exists", "Role Not Included");
            }
           

        }

        public void Clean()
        {

            formrole.textBoxCodeRolex.Text = "";
            formrole.radioButtonAdministratorx.Checked = false;
            formrole.radioButtonOperatorx.Checked = false;

        }
        public bool ValidateForm()
        {
            return (formrole.textBoxCodeRolex.TextLength != 0);
        }


        public void Delete()
        {
            var db = new textC12Context();
            var record = db.Role.Where(x => x.Coderole == formrole.textBoxCodeRolex.Text).FirstOrDefault();
            record.Statusrole = "I";
            db.Update(record);
            db.SaveChanges();
            MessageBox.Show("The role have been successfully delete", "Role Delete");
            Clean();
        }

        public void Search()
        {
            textC12Context db = new textC12Context();
            string found = formrole.textBoxCodeRolex.Text;

            try
            {
                role = db.Role.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (role != null && role.Statusrole == "A")
            {

                //formclient.textBoxIDx.Enabled = false;
                formrole.textBoxCodeRolex.Text = role.Coderole;
                if (role.Coderole == "ro1")
                    formrole.radioButtonAdministratorx.Checked = true;
                else
                    formrole.radioButtonOperatorx.Checked = true;


                MessageBox.Show("The role has been found successfully", "Role Found");
            }

            else if (role != null && role.Statusrole == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the role?", "The Role is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Userx.Where(x => x.Codeuser == formrole.textBoxCodeRolex.Text).FirstOrDefault();
                    record.Statususer = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The role has been reactivated successfully", "Reactivated Role");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Delete();
                }
            }
            else if (role == null)
            {
                formrole.textBoxCodeRolex.Enabled = true;
                MessageBox.Show("The role has not been found successfully", "Role not Found");
            }

        }

        public void Modify()
        {
            textC12Context dbx = new textC12Context();
            var db = new textC12Context();
            string description;
            string found = formrole.textBoxCodeRolex.Text;
            role = db.Role.Find(found);



            if (formrole.radioButtonAdministratorx.Checked)
            {
                description = "Adminitrator";
            }
            else
            {
                description = "Operator";
            }

            if(ValidateForm() && role != null)
            {
                db.Role.Update(new Role()
                {
                    Descriptionrole = description,
                    Statusrole = "A",
                });
                db.SaveChanges();
                MessageBox.Show("The role have been successfully modified", "Role Update");

            }
            else if (!ValidateForm() && formrole.textBoxCodeRolex.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Role not Modified");
            }
            else if (role == null)
            {
                MessageBox.Show("The role has not been found successfully", "Role not Found");
            }

        }


   






    }
}
