using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class BillRepository : IBillRepository1
    {
        private readonly PatientDBcontext patientDBcontext;
        public BillRepository(PatientDBcontext _patientDBcontext)
        {
            patientDBcontext= _patientDBcontext;
        }
        public void AddBill(BillsTable billsTable)
        {
            patientDBcontext.Add(billsTable);
            patientDBcontext.SaveChanges();

        }

        public BillsTable EditBill(int Id)
        {
             return patientDBcontext.BillsTables.FirstOrDefault(x => x.BillId == Id);
        }

        public List<BillsTable> GetAllBills()
        {
            return patientDBcontext.BillsTables.ToList();
        }

        public bool UpdateBill(BillsTable billsTable)
        {

            var IsUpdated = false;
            var emp = patientDBcontext.BillsTables.FirstOrDefault(x => x.BillId == billsTable.BillId);
            if (emp != null)
            {
                emp.PatientId = billsTable.PatientId;
                emp.BillDate = billsTable.BillDate;
                emp.ItemName = billsTable.ItemName;
                emp.TotalAmount = billsTable.TotalAmount;
                emp.AmountPaid = billsTable.AmountPaid;
                emp.Balance = billsTable.Balance;



                IsUpdated = true;
                patientDBcontext.SaveChanges();
            }
            return IsUpdated;
        }
    }
    }

