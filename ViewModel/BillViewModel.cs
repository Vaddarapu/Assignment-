using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel
{
    public class BillViewModel
    {
        
        public int BillId { get; set; }
        public DateTime BillDate { get; set; }  
        public string ItemName { get; set; }
        public int TotalAmount { get; set; }
        public int AmountPaid { get; set; }
        public int Balance { get; set; }
        public int PatientId { get; set; }
       // [ForeignKey("PatientId")]
        //public virtual PatientTable PatientTables { get; set; }
    }
}

