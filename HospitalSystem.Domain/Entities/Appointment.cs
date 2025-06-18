using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public string Description   { get; set; }
        public DateTime AppointmentDate { get; set; }



        //Foreign Key
        public int PatientId    { get; set; }
        public Patient Patient { get; set; }
    }
}
