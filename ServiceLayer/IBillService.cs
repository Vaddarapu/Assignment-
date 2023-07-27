using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceLayer
{
    public interface IBillService
    {
        void AddBill(BillViewModel billviewModel);
        List<BillViewModel> GetBillList();
        BillViewModel EditBill(int Id);
        bool updateBill(BillViewModel billViewModel);
    

}
}
