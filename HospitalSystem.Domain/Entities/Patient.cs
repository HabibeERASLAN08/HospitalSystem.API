using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Domain.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TCNo {  get; set; }
        public DateTime BirthDate { get; set; }

        public ICollection<Appointment> Appointments { get; set; }

        
    }
}
