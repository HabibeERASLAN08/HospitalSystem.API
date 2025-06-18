using HospitalSystem.Application.Interfaces;
using HospitalSystem.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HospitalSystem.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : Controller
    {
        private readonly IPatientService _service;

        public PatientsController(IPatientService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var patients=_service.GetAll();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var patient=_service.GetById(id);
            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        [HttpPost]
        public IActionResult Add([FromBody] Patient patient)
        {
            _service.Add(patient);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] Patient patient)
        {
            _service.Update(patient);
            return Ok("Hasta Güncellendi");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existing=_service.GetById(id);
            if (existing == null)
                return NotFound();

            _service.Delete(existing);
            return Ok("Hasta Silindi");
        }
    }
}
