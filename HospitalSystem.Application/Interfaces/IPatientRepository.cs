using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Interfaces
{
    public interface IPatientRepository
    {
        List<Patient> GetAll();
        Patient GetById(int id);

        void Add(Patient patient);
        void Update(Patient patient);
        void Delete(Patient patient);
    }
}
