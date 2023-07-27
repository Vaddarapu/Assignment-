using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public interface IPatientRepository
    {
        void AddPatient(PatientTable patientTable);
        List<PatientTable> GetAllPatients();
        void DeletePatient( int PatientId);
        PatientTable EditPatient(int PatientId);
        bool UpdatePatient(PatientTable patientTable);
    }
}
