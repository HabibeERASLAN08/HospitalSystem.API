using HospitalSystem.Application.Interfaces;
using HospitalSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }


        // GET: api/appointment
        [HttpGet]
        public IActionResult GetAll()
        {
            var appointments=_appointmentService.GetAll();
            return Ok(appointments);
        }


        // GET: api/appointment/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var appointment=_appointmentService.GetById(id);
            if (appointment == null)
                return NotFound();

            return Ok(appointment);

        }

        // GET: api/appointment/patient/3
        [HttpGet("patient/{patientId}")]
        public IActionResult GetByPatientId(int patientId)
        {
            var appointments=_appointmentService.GetByPatientId(patientId);
            return Ok(appointments);
        }


        // POST: api/appointment
        [HttpPost]
        public IActionResult Add([FromBody] Appointment appointment)
        {
            _appointmentService.Add(appointment);
            return Ok("Appointment created");
        }

        [HttpPut]
        public IActionResult Update([FromBody] Appointment appointment)
        {
            _appointmentService.Update(appointment);
            return Ok("Appointment updated");

        }

        // DELETE: api/appointment/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _appointmentService.Delete(id);
            return Ok("Appointment deleted");
        }
    }
}
