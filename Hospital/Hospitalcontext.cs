using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class Hospitalcontext : DbContext
    {
        public Hospitalcontext():base()
        {

        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<LabLookup> LabLookups { get; set; }
        public DbSet<PatientLab> patientLabs { get; set; }
    }

}
