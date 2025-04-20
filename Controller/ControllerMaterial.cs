using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PredaconsAppointmentManagement.Models;
using PredaconsAppointmentManagement.View;
using System.Diagnostics.Eventing.Reader;

namespace PredaconsAppointmentManagement.Controller
{
    internal class ControllerMaterial
    {
        FormMaterials formMaterial;
        Materials materials;






        public ControllerMaterial(FormMaterials form)
        {
            formMaterial = form;
        }

        public void Include()
        {
            string found = formMaterial.textBoxCodeX.Text;
            textC12Context dbx = new textC12Context();
            materials = dbx.Materials.Find(found);

            double valueadded, saleprice;
            valueadded = double.Parse(formMaterial.textBoxPuccharsePriceX.Text) * 0.25;
            saleprice = double.Parse(formMaterial.textBoxPuccharsePriceX.Text) + valueadded;
            formMaterial.textBoxSalePriceX.Text = saleprice.ToString();

            if(ValidateForm() && materials == null)
            {
                using (var db = new textC12Context())
                {
                    Materials materials = new Materials()
                    {
                        Codematerials = formMaterial.textBoxCodeX.Text,
                        Description = formMaterial.textBoxDescriptionX.Text,
                        Puccharseprice = Double.Parse(formMaterial.textBoxPuccharsePriceX.Text),
                        Saleprice = saleprice,
                        Quantityavailable = Int32.Parse(formMaterial.textBoxQuantityAvailableX.Text),
                        Statusmaterials = "A"

                    };
                    MessageBox.Show("The material has been successfully included", " material Included");
                    db.Materials.Add(materials);
                    db.SaveChanges();

                }
            }
            else if (!ValidateForm() && formMaterial.textBoxCodeX.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Material not Included");
            }
            else if (materials != null)
            {
                MessageBox.Show("The material was not included because it already exists", "Material Not Included");
            }

        }

        public bool ValidateForm()
        {
            return (formMaterial.textBoxCodeX.TextLength != 0 &&
                formMaterial.textBoxDescriptionX.TextLength != 0 &&
                formMaterial.textBoxPuccharsePriceX.TextLength != 0 &&
                formMaterial.textBoxQuantityAvailableX.TextLength != 0);
        }


        public void Search()
        {
            textC12Context db = new textC12Context();
            string found = formMaterial.textBoxCodeX.Text;

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

                formMaterial.textBoxCodeX.Enabled = false;
                formMaterial.textBoxCodeX.Text = materials.Codematerials;
                formMaterial.textBoxDescriptionX.Text = materials.Description;
                formMaterial.textBoxPuccharsePriceX.Text = materials.Puccharseprice.ToString();
                formMaterial.textBoxSalePriceX.Text = materials.Saleprice.ToString();
                formMaterial.textBoxQuantityAvailableX.Text = materials.Quantityavailable.ToString();

                MessageBox.Show("The material has been found successfully", "Material Found");
            }

            else if (materials != null && materials.Statusmaterials == "I")
            {
                DialogResult dialogResult = MessageBox.Show("You want to reactivate the material?", "The Material is Inactive", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var record = db.Materials.Where(x => x.Codematerials == formMaterial.textBoxCodeX.Text).FirstOrDefault();
                    record.Statusmaterials = "A";
                    db.Update(record);
                    db.SaveChanges();
                    MessageBox.Show("The material has been reactivated successfully", "Reactivated Material");
                }
                else if (dialogResult == DialogResult.No)
                {
                    Delete();
                }
            }
            else if (materials == null)
            {
                formMaterial.textBoxCodeX.Enabled = true;
                MessageBox.Show("The material has not been found successfully", "Material not Found");

            }
           
        }


        public void Clean()
        {
            formMaterial.textBoxCodeX.Enabled = true;
            formMaterial.textBoxCodeX.Text = "";
            formMaterial.textBoxDescriptionX.Text = "";
            formMaterial.textBoxPuccharsePriceX.Text = "";
            formMaterial.textBoxSalePriceX.Text = "";
            formMaterial.textBoxQuantityAvailableX.Text = "";
        }



        public void Modify()
        {
            textC12Context dbx = new textC12Context();
            var db = new textC12Context();
            string found = formMaterial.textBoxCodeX.Text;
            materials = db.Materials.Find(found);


            if (ValidateForm() && materials != null)
            {
                double valueadded, saleprice;
                valueadded = double.Parse(formMaterial.textBoxPuccharsePriceX.Text) * 0.25;
                saleprice = double.Parse(formMaterial.textBoxPuccharsePriceX.Text) + valueadded;
                formMaterial.textBoxSalePriceX.Text = saleprice.ToString();

                materials.Description = formMaterial.textBoxDescriptionX.Text;
                materials.Puccharseprice = double.Parse(formMaterial.textBoxPuccharsePriceX.Text);
                materials.Saleprice = saleprice;
                materials.Quantityavailable = Int32.Parse(formMaterial.textBoxQuantityAvailableX.Text);
                db.Materials.Update(materials);
               
                db.SaveChanges();
                MessageBox.Show("The material have been successfully modified", "Material Update");
            }
            else if (!ValidateForm() && formMaterial.textBoxCodeX.TextLength != 0 || !ValidateForm())
            {
                MessageBox.Show("The form is not filled", "Material not Modified");
            }
            else if (materials == null)
            {
                MessageBox.Show("The material has not been found successfully", "Material not Found");
            }
               
           
        }



        public void Delete()
        {
            var db = new textC12Context();
            var record = db.Materials.Where(x => x.Codematerials == formMaterial.textBoxCodeX.Text).FirstOrDefault();
            record.Statusmaterials = "I";
            db.Update(record);
            db.SaveChanges();
            MessageBox.Show("The material has been removed", "Material Deleted");
            Clean();
        }


















    }
}
