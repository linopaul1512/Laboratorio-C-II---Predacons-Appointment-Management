using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PredaconsAppointmentManagement.View;
using PredaconsAppointmentManagement.Models;
using System.Data;

namespace PredaconsAppointmentManagement.Controller
{
    class ControllerReportAppointment
    {
        FormReportAppointment formreport;
        List<Appointment> list;
        Appointment appointment, FoundAppointment;
        MaterialsAppointment materialsAppointment;
        textC12Context db = new textC12Context();
        


        public ControllerReportAppointment(FormReportAppointment form)
        {
            formreport = form;
        }

        public void listAppointment()
        {
            db = new textC12Context();
            list = db.Appointment.ToList();
        }


        public void loadData()
        {
            listAppointment();

            foreach (var appointment in list)
            {
                FoundAppointment = db.Appointment.Find(appointment.Codeappointment);

                formreport.dataGridViewReportAppintmentx.Rows.Add(

                    appointment.Codeappointment,
                    appointment.Idclient,
                    appointment.Idworker,
                    appointment.Possibledate,
                    appointment.Instalationdate,
                    appointment.Statusappoinment
                    );
            }
        }


        public void clean()
        {
            formreport.dataGridViewReportAppintmentx.Rows.Clear();
        }

    }
}
