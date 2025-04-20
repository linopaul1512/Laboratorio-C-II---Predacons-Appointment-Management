using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PredaconsAppointmentManagement.View;
using System.Windows.Forms;
using PredaconsAppointmentManagement.Models;

namespace PredaconsAppointmentManagement.Controller
{
    class ControllerUser
    {
        FormUser formuser;
        Userx user;

        public ControllerUser(FormUser form)
        {
            formuser = form;
        }

        public void Include()
        {
            string coderole;
            textC12Context dbx = new textC12Context();
            string found = formuser.textBoxCodeUserx.Text;
            user = dbx.Userx.Find(found);


            using (var db = new textC12Context())
            {
                if (formuser.radioButtonAdministratorx.Checked)
                {
                    coderole = "r01";
                }
                else
                {
                    coderole = "r02";
                }

                if(ValidateForm() && user == null)
                {
                    Userx user = new Userx()
                    {
                        Codeuser = formuser.textBoxCodeUserx.Text,
                        Coderole = coderole,
                        Personalname = formuser.textBoxPersonalNamex.Text,
                        Lastname = formuser.textBoxLastnamex.Text,
                        Username = formuser.textBoxUsernamex.Text,
                        Adress = formuser.textBoxAdressx.Text,
                        Password = formuser.textBoxPasswordx.Text,
                        Statususer = "A"
                    };
                    MessageBox.Show("The user has been successfully included", "User Included");
                    db.Userx.Add(user);
                    db.SaveChanges();
                }
                else if (!ValidateForm() && formuser.textBoxCodeUserx.TextLength != 0 || !ValidateForm())
                {
                    MessageBox.Show("The form is not filled", "User not Included");
                }
                else if (user != null)
                {
                    MessageBox.Show("The user could not be included because it already exists", "User Not Included");
                }


            }

        }


        public void Search()
        {
            textC12Context db = new textC12Context();
            string found = formuser.textBoxCodeUserx.Text;

            try
            {
                user = db.Userx.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (user != null && user.Statususer == "A")
            {

                formuser.textBoxCodeUserx.Enabled = false;
                formuser.textBoxCodeUserx.Text = user.Codeuser;
                formuser.textBoxLastnamex.Text = user.Lastname;
                if (user.Coderole == "ro1")
                    formuser.radioButtonAdministratorx.Checked = true;
                else
                    formuser.radioButtonOperatorx.Checked = true;
                formuser .textBoxPersonalNamex.Text = user.Personalname;
                formuser.textBoxLastnamex.Text = user.Lastname;
                formuser.textBoxUsernamex.Text = user.Username;
                formuser.textBoxAdressx.Text = user.Adress;
                formuser.textBoxPasswordx.Text = user.Password;
                
                MessageBox.Show("The user has been found successfully", "User Found");
            }

            else if (user != null && user.Statususer == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the user?", "The User is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Userx.Where(x => x.Codeuser == formuser.textBoxCodeUserx.Text).FirstOrDefault();
                    record.Statususer = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The user has been reactivated successfully", "Reactivated User");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Delete();
                }
            }
            else if (user==null)
            {
                formuser.textBoxCodeUserx.Enabled = true;
                MessageBox.Show("The user has not been found successfully", "User not Found");
            }
                
        }


        public void Clean()
        {
            formuser.textBoxCodeUserx.Enabled = true;
            formuser.textBoxCodeUserx.Text = "";
            formuser.textBoxPersonalNamex.Text = "";
            formuser.textBoxLastnamex.Text = "";
            formuser.textBoxUsernamex.Text = "";
            formuser.textBoxAdressx.Text = "";
            formuser.textBoxPasswordx.Text = "";
            formuser.radioButtonAdministratorx.Checked = false;
            formuser.radioButtonOperatorx.Checked = false;
        }

        public bool ValidateForm()
        {
            return (formuser.textBoxCodeUserx.TextLength != 0 &&
                formuser.textBoxPersonalNamex.TextLength != 0 &&
                formuser.textBoxLastnamex.TextLength != 0 &&
                formuser.textBoxUsernamex.TextLength != 0 &&
                formuser.textBoxAdressx.TextLength != 0 &&
                formuser.textBoxPasswordx.TextLength != 0 
                );
        }


        public void Modify()
        {
            textC12Context dbx = new textC12Context();
            var db = new textC12Context();
            string found = formuser.textBoxCodeUserx.Text;
            user = dbx.Userx.Find(found);
            string coderole;
           

            if (formuser.radioButtonAdministratorx.Checked)
            {
                coderole = "r01";
            }
            else
            {
                coderole = "r02";
            }

            if(ValidateForm() && user != null)
            {
                db.Userx.Update(new Userx()
                {

                    Codeuser = formuser.textBoxCodeUserx.Text,
                    Coderole = coderole,
                    Personalname = formuser.textBoxPersonalNamex.Text,
                    Lastname = formuser.textBoxLastnamex.Text,
                    Username = formuser.textBoxUsernamex.Text,
                    Adress = formuser.textBoxAdressx.Text,
                    Password = formuser.textBoxPasswordx.Text,
                    Statususer = "A",
                });
                db.SaveChanges();
                MessageBox.Show("The user have been successfully modified", "User Modified");
            }
            else if (!ValidateForm() && formuser.textBoxCodeUserx.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "User not Modified");
            }
            else if(user == null)
            {
                MessageBox.Show("The user has not been found successfully", "User not Found");
            }
            

        }
        public void Delete()
        {
            var db = new textC12Context();
            var record = db.Userx.Where(x => x.Codeuser == formuser.textBoxCodeUserx.Text).FirstOrDefault();
            record.Statususer = "I";
            db.Update(record);
            db.SaveChanges();
            MessageBox.Show("The user have been successfully delete", "User Delete");
            Clean();
        }


    }
}
