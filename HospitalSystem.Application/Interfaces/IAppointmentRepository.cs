using HospitalSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalSystem.Application.Interfaces
{
    public interface IAppointmentRepository
    {

        List<Appointment> GetAll();
        Appointment GetById(int id);
        List<Appointment> GetByPatientId(int patientId);
        void Add(Appointment appointment);

        void Update (Appointment appointment);
        void Delete(int id);

















        //Task<List<Appointment>> GetAllAsync();
        //Task<Appointment> GetByIdAsync(int id);

        //Task<List<Appointment>> GetByPatientIdAsync(int patientId);

        //Task AddAsync(Appointment appointment);

        //Task DeleteAsync(int Id);

    }
}
