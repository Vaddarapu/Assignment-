using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IBillRepository1
    {
        void AddBill(BillsTable billsTable);
        List<BillsTable> GetAllBills();
        BillsTable EditBill(int Id);
       bool  UpdateBill(BillsTable billsTable);
    }
}
