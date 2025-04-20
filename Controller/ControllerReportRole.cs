using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PredaconsAppointmentManagement.Models;

namespace PredaconsAppointmentManagement.View
{
    class ControllerReportRole
    {
        FormReportRoles formreport;
        List<Role> list;
        Role role;
        textC12Context db = new textC12Context();

        public ControllerReportRole(FormReportRoles form)
        {
            formreport = form;
        }

        public void listRole()
        {
            db = new textC12Context();
            list = db.Role.ToList();

        }



        public void loadData()
        {
            listRole();

            foreach (var rental in list)
            {
                role = db.Role.Find(rental.Coderole);
                
                formreport.dataGridViewReportRolesx.Rows.Add(

                    rental.Coderole,
                    rental.Descriptionrole
                    );
            }
        }



    }

}
