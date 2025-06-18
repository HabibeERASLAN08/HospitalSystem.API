using HospitalSystem.Application.Interfaces;
using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Infrastructure.Services
{
    public class PatientService : IPatientService
    {
        private readonly IPatientRepository _repository;

        public PatientService(IPatientRepository repository)
        {
            _repository = repository;
        }

        public void Add(Patient patient)
        {
            _repository.Add(patient);
        }

        public void Delete(Patient patient)
        {
            _repository.Delete(patient);
        }

        public List<Patient> GetAll()
        {
            return _repository.GetAll();
        }

        public Patient GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(Patient patient)
        {
            _repository.Delete(patient);
        }
    }
}
