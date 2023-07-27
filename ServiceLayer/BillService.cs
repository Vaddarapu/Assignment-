using DAL.Entities;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceLayer
{
    public class BillService : IBillService
    {
        private readonly IBillRepository1 billRepository;
        public BillService(IBillRepository1 _BillRepository)
        {
            billRepository = _BillRepository;
        }
        public void AddBill(BillViewModel billviewModel)
        {
            BillsTable bt = new BillsTable();
            bt.PatientId = billviewModel.PatientId;
           // bt.BillId = billviewModel.BillId;
            bt.BillDate = billviewModel.BillDate;
            bt.ItemName = billviewModel.ItemName;
            bt.TotalAmount= billviewModel.TotalAmount;
            bt.AmountPaid = billviewModel.AmountPaid;
            bt.Balance = billviewModel.Balance;
            billRepository.AddBill(bt);

        }

        public BillViewModel EditBill(int Id)
        {
            BillsTable bt = billRepository.EditBill(Id);
            BillViewModel ak = new BillViewModel();
            ak.PatientId = bt.PatientId;
            ak.BillDate = bt.BillDate;
            ak.BillId = bt.BillId;
            ak.ItemName = bt.ItemName;
            ak.TotalAmount = bt.TotalAmount;
            ak.AmountPaid = bt.AmountPaid;
            ak.Balance = bt.Balance;
           
            return ak;
        }

        public List<BillViewModel> GetBillList()
        {
            List<BillsTable> pt = billRepository.GetAllBills();
            List<BillViewModel> pvm = new List<BillViewModel>();
            foreach(BillsTable abc in pt)
            {
                BillViewModel billViewModel = new BillViewModel();
               billViewModel.BillId = abc.BillId;
                billViewModel.PatientId = abc.PatientId;
                billViewModel.BillDate = abc.BillDate;
                billViewModel.ItemName = abc.ItemName;
                billViewModel.TotalAmount = abc.TotalAmount;
                billViewModel.AmountPaid = abc.AmountPaid;
                billViewModel.Balance = abc.Balance;
                
                pvm.Add(billViewModel);
            }
            return pvm;

        }

        public bool updateBill(BillViewModel billViewModel)
        {
            {
                BillsTable employe = new BillsTable();
                employe.PatientId = billViewModel.PatientId;
                employe.BillId = billViewModel.BillId;
                employe.BillDate = billViewModel.BillDate;
                employe.ItemName = billViewModel.ItemName;
                employe.TotalAmount = billViewModel.TotalAmount;
                employe.AmountPaid= billViewModel.AmountPaid;   
                employe.Balance = billViewModel.Balance;    
                return billRepository.UpdateBill(employe);

            }
        }
    }
    }

