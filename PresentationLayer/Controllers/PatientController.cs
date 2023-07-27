using Microsoft.AspNetCore.Mvc;
using ServiceLayer;
using ViewModel;

namespace PresentationLayer.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientServiceLayer patientServiceLayer;
        public PatientController(IPatientServiceLayer _patientServiceLayer)
        {
            patientServiceLayer = _patientServiceLayer;
        }
        
        [HttpGet]
        public IActionResult AddPatient()
        { 
            return View();
        }
        [HttpPost]
        public IActionResult AddPatient(PatientViewModel patientViewModel) 
        {
            patientServiceLayer.AddPatient(patientViewModel);
            return RedirectToAction("GetAllPatients");
            
        }
        public IActionResult GetAllPatients() 
        {
            List<PatientViewModel> patientViewModels = patientServiceLayer.GetAllPatients();
            return View(patientViewModels);
        }
        [HttpGet]
        public  IActionResult DeletePatient(int id) 
        {
             patientServiceLayer.DeletePatient(id);
            return RedirectToAction("GetAllPatients");
         }
        [HttpGet]
        public IActionResult EditPatient(int id)
        { 
            var jj=patientServiceLayer.EditPatient(id);
            return View(jj);
        } 
        [HttpPost]
        public IActionResult UpdatePatient(PatientViewModel patientViewModel)
        {
            patientServiceLayer.updatePatient(patientViewModel);
            return RedirectToAction("GetAllPatients");
        }

    }
}
