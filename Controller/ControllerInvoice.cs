using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using PredaconsAppointmentManagement.Models;
using PredaconsAppointmentManagement.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PredaconsAppointmentManagement.Controller
{
    internal class ControllerInvoice
    {
        FormInvoice formInvoice;
        Invoice invoice;
        textC12Context db = new textC12Context();
        List<Materials> list;

        ServiceAppointment serviceAppointment;
        MaterialsAppointment materialsAppointment;
        Materials materials;
        Appointment appointment;

        double acumpricematerial;
        double acumtotals;
        double IVA;
        double baseamount;
        double total;
        int countquantitymaterial;


        public ControllerInvoice(FormInvoice form)
        {
            formInvoice = form;
        }

        public void listMaterials()
        {
            db = new textC12Context();
            list = db.Materials.ToList();

        }
        public void Include()
        {
            string found = formInvoice.textBoxCodeInvoicex.Text;
            textC12Context dbx = new textC12Context();
            invoice = dbx.Invoice.Find(found);

            materials = dbx.Materials.Find(found);
            //string codmaterial = string.Empty;


            if (invoice == null)
            {
                using (var db = new textC12Context())
                {
                    //buscar codigo
                    var foundservice = db.ServiceAppointment.Where(x => x.Codeappointment == formInvoice.textBoxCodeAppointmentx.Text).FirstOrDefault();
                    string codservice = foundservice.Codeservice;

                    //buscar price
                    var foundpriceservice = db.Service.Find(codservice);
                    double priceservice = foundpriceservice.Price;

                    //buscar material
                    var foundmaterial = db.MaterialsAppointment.Where(x => x.Codeappointment == formInvoice.textBoxCodeAppointmentx.Text).ToList();
                    int size = foundmaterial.Count;


                    

                    int i = 0;
                    listMaterials();
                    foreach (var materials in list)
                    {
                        if (i < size)
                        {
                            //if (materials.Codematerials == foundmaterial[i].Codematerials)
                            if (materials.Codematerials == foundmaterial[i].Codematerials)
                            {
                                //buscar precio material
                                var foundpricematerial = db.Materials.Find(foundmaterial[i].Codematerials);
                                double pricematerial = foundpricematerial.Saleprice;

                                //buscar cantidad de mateiales
                                var foundquantity = db.MaterialsAppointment.Where(x => x.Codeappointment == formInvoice.textBoxCodeAppointmentx.Text  && x.Codematerials == foundmaterial[i].Codematerials).FirstOrDefault();
                                int quantity = foundquantity.Quantityma;


                               
                                double baseamount = pricematerial * quantity;
                                acumtotals = acumtotals + baseamount;                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
                                IVA = acumtotals * 0.16;
                                total = IVA + acumtotals + priceservice;
                                formInvoice.textBoxIVAx.Text = IVA.ToString();
                                formInvoice.textBoxBaseAmountx.Text = acumtotals.ToString();
                                formInvoice.textBoxSalePricex.Text = total.ToString();
                                i++;
                            }
                           
                        }

                        
                    }
               
             
                    Invoice invoice = new Invoice()
                    {
                            Codeinvoice = formInvoice.textBoxCodeInvoicex.Text = RandomDigits(9),
                            Codeappointment = formInvoice.textBoxCodeAppointmentx.Text,
                            Dateinvoice = formInvoice.dateTimePickerInvoiceDatex.Value,
                            Iva = IVA,
                            Saleprice = total,
                            Statusinvoice = "A"
                    };
                        MessageBox.Show("The invoice has been successfully included", "Invoice Included");
                        db.Invoice.Add(invoice);
                        db.SaveChanges();

                        formInvoice.textBoxCodeInvoicex.Text = invoice.Codeinvoice;
                }



            }

            else if (invoice != null)
            {
                MessageBox.Show("The invoice was not included because it already exists", "Invoice Not Included");
            }
        }

        public bool ValidateForm()
        {
            return (
                formInvoice.textBoxCodeInvoicex.TextLength != 0 &&
                formInvoice.textBoxCodeAppointmentx.TextLength != 0
           );
        }

       

        public string RandomDigits(int length)
        {
            var random = new Random();
            string s = string.Empty;
            for (int i = 0; i < length; i++)
                s = String.Concat(s, random.Next(10).ToString());
            return s;
        }

        public void SearchInvoice()
        {
            textC12Context db = new textC12Context();
            string found = formInvoice.textBoxCodeInvoicex.Text;

            try
            {
                invoice = db.Invoice.Find(found);
            }
            catch (System.Data.SqlClient.SqlException e)
            {
                MessageBox.Show("Exception found!!! " + e, "Exception found");
            }

            if (invoice != null && invoice.Statusinvoice == "A")
            {

                //formclient.textBoxIDx.Enabled = false;
                formInvoice.textBoxCodeInvoicex.Text = invoice.Codeinvoice;
                formInvoice.textBoxCodeAppointmentx.Text = invoice.Codeappointment;
                formInvoice.textBoxCodeInvoicex.Text = invoice.Codeinvoice;
                formInvoice.dateTimePickerInvoiceDatex.Value = invoice.Dateinvoice;
                formInvoice.textBoxIVAx.Text = invoice.Iva.ToString();
                formInvoice.textBoxSalePricex.Text = invoice.Saleprice.ToString();
                MessageBox.Show("The invoice has been found successfully", "Invoice Found");
            }

            else if (invoice != null && invoice.Statusinvoice == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the invoice?", "The Invoice is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Invoice.Where(x => x.Codeinvoice == formInvoice.textBoxCodeAppointmentx.Text).FirstOrDefault();
                    record.Statusinvoice = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The invoice has been reactivated successfully", "Reactivated Invoice");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Delete();
                }
            }
            else if (invoice == null)
            {
                MessageBox.Show("The invoice has not been found successfully", "Invoice not Found");
            }

        }

        public void Delete()
        {
            var db = new textC12Context();
            var record = db.Invoice.Where(x => x.Codeinvoice == formInvoice.textBoxCodeInvoicex.Text).FirstOrDefault();
            record.Statusinvoice = "I";
            db.Update(record);
            db.SaveChanges();
            MessageBox.Show("The invoice have been successfully delete", "Invoice Delete");
            Clean();
        }

        public void Clean()
        {

            formInvoice.textBoxCodeInvoicex.Text = "";
            formInvoice.textBoxCodeAppointmentx.Text = "";
            formInvoice.textBoxIVAx.Text = "";
            formInvoice.textBoxSalePricex.Text = "";
            formInvoice.dateTimePickerInvoiceDatex.Value = DateTime.Now;

        }



        public void SearchAppointment()
        {
            textC12Context db = new textC12Context();
            string found = formInvoice.textBoxCodeAppointmentx.Text;

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
                formInvoice.textBoxCodeAppointmentx.Text = appointment.Codeappointment;
                MessageBox.Show("The invoice has been found successfully", "Invoice Found");
            }
            else if (appointment != null && appointment.Statusappoinment == "C")
            {
                MessageBox.Show("Could not execute the task because the appointment is canceled", "Error");
            }
            else if (appointment != null && appointment.Statusappoinment == "P")
            {
                MessageBox.Show("The task could not be executed because the appointment is pending", "Error");
            }
            else if (appointment == null)
            {
                MessageBox.Show("The appointment has not been found successfully", "Appointment not Found");
            }


        }



    }




}
