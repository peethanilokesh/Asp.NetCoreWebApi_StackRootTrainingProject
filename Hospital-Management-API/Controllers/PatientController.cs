using Hospital_Management_API.Model;
using Hospital_Management_API.Repository;
using Hospital_Management_API.ViewModels;
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
        [Route("/api/patient")]
        public IActionResult AddPatient([FromBody] AddPatientViewModel addPatientViewModel)
        {
            Patient patient = new Patient
            {
                PatientName = addPatientViewModel.PatientName,
                PatientGender = addPatientViewModel.PatientGender,
                PatientAge = addPatientViewModel.PatientAge,
                Department = addPatientViewModel.Department,
                DoctorName = addPatientViewModel.DoctorName,
                DoctorFee = addPatientViewModel.DoctorFee
            };
            _patientRepository.AddPatient(patient);
            return CreatedAtAction("GetPatientById", new { id = patient.PatientId }, patient);
        }

        [HttpPut]
        [Route("/api/patient/{id}")]
        public IActionResult EditPatient(int id,[FromBody] EditPatientViewModel editPatientViewModel)
        {
            Patient patient = _patientRepository.GetPatientById(id);
            if (patient == null)
            {
                return NotFound($"Patient with id = {id} not found");
            }
            patient.PatientName = editPatientViewModel.PatientName;
            patient.PatientAge = editPatientViewModel.PatientAge;
            patient.PatientGender = editPatientViewModel.PatientGender;
            patient.Department = editPatientViewModel.Department;
            patient.DoctorName = editPatientViewModel.DoctorName;
            patient.DoctorFee = editPatientViewModel.DoctorFee;
            _patientRepository.EditPatient(patient);
            return Ok(patient);

        }

        [HttpDelete]
        [Route("/api/patient")]
        public IActionResult DeletePatient(int id)
        {
            Patient patient=_patientRepository.
        }
    }
}
