using Hospital_Management_API.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital_Management_API.DBContext
{
    public class HospitalDbContext: IdentityDbContext<IdentityUser>
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options) : base(options)
        {

        }
        public DbSet<Patient> Patients { get; set; }
    }
}
