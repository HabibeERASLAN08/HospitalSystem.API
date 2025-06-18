using HospitalSystem.Application.Interfaces;
using HospitalSystem.Domain.Entities;
using HospitalSystem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Infrastructure.Repositories
{
    public class AppointmentRepository:IAppointmentRepository
    {
        private readonly ApplicationDbContext _context;

        public AppointmentRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Add(Appointment appointment)
        {
            _context.Appointments.Add(appointment);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var appointment = _context.Appointments.FirstOrDefault(x => x.Id == id);
            if (appointment != null)
            {
                _context.Appointments.Remove(appointment);
                _context.SaveChanges();
            }
        }

        public List<Appointment> GetAll()
        {
            return _context.Appointments.ToList();
        }

        public Appointment GetById(int id)
        {
            return _context.Appointments.FirstOrDefault(a => a.Id == id);
        }

        public List<Appointment> GetByPatientId(int patientId)
        {
            return _context.Appointments.Where(a=>a.PatientId == patientId).ToList();
        }

        public void Update(Appointment appointment)
        {
            _context.Appointments.Update(appointment);
            _context.SaveChanges();
        }
    }
}
