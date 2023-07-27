using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class PatientDBcontext:DbContext
    {
        public PatientDBcontext(DbContextOptions<PatientDBcontext> options) : base(options)
        {

        }
        public DbSet<PatientTable> PatientTables { get; set; }
        public DbSet<BillsTable>BillsTables  { get; set; }
    }

}
