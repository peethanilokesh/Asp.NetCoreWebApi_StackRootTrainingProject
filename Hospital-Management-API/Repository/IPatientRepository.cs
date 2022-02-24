using Hospital_Management_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_API.Repository
{
    public interface IPatientRepository
    {
        List<Patient> GetAllPatient();

        Patient GetPatientById(int id);

        Patient GetPatientByName(string name);

        void AddPatient(Patient patient);

       

        void DeleteById(int id);

        void EditPatient(Patient patient);

    }
}
