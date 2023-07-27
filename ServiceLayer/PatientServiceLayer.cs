using DAL.Entities;
using DAL.Repositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceLayer
{
    public class PatientServiceLayer : IPatientServiceLayer
    {
        private readonly IPatientRepository patientRepository;
        public PatientServiceLayer(IPatientRepository _patientRepository)
        {
            patientRepository= _patientRepository;
        }
        public void AddPatient(PatientViewModel patientViewModel)
        {
            PatientTable pt=new PatientTable();
            pt.Name = patientViewModel.Name;
            pt.Age = patientViewModel.Age;
            pt.Gender = patientViewModel.Gender;
            pt.PhoneNumber = patientViewModel.PhoneNumber;
            patientRepository.AddPatient(pt);

        }

        public void DeletePatient(int PatientId)
        {
            patientRepository.DeletePatient(PatientId);
        }

        public PatientViewModel EditPatient(int PatientId)
        {
            PatientTable patientTable=patientRepository.EditPatient(PatientId);
            PatientViewModel ak=new PatientViewModel();
            ak.PatientId = patientTable.PatientId;
            ak.Name = patientTable.Name;
            ak.Age = patientTable.Age;
            ak.Gender = patientTable.Gender;
            ak.PhoneNumber = patientTable.PhoneNumber;
            return ak;
        }

        public List<PatientViewModel> GetAllPatients()
        {
            List<PatientTable> pt=patientRepository.GetAllPatients();
            List<PatientViewModel> pvm=new List<PatientViewModel>();
            foreach(PatientTable  abc in pt)
            {
                PatientViewModel patientViewModel = new PatientViewModel();
                patientViewModel.PatientId= abc.PatientId;
                patientViewModel.Name= abc.Name;
                patientViewModel.Age = abc.Age;
                patientViewModel.Gender = abc.Gender;
                patientViewModel.PhoneNumber = abc.PhoneNumber;
                pvm.Add(patientViewModel);
            }
            return pvm;
            
        }

        public bool updatePatient(PatientViewModel patientViewModel)
        {
            PatientTable employe = new PatientTable();
            employe.PatientId = patientViewModel.PatientId;
            employe.Name = patientViewModel.Name;
            employe.Age = patientViewModel.Age;
            employe.Gender = patientViewModel.Gender;
            employe.PhoneNumber = patientViewModel.PhoneNumber;
            return patientRepository.UpdatePatient(employe);

        }

    }
    
}
