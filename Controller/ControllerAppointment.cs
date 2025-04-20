using Microsoft.Data.SqlClient.Server;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Query;
using PredaconsAppointmentManagement.Models;
using PredaconsAppointmentManagement.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Interop;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;

namespace PredaconsAppointmentManagement.Controller
{
    internal class ControllerAppointment
    {

        Service service;
        Appointment appointment, foundAP;
        ServiceAppointment serviceAppointment;
        MaterialsAppointment materialsAppointment;
        FormAppointment formAppointment;
        textC12Context db = new textC12Context();
        Client client;
        Materials materials, foundMA;
        Worker worker;
        List<Materials> list;
        List<MaterialsAppointment> listAP;
        DataGridView b;


        public ControllerAppointment(FormAppointment form)
        {
            formAppointment = form;
        }


        public void SearchClient()
        {
            textC12Context db = new textC12Context();
            string found = formAppointment.textBoxIDClientx.Text;

            try
            {
                client = db.Client.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (client != null && client.Statusclient == "A")
            {

                //formclient.textBoxIDx.Enabled = false;
                formAppointment.textBoxIDClientx.Text = client.Idclient;

                MessageBox.Show("The client has been found successfully", "Client Found");
            }

            else if (client != null && client.Statusclient == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the client?", "The Client is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Client.Where(x => x.Idclient == formAppointment.textBoxIDClientx.Text).FirstOrDefault();
                    record.Statusclient = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The client has been reactivated successfully", "Reactivated Client");
                }
                else if (dialogResult == DialogResult.No)
                {
                    var record = db.Client.Where(x => x.Idclient == formAppointment.textBoxIDClientx.Text).FirstOrDefault();
                    record.Statusclient = "I";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The client have been successfully delete", "Client Delete");
                    Clean();
                }
            }
            else if (client == null)
            {
                formAppointment.textBoxIDClientx.Enabled = true;
                MessageBox.Show("The client has not been found successfully", "Client not Found");
            }
        }

        public void SearchMaterial()
        {
            textC12Context db = new textC12Context();
            string found = formAppointment.textBoxCodeMaterialx.Text;

            try
            {
                materials = db.Materials.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (materials != null && materials.Statusmaterials == "A")
            {

                //formclient.textBoxIDx.Enabled = false;
                formAppointment.textBoxCodeMaterialx.Text = materials.Codematerials;
                formAppointment.textBoxQuantityAvailablex.Text = materials.Quantityavailable.ToString();

                MessageBox.Show("The material has been found successfully", "Material Found");
            }

            else if (materials != null && materials.Statusmaterials == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the material?", "The Material is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Materials.Where(x => x.Codematerials == formAppointment.textBoxIDWorkerx.Text).FirstOrDefault();
                    record.Statusmaterials = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The material has been reactivated successfully", "Reactivated Material");
                }
                else if (dialogResult == DialogResult.No)
                {
                    var record = db.Materials.Where(x => x.Codematerials == formAppointment.textBoxCodeMaterialx.Text).FirstOrDefault();
                    record.Statusmaterials = "I";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The material has been removed", "Material Deleted");

                }
            }
            else if (materials == null)
            {
                MessageBox.Show("The material has not been found successfully", "Material not Found");
            }

        }



