using HospitalSystem.Application.Interfaces;
using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Infrastructure.Services
{
    public class AppointmentService : IAppointmentService
    {

        private readonly IAppointmentRepository _appointmentRepository;

        public AppointmentService(IAppointmentRepository appointmentRepository)
        {
            _appointmentRepository=appointmentRepository;
        }
        public void Add(Appointment appointment)
        {
            _appointmentRepository.Add(appointment);
        }

        public void Delete(int id)
        {
            _appointmentRepository.Delete(id);
        }

        public List<Appointment> GetAll()
        {
            return _appointmentRepository.GetAll();
        }

        public Appointment GetById(int Id)
        {
            return _appointmentRepository.GetById(Id);
        }

        public List<Appointment> GetByPatientId(int PatientId)
        {
            return _appointmentRepository.GetByPatientId(PatientId);
        }

        public void Update(Appointment appointment)
        {
            _appointmentRepository.Update(appointment);
        }
    }
}
