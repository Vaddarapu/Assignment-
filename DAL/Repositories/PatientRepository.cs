using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class PatientRepository : IPatientRepository
    {
        private readonly PatientDBcontext patientDBcontext;
        public PatientRepository(PatientDBcontext _patientDBcontext)
        {
            patientDBcontext= _patientDBcontext;
        }

      

        public void AddPatient(PatientTable patientTable)
        {
            patientDBcontext.Add(patientTable);
            patientDBcontext.SaveChanges();
        }

        public void DeletePatient(int Id)
        {
            {
                PatientTable patient = patientDBcontext.PatientTables.FirstOrDefault(x => x.PatientId == Id);
                patientDBcontext.Remove(patient);
                patientDBcontext.SaveChanges();
            }
        }

        public PatientTable EditPatient(int Id)
        {
            return patientDBcontext.PatientTables.FirstOrDefault(x => x.PatientId == Id);
        }

        public List<PatientTable> GetAllPatients()
        {
            return patientDBcontext.PatientTables.ToList();
        }

        public bool UpdatePatient(PatientTable patientTable)
        {
                var IsUpdated = false;
                var emp = patientDBcontext.PatientTables.FirstOrDefault(x => x.PatientId == patientTable.PatientId);
                if (emp != null)
                {
                    emp.Name = patientTable.Name;
                    emp.Age = patientTable.Age;
                    emp.Gender = patientTable.Gender;
                    emp.PhoneNumber= patientTable.PhoneNumber;
                
                    IsUpdated = true;
                    patientDBcontext.SaveChanges();
                }
                return IsUpdated;
            }

    }
    
}
