using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PredaconsAppointmentManagement.Models;
using PredaconsAppointmentManagement.View;

namespace PredaconsAppointmentManagement.Controller
{
    internal class ControllerService
    {
        FormService formservice;
        Service service;


        public ControllerService(FormService form)
        {
            formservice = form;
        }

        public void Include()
        {
            textC12Context dbx = new textC12Context();
            string found = formservice.textBoxCodex.Text;
            service = dbx.Service.Find(found);

            if(ValidateForm() && service == null )
            {
                using (var db = new textC12Context())
                {
                    Service service = new Service()
                    {
                        Codeservice = formservice.textBoxCodex.Text,
                        Descriptionservice = formservice.textBoxDescriptionx.Text,
                        Price = Double.Parse(formservice.textBoxSalePricex.Text),
                        Statuservice = "A"
                    };
                    MessageBox.Show("The service has been successfully included", "Service Included");
                    db.Service.Add(service);
                    db.SaveChanges();
                }
            }
            else if(!ValidateForm() && service==null )
            {
                MessageBox.Show("The form is not filled", "Service not Included");

            }
            else if (!ValidateForm() && formservice.textBoxCodex.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Service not Included");
            }
            else if (service != null)
            {
                MessageBox.Show("The service was not included because it already exists", "Service Not Included");
            }


        }


        public void Search()
        {
            textC12Context db = new textC12Context();
            string found = formservice.textBoxCodex.Text;

            try
            {
                service = db.Service.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (service!= null && service.Statuservice == "A")
            {

                formservice.textBoxCodex.Enabled = false;
                formservice.textBoxDescriptionx.Text = service.Descriptionservice;
                formservice.textBoxSalePricex.Text = service.Price.ToString();
                MessageBox.Show("The service has been found successfully", "Service Found");
            }

            else if (service!= null && service.Statuservice == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the service?", "The Service is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Service.Where(x => x.Codeservice == formservice.textBoxCodex.Text).FirstOrDefault();
                    record.Statuservice = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The service has been reactivated successfully", "Reactivated Service");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Delete();
                }
            }
            else if (service == null)
            {
                formservice.textBoxCodex.Enabled = true;
                MessageBox.Show("The service has not been found successfully", "Service not Found");
            }
            


        }

       public bool ValidateForm()
        {
            return (formservice.textBoxCodex.TextLength != 0 &&
                formservice.textBoxDescriptionx.TextLength != 0 &&
                formservice.textBoxSalePricex.TextLength != 0);
        }
       

              
        public void Clean()
        {
            formservice.textBoxCodex.Enabled = true;
            formservice.textBoxCodex.Text = "";
            formservice.textBoxDescriptionx.Text = "";
            formservice.textBoxSalePricex.Text = "";
     
        }



        public void Modify()
        {

            textC12Context dbx = new textC12Context();
            var db = new textC12Context();
            string found = formservice.textBoxCodex.Text;
            service = dbx.Service.Find(found);
            

            if(ValidateForm() && service != null)
            {
                db.Service.Update(new Service()
                {
                    Codeservice = formservice.textBoxCodex.Text,
                    Descriptionservice = formservice.textBoxDescriptionx.Text,
                    Price = Double.Parse(formservice.textBoxSalePricex.Text),
                    Statuservice = "A"

                });
                db.SaveChanges();
                MessageBox.Show("The service have been successfully modified", "Service Update");
            }
            else if (!ValidateForm() && formservice.textBoxCodex.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Service not Modified");
            }
            else if (service == null)
            {
                MessageBox.Show("The service has not been found successfully", "Service not Found");
            }


        }

        public void Delete()
        {
            var db = new textC12Context();
            var record = db.Service.Where(x => x.Codeservice == formservice.textBoxCodex.Text).FirstOrDefault();
            record.Statuservice = "I";
            db.Update(record);
            db.SaveChanges();
            MessageBox.Show("The service have been successfully delete", "Service Deleted");
            Clean();
            
        }


    }
}
