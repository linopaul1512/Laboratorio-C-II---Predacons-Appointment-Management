using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PredaconsAppointmentManagement.Models;
using PredaconsAppointmentManagement.View;
using System.Windows.Forms;

namespace PredaconsAppointmentManagement.Controller
{
    internal class ControllerWorker
    {
        FormWorker formworker;
        Worker worker;


        public ControllerWorker(FormWorker form)
        {
            formworker = form;
        }

        public void Include()
        {
            string sex;
            textC12Context dbx = new textC12Context();
            string found = formworker.textBoxIDx.Text;
            worker = dbx.Worker.Find(found);


            if( ValidateForm() && worker == null)
            {
                using (var db = new textC12Context())
                {
                    if (formworker.radioButtonMalex.Checked)
                    {
                        sex = "M";
                    }
                    else
                    {
                        sex = "F";
                    }

                    Worker worker = new Worker()
                    {
                        Idworker = formworker.textBoxIDx.Text,
                        Nameworker = formworker.textBoxNamex.Text,
                        Lastname = formworker.textBoxLastnamex.Text,
                        Phonenumber = formworker.textBoxPhonenumberx.Text,
                        Datebirth = formworker.dateTimePickerDatebirthx.Value,
                        Adress = formworker.textBoxAdressx.Text,
                        Sex = sex,
                        Statusworker = "A"

                    };
                    MessageBox.Show("The worker has been found successfully", "Worker Included");
                    db.Worker.Add(worker);
                    db.SaveChanges();
                }            

            }
            else if (!ValidateForm() && formworker.textBoxIDx.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Worker not Included");
            }
            else if (worker != null)
            {
                MessageBox.Show("The worker was not included because it already exists", "Worker Not Included");
            }


        }
       

        public void Search()
        {
            textC12Context db = new textC12Context();
            string found = formworker.textBoxIDx.Text;


            try
            {
                worker = db.Worker.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (worker != null && worker.Statusworker == "A")
            {
                formworker.textBoxIDx.Enabled = false;
                formworker.textBoxNamex.Text = worker.Nameworker;
                formworker.textBoxLastnamex.Text = worker.Lastname;
                formworker.textBoxPhonenumberx.Text = worker.Phonenumber;
                formworker.dateTimePickerDatebirthx.Value = worker.Datebirth;
                formworker.textBoxAdressx.Text = worker.Adress;
                if (worker.Sex == "M") 
                    formworker.radioButtonMalex.Checked = true;
                else
                    formworker.radioButtonFemalex.Checked = true;

                MessageBox.Show("The worker has been found successfully", "Worker Found");
            }
            else if(worker != null && worker.Statusworker == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the worker?", "The Worker is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Worker.Where(x => x.Idworker == formworker.textBoxIDx.Text).FirstOrDefault();
                    record.Statusworker = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The worker has been reactivated successfully", "Reactivated Worker");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Delete();
                }
            }
            else if(worker== null)
            {
                formworker.textBoxIDx.Enabled = true;
                MessageBox.Show("The worker has not been found successfully", "Worker not Found");
            }
                
            

        }

        public void Clean()
        {
            formworker.textBoxIDx.Enabled = true;
            formworker.textBoxIDx.Text = "";
            formworker.textBoxNamex.Text = "";
            formworker.textBoxLastnamex.Text = "";
            formworker.textBoxPhonenumberx.Text = "";
            formworker.dateTimePickerDatebirthx.Value = DateTime.Now;
            formworker.textBoxAdressx.Text = "";
            formworker.radioButtonFemalex.Checked = false;
            formworker.radioButtonMalex.Checked = false;
        }

        public bool ValidateForm()
        {
            return (formworker.textBoxIDx.TextLength !=0  &&
            formworker.textBoxNamex.TextLength  !=0  &&
            formworker.textBoxLastnamex.TextLength !=0  &&
            formworker.textBoxPhonenumberx.TextLength !=0  &&
            formworker.textBoxAdressx.TextLength !=0 
            );
        }


        public void Modify()
        {
            textC12Context dbx = new textC12Context();
            string sex;
            var db = new textC12Context();
            string found = formworker.textBoxIDx.Text;
            worker = dbx.Worker.Find(found);

      

            if (formworker.radioButtonMalex.Checked)
            {
                sex = "M";
            }
            else
            {
                sex = "F";
            }


            if(ValidateForm() && worker!= null)
            {
                db.Worker.Update(new Worker()
                {
                    Idworker = formworker.textBoxIDx.Text,
                    Nameworker = formworker.textBoxNamex.Text,
                    Lastname = formworker.textBoxLastnamex.Text,
                    Phonenumber = formworker.textBoxPhonenumberx.Text,
                    Datebirth = formworker.dateTimePickerDatebirthx.Value,
                    Adress = formworker.textBoxAdressx.Text,
                    Sex = sex,
                    Statusworker = "A"
                });
                db.SaveChanges();
                MessageBox.Show("The worker have been successfully modified", "Worker Modified");
            }
            else if (!ValidateForm() && formworker.textBoxIDx.TextLength !=0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Worker not Modified");
            }
            else if (worker == null)
            {
                MessageBox.Show("The worker has not been found successfully", "Worker not found");
            }
            

        }

        public void Delete()
        {
            var db = new textC12Context();
            var record = db.Worker.Where(x => x.Idworker == formworker.textBoxIDx.Text).FirstOrDefault();
            record.Statusworker = "I";
            db.Update(record);
            db.SaveChanges();
            MessageBox.Show("The worker have been successfully delete", "Worker Delete");
            Clean();
        }



    }
}
