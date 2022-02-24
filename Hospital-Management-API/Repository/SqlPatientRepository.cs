using Hospital_Management_API.DBContext;
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
    }
}
