using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital
{
    class PatientLab
    {
        public int Id { get; set; }
        public int? PatientId { get; set; }
        public int? LabId { get; set; }
        public List<Patient> Patients { get; set; }
        public List<LabLookup> LabLookups { get; set; }
    }
}
