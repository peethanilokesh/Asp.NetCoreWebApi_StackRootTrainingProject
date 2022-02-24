using Hospital_Management_API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        IPatientRepository _patientRepository;
        public PatientController(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        [HttpGet]
        [Route("/api/patient")]
        public IActionResult GetPatient()
        {
            var allPatient = _patientRepository.GetAllPatient();
            return Ok(allPatient);
        }

        [HttpGet]
        [Route("/api/patient/{id}")]
        public IActionResult GetPatientById(int id)
        {
            var patient = _patientRepository.GetPatientById(id);
            if (patient == null)
            {
                return NotFound($"Patient with id = {id} not found");
            }
            return Ok(patient);
        }

        [HttpGet]
        [Route("/api/patient/{name}")]
        public IActionResult GetPatientByName(string name)
        {
            var patient = _patientRepository.GetPatientByName(name);
            if (patient == null)
            {
                return NotFound($"Patient with name = {name} not found");
            }
            return Ok(patient);
        }

        [HttpPost]
        []


    }
}
