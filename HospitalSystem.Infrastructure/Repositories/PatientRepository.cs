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
    public class PatientRepository : IPatientRepository
    {
        private readonly ApplicationDbContext _context;
        public PatientRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(Patient patient)
        {
            _context.Patients.Add(patient);
            _context.SaveChanges();
        }

        public void Delete(Patient patient)
        {
            _context.Patients.Remove(patient);
            _context.SaveChanges();
        }

        public List<Patient> GetAll()
        {
            return _context.Patients.ToList();
        }

        public Patient GetById(int id)
        {
            return _context.Patients.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Patient patient)
        {
            _context.Patients.Update(patient);
            _context.SaveChanges();
        }
    }
}
