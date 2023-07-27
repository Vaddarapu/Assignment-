using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace ServiceLayer
{
    public interface IPatientServiceLayer
    {
        void AddPatient(PatientViewModel patientViewModel);
        List<PatientViewModel> GetAllPatients();
         void DeletePatient(int PatientId);
        PatientViewModel EditPatient( int PatientId);
        bool updatePatient(PatientViewModel patientViewModel);
    }
}
