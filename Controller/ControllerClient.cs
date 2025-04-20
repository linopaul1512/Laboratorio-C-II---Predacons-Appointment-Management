using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PredaconsAppointmentManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PredaconsAppointmentManagement.Controller
{
    internal class ControllerClient
    {
        FormClient formclient;
        Client client;
      

        public ControllerClient(FormClient form)
        {
            formclient = form;
        }

        public void Include()
        {
            textC12Context dbx = new textC12Context();
            string found = formclient.textBoxIDx.Text;
            client = dbx.Client.Find(found);
 

            if (ValidateForm() && client== null)
            {
                using (var db = new textC12Context())
                {
                    Client client = new Client()
                    {
                        Idclient = formclient.textBoxIDx.Text,
                        Nameclient = formclient.textBoxNamex.Text,
                        Lastname = formclient.textBoxLastnamex.Text,
                        Adress = formclient.textBoxAdressx.Text,
                        Datebirth = formclient.dateTimePickerDatebirthx.Value,
                        Phonenumber = formclient.textBoxPhonenumberx.Text,
                        Statusclient = "A"
                    };
                    MessageBox.Show("The client has been successfully included", "Client Included");
                    db.Client.Add(client);
                    db.SaveChanges();

                }
            } 
            else if(!ValidateForm() && formclient.textBoxIDx.TextLength!=0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Client not Included");
            }
            else if (client!=null)
            {
                MessageBox.Show("The client was not included because it already exists", "Client Not Included");
            }
        }

        public bool ValidateForm()
        {
            return (formclient.textBoxIDx.TextLength != 0 &&
                formclient.textBoxNamex.TextLength != 0 &&
                formclient.textBoxLastnamex.TextLength != 0 &&
                formclient.textBoxPhonenumberx.TextLength != 0 &&
                formclient.textBoxAdressx.TextLength != 0);
        }

        public void SearchClient()
        {
            textC12Context db = new textC12Context();
            string found = formclient.textBoxIDx.Text;

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

                formclient.textBoxIDx.Enabled = false;
                formclient.textBoxNamex.Text = client.Nameclient;
                formclient.textBoxLastnamex.Text = client.Lastname;
                formclient.textBoxPhonenumberx.Text = client.Phonenumber;
                formclient.dateTimePickerDatebirthx.Value = client.Datebirth;
                formclient.textBoxAdressx.Text = client.Adress;

                MessageBox.Show("The client has been found successfully", "Client Found");
            }

            else if (client != null  && client.Statusclient == "I" )
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the client?", "The Client is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Client.Where(x => x.Idclient == formclient.textBoxIDx.Text).FirstOrDefault();
                    record.Statusclient = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The client has been reactivated successfully", "Reactivated Client");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Delete();
                }
            } 
            else if (client == null)
            {
                formclient.textBoxIDx.Enabled = true;
                MessageBox.Show("The client has not been found successfully", "Client not Found");
            }
        }


        public void Clean()
        {
            formclient.textBoxIDx.Enabled = false;
            formclient.textBoxIDx.Text = "";
            formclient.textBoxNamex.Text = "";
            formclient.textBoxLastnamex.Text = "";
            formclient.textBoxPhonenumberx.Text = "";
            formclient.dateTimePickerDatebirthx.Value = DateTime.Now;
            formclient.textBoxAdressx.Text = "";
        }



        public void Modify()
        {
            textC12Context dbx = new textC12Context();
            var db = new textC12Context();
            string found = formclient.textBoxIDx.Text;
            client = dbx.Client.Find(found);

            if (ValidateForm() && client != null)
            {
                db.Client.Update(new Client()
                {
                    Idclient = formclient.textBoxIDx.Text,
                    Nameclient = formclient.textBoxNamex.Text,
                    Lastname = formclient.textBoxLastnamex.Text,
                    Datebirth = formclient.dateTimePickerDatebirthx.Value,
                    Phonenumber = formclient.textBoxPhonenumberx.Text,
                    Adress = formclient.textBoxAdressx.Text,
                    Statusclient = "A"
                });
                db.SaveChanges();
                MessageBox.Show("The client have been successfully modified", "Client Update");
            }
            else if (!ValidateForm() && formclient.textBoxIDx.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Client not Modified");
            }
            else if (client == null)
            {
                MessageBox.Show("The client has not been found successfully", "Client not Found");
            }         

        }
        public void Delete()
        {
                var db = new textC12Context();
                var record = db.Client.Where(x => x.Idclient == formclient.textBoxIDx.Text).FirstOrDefault();
                record.Statusclient = "I";
                db.Update(record);
                db.SaveChanges();
                MessageBox.Show("The client have been successfully delete", "Client Delete");
                Clean();
        }



    }
}
