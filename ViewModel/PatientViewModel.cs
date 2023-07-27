using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class PatientViewModel
    {          
        public int PatientId { get; set; }
        public String Name { get; set; }
        public int Age { get; set; }
        public String Gender { get; set; }
        public long PhoneNumber { get; set; }

    }
}

