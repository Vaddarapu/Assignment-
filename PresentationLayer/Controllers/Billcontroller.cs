using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ViewModel;

namespace PresentationLayer.Controllers
{
   
    public class Billcontroller : Controller
    {
        private readonly IBillService billService;
        public Billcontroller(IBillService _billService)
         {
            billService = _billService; 
        }
       
        [HttpGet]
        public IActionResult CreateBill()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult CreateBill(BillViewModel billViewModel)
        {
            billService.AddBill(billViewModel);
            return RedirectToAction("GetBillList");
        }
        public IActionResult GetBillList()
        {
           List<BillViewModel> billViewModels= billService.GetBillList();
            return View(billViewModels);
        }
        [HttpGet]
        public IActionResult  EditBill(int Id)
        {
          var jj=  billService.EditBill(Id);
            return View(jj);  
        }
        [HttpPost]
        public IActionResult UpdateBill(BillViewModel billViewModel)
        {
            billService.updateBill(billViewModel);
            return RedirectToAction("GetBillList");
        }
    }
}