        public void SearchWorker()
        {
            textC12Context db = new textC12Context();
            string found = formAppointment.textBoxIDWorkerx.Text;



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

                formAppointment.textBoxIDWorkerx.Text = worker.Idworker;

                MessageBox.Show("The worker has been found successfully", "Worker Found");
            }
            else if (worker != null && worker.Statusworker == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the worker?", "The Worker is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Worker.Where(x => x.Idworker == formAppointment.textBoxIDWorkerx.Text).FirstOrDefault();
                    record.Statusworker = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The worker has been reactivated successfully", "Reactivated Worker");
                }
                else if (dialogResult == DialogResult.No)
                {
                    var record = db.Worker.Where(x => x.Idworker == formAppointment.textBoxIDWorkerx.Text).FirstOrDefault();
                    record.Statusworker = "I";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The worker have been successfully delete", "Worker Delete");
                    Clean();
                }
            }
            else if (worker == null)
            {
                MessageBox.Show("The worker has not been found successfully", "Worker not Found");
            }

        }


        public void SearchService()
        {
            textC12Context db = new textC12Context();
            string found = formAppointment.textBoxCodeServicex.Text;

            try
            {
                service = db.Service.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (service != null && service.Statuservice == "A")
            {

                //formclient.textBoxIDx.Enabled = false;

                formAppointment.textBoxCodeServicex.Text = service.Codeservice;

                MessageBox.Show("The service has been found successfully", "Service Found");
            }

            else if (service != null && service.Statuservice == "I" || appointment.Statusappoinment == "P")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the service?", "The Service is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Service.Where(x => x.Codeservice == formAppointment.textBoxCodeServicex.Text).FirstOrDefault();
                    record.Statuservice = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The service has been reactivated successfully", "Reactivated Service");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Cancel();
                }
            }
            else if (service == null)
            {
                MessageBox.Show("The service has not been found successfully", "Service not Found");
            }

        }

        public void SearchAppointment()
        {
            textC12Context db = new textC12Context();
            string namematerial = string.Empty;
            string found = formAppointment.textBoxCodeAppointmentx.Text;
            var foundmaterials = db.MaterialsAppointment.Where(b => b.Codeappointment == formAppointment.textBoxCodeAppointmentx.Text).ToList();

            try
            {
                appointment = db.Appointment.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }


            if (appointment != null && appointment.Statusappoinment == "I")
            {
                //formclient.textBoxIDx.Enabled = false;
                formAppointment.textBoxCodeAppointmentx.Text = appointment.Codeappointment;
                formAppointment.textBoxIDClientx.Text = appointment.Idclient;
                formAppointment.textBoxIDWorkerx.Text = appointment.Idworker;
                formAppointment.dateTimePickerPossibledatex.Value = appointment.Possibledate;
                formAppointment.dateTimePickerPossibledatex.Value = appointment.Instalationdate;

                var foundservice = db.ServiceAppointment.Where(x => x.Codeappointment == formAppointment.textBoxCodeAppointmentx.Text).Single();
                formAppointment.textBoxCodeServicex.Text = foundservice.Codeservice;

              


                listMaterials();
                int i = 0;
                foreach (var materials in foundmaterials) 
                {
                    

                    foreach (var m in list)
                    {
                        if (m.Codematerials == foundmaterials[i].Codematerials)
                        {
                            namematerial = m.Description; i++;
                            break;
                        }
                    }
                    formAppointment.dataGridViewReportMaterialx.Rows.Add(materials.Codematerials,
                            namematerial,
                            materials.Quantityma);

                }

               
                MessageBox.Show("The appointment has been found successfully", "Appointment Found");
            }
            else if (appointment != null && appointment.Statusappoinment == "P")
            {
                formAppointment.textBoxCodeAppointmentx.Text = appointment.Codeappointment;
                formAppointment.textBoxIDClientx.Text = appointment.Idclient;
                formAppointment.textBoxIDWorkerx.Text = appointment.Idworker;
                formAppointment.dateTimePickerPossibledatex.Value = appointment.Possibledate;
                formAppointment.dateTimePickerPossibledatex.Value = appointment.Instalationdate;
                MessageBox.Show("The appointment has been found successfully", "Appointment Found");
                blocktextBoxes();
            }
            else if (appointment == null)
            {
                MessageBox.Show("The appointment has not been found successfully", "Appointment not Found");
            }
        }


        public void blocktextBoxes()
        {
            formAppointment.textBoxCodeAppointmentx.Enabled = false;
           // formAppointment.textBoxCodeServicex.Enabled = false;
            //formAppointment.textBoxCodeMaterialx.Enabled = false;
            //formAppointment.textBoxQuantyMaterialx.Enabled = false;
            formAppointment.textBoxIDClientx.Enabled = false;
            formAppointment.textBoxIDWorkerx.Enabled = false;
            formAppointment.dateTimePickerInstalationdatex.Enabled = false;
            formAppointment.dateTimePickerPossibledatex.Enabled = false;

        }


            public void Clean()
        {
            formAppointment.textBoxCodeAppointmentx.Enabled = true;
            formAppointment.textBoxCodeServicex.Enabled = true;
            formAppointment.textBoxIDClientx.Enabled = true;
            formAppointment.textBoxIDWorkerx.Enabled = true;
            formAppointment.dateTimePickerInstalationdatex.Enabled = true;
            formAppointment.dateTimePickerPossibledatex.Enabled = true;


            formAppointment.textBoxCodeAppointmentx.Text = "";
            formAppointment.textBoxCodeMaterialx.Text = "";
            formAppointment.textBoxCodeServicex.Text = "";
            formAppointment.textBoxIDClientx.Text = "";
            formAppointment.textBoxIDWorkerx.Text = "";
            formAppointment.textBoxQuantyMaterialx.Text = "";
            formAppointment.textBoxQuantityAvailablex.Text = "";
            formAppointment.dateTimePickerInstalationdatex.Value = DateTime.Now;
            formAppointment.dateTimePickerPossibledatex.Value = DateTime.Now;
            formAppointment.dataGridViewReportMaterialx.Rows.Clear();
        }


        public void Cancel()
        {
            var db = new textC12Context();
            var record = db.Appointment.Where(x => x.Codeappointment == formAppointment.textBoxCodeAppointmentx.Text).FirstOrDefault();
            record.Statusappoinment = "C";
            db.Update(record);
            db.SaveChanges();
            MessageBox.Show("the appointment has been successfully canceled", "Client Cancel");
            Clean();
        }



        public void Modify()
        {
            var db = new textC12Context();
            textC12Context dbx = new textC12Context();
            string found = formAppointment.textBoxCodeAppointmentx.Text;
            appointment = dbx.Appointment.Find(found);

            try
            {
                appointment = db.Appointment.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (ValidateForm()  && appointment != null && appointment.Statusappoinment == "P")
            {
                db.Appointment.Update(new Appointment()
                {
                    Codeappointment = RandomDigits(9),
                    Idclient = formAppointment.textBoxIDClientx.Text,
                    Idworker = formAppointment.textBoxIDWorkerx.Text,
                    Instalationdate = formAppointment.dateTimePickerPossibledatex.Value,
                    Possibledate = formAppointment.dateTimePickerInstalationdatex.Value,
                    Statusappoinment = "P"
                });
                db.SaveChanges();
                MessageBox.Show("The appointment have been successfully modified", "Appointment Update");

            }
            else if (!ValidateForm() && formAppointment.textBoxCodeAppointmentx.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Appointment not Modified");
            }
            else if (appointment != null && appointment.Statusappoinment == "I")
            {
                MessageBox.Show("Cannot modify because the appointment was already installed", "Appointment not Update");
            }
            else if (appointment == null)
            {
                MessageBox.Show("The appointment has not been found successfully", "Appointment not Found");
            }

        }

        public bool ValidateForm()
        {
            return (
                formAppointment.textBoxIDClientx.TextLength != 0 &&
                formAppointment.textBoxIDWorkerx.TextLength != 0 
                );
        }

        public bool ValidateFormInstall()
        {
            return (formAppointment.textBoxCodeAppointmentx.TextLength != 0 &&
                formAppointment.textBoxCodeMaterialx.TextLength != 0 &&
                formAppointment.textBoxCodeServicex.TextLength != 0 &&
                formAppointment.textBoxIDClientx.TextLength != 0 &&
                formAppointment.textBoxIDWorkerx.TextLength != 0 &&
                formAppointment.textBoxQuantyMaterialx.TextLength != 0 
                );
        }

        public void listMaterials()
        {
            db = new textC12Context();
            list = db.Materials.ToList();

        }

        public void listMaterialsappoitment()
        {
            db = new textC12Context();
            listAP = db.MaterialsAppointment.ToList();

        }


        public void AddinAccount()
        {
            int quantity = Int32.Parse(formAppointment.textBoxQuantyMaterialx.Text);
            int quantityavailable = Int32.Parse(formAppointment.textBoxQuantityAvailablex.Text);
            textC12Context dbx = new textC12Context();
            string found = formAppointment.textBoxCodeMaterialx.Text;
            materials = dbx.Materials.Find(found);

           if (quantityavailable> quantity)
           {
                listMaterials();


                formAppointment.dataGridViewReportMaterialx.Rows.Add(
                    materials.Codematerials,
                    materials.Description,
                    quantity
                    );

                this.formAppointment.dataGridViewReportMaterialx.Sort(this.formAppointment.dataGridViewReportMaterialx.Columns["ColumnCodeMaterialAPP"], ListSortDirection.Ascending);

            }
            else if (quantityavailable < quantity)
            {
                MessageBox.Show("The installation has not been done successfully", "No materials available");
            }


        }

      
     
        

        public void Include()
        {
            textC12Context dbx = new textC12Context();
            string found = formAppointment.textBoxCodeAppointmentx.Text;
            appointment = dbx.Appointment.Find(found);

            

            if (ValidateForm() && appointment==null)
            {

                using (var db = new textC12Context())
                {
                    Appointment appointment = new Appointment()
                    {
                        Codeappointment = formAppointment.textBoxCodeAppointmentx.Text = RandomDigits(9),
                        Idclient = formAppointment.textBoxIDClientx.Text,
                        Idworker = formAppointment.textBoxIDWorkerx.Text,
                        Instalationdate = formAppointment.dateTimePickerPossibledatex.Value,
                        Possibledate = formAppointment.dateTimePickerInstalationdatex.Value,
                        Statusappoinment = "P"
                    };
                    MessageBox.Show("The apointment has been successfully included", "Appointment Included");
                    db.Appointment.Add(appointment);
                    db.SaveChanges();
                }
                blocktextBoxes();



            }
            else if (!ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Client not Included");
            }
            else if(ValidateForm() && appointment==null && appointment.Statusappoinment=="I")
            {
                MessageBox.Show("The citation cannot be included because it is already installed", "Error");
            }
            else if (ValidateForm() && appointment == null && appointment.Statusappoinment == "C")
            {
                MessageBox.Show("The citation cannot be included because it is already canceled", "Error");
            }
            else if (appointment!=null)
            {
                MessageBox.Show("The appointment was not included because it already exists", "Appointment Not Included");
            }


        }

        public void Install()
        {
            MaterialsAppointment materialsAppointment;
            //int quantity = Int32.Parse(String.Format("Row: {2}, Column: {0}", formAppointment.dataGridViewReportMaterialx.CurrentCell.RowIndex));
            int quantityavailable = Int32.Parse(formAppointment.textBoxQuantityAvailablex.Text);
            textC12Context db = new textC12Context();
            string found = formAppointment.textBoxCodeAppointmentx.Text;
            
            b = formAppointment.dataGridViewReportMaterialx;
            
            int quantity =0;
            string codmat = string.Empty;



          

            try
            {
                appointment = db.Appointment.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (ValidateFormInstall() && appointment != null && appointment.Statusappoinment == "P")   
            {
                var record = db.Appointment.Where(x => x.Codeappointment == formAppointment.textBoxCodeAppointmentx.Text).First();
                record.Statusappoinment = "I";
                db.Update(record);
                db.SaveChanges();


                

                if (quantityavailable > quantity)
                {
                    
                    foreach (DataGridViewRow row in b.Rows)
                    {


                        quantity = Int32.Parse(row.Cells[2].Value.ToString());
                        codmat = row.Cells[0].Value.ToString();

                        using (var dbx = new textC12Context())
                        {

                            materialsAppointment = new MaterialsAppointment()
                            {
                                CodeMa = RandomDigits(9),
                                Codematerials = row.Cells[0].Value.ToString(),
                                Codeappointment = formAppointment.textBoxCodeAppointmentx.Text,
                                Quantityma = Int32.Parse(row.Cells[2].Value.ToString())
                            };


                        }
                        //MessageBox.Show("The material has been successfully included", " material Included");
                        db.MaterialsAppointment.Add(materialsAppointment);
                        db.SaveChanges();

                        materials = db.Materials.Find(materialsAppointment.Codematerials);
                        int result = materials.Quantityavailable - quantity;

                        foreach (var materials in list)
                        {
                            if (materials.Codematerials == codmat)
                            {
                                var record2 = db.Materials.Where(x => x.Codematerials == codmat).FirstOrDefault();
                                record2.Quantityavailable = result;
                                db.Update(record2); db.SaveChanges();
                            }


                        }


                    }



                        using (var db2 = new textC12Context())
                        {
                            ServiceAppointment serviceAppointment = new ServiceAppointment()
                            {
                                CodeSa = RandomDigits(9),
                                Codeservice = formAppointment.textBoxCodeServicex.Text,
                                Codeappointment = formAppointment.textBoxCodeAppointmentx.Text,

                            };
                            //MessageBox.Show("The service has been successfully included", "Service Included");
                            db.ServiceAppointment.Add(serviceAppointment);
                            db.SaveChanges();

                        }
                        MessageBox.Show("The installation has been done successfully", "Unsuccessful Installation");


                }

            }
            else if (!ValidateForm() && formAppointment.textBoxCodeAppointmentx.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Appintment not Included");
            }
            else if (appointment != null && appointment.Statusappoinment == "I")
            {
                MessageBox.Show("The task could not be executed because the appointment is installed", "Error");
            }
            else if (appointment != null && appointment.Statusappoinment == "C")
            {
                MessageBox.Show("Could not execute the task because the appointment is canceled", "Error");
            }
            else if (appointment == null)
            {
                MessageBox.Show("The appointment has not been found successfully", "Appointment not Found");
            }




            

        }








        public string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;

           
        }


    }
}
