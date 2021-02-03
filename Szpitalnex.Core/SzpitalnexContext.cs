using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Szpitalnex.Database.Entities;

namespace Szpitalnex.Core.Models
{
    public class SzpitalnexContext : DbContext
    {
        public SzpitalnexContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Medicine> Medicines { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<Specialization> Specializations { get; set; }
        public DbSet<Visit> Visits { get; set; }
        public DbSet<PrescribedMedicine> PrescribedMedicines { get; set; }
        public DbSet<DiagnosedDisease> DiagnosedDiseases { get; set; }
        public DbSet<DoctorAvailability> DoctorAvailabilities { get; set; }
    }
}
