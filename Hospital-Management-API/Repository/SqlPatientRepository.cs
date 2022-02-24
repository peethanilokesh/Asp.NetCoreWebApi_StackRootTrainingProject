using Hospital_Management_API.DBContext;
using Hospital_Management_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_API.Repository
{
    public class SqlPatientRepository:IPatientRepository
    {
        HospitalDbContext _hospitalDbContext;
        public SqlPatientRepository(HospitalDbContext hospitalDbContext)
        {
            _hospitalDbContext = hospitalDbContext;
        }

        public void AddPatient(Patient patient)
        {
            _hospitalDbContext.Patients.Add(patient);
            _hospitalDbContext.SaveChanges();
        }

        public void DeleteById(int id)
        {
            Patient patient = GetPatientById(id);
            _hospitalDbContext.Patients.Remove(patient);
            _hospitalDbContext.SaveChanges();
        }

        public void EditPatient(Patient patient)
        {
            var patientChanges = _hospitalDbContext.Patients.Attach(patient);
            patientChanges.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _hospitalDbContext.SaveChanges();


        }

        public List<Patient> GetAllPatient()
        {
            return _hospitalDbContext.Patients.ToList();
        }

        public Patient GetPatientById(int id)
        {
            return _hospitalDbContext.Patients.FirstOrDefault(x => x.PatientId == id);
        }

        public List<Patient> GetPatientByName(string name)
        {
            List<Patient> patients= _hospitalDbContext.Patients.ToList();
            return patients.FindAll(x => x.PatientName == name);
        }
    }
}
