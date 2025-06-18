using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Interfaces
{
    public interface IAppointmentService
    {
        List<Appointment> GetAll();
        Appointment GetById(int Id);

        List<Appointment> GetByPatientId(int PatientId);

        void Add(Appointment appointment);
        void Update (Appointment  appointment);

        void Delete(int id);
    }
}
