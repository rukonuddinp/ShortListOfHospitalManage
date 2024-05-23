using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository;
using ShortListOfHospitalManagement.Repository.Manager;
using ShortListOfHospitalManagement.Repository.Service.Interface;
using ShortListOfHospitalManagement.ViewModel;

namespace ShortListOfHospitalManagement.Controllers
{
    public class PatientController : Controller
    {
        private readonly IPatientRepository _patientRepository;
        private readonly IDiseaseRepository _diseaseRepository;
        private readonly IGenericRepository<NCD> _ncdRepository;
        private readonly IGenericRepository<Allergy> _allergyRepository;
        private readonly IGenericRepository<NCD_Detail> _ncdDetailRepository;
        private readonly IGenericRepository<Allergies_Detail> _allergyDetailRepository;
        public PatientController(
            IPatientRepository patientRepository,
            IDiseaseRepository diseaseRepository,
            IGenericRepository<NCD> ncdRepository,
            IGenericRepository<Allergy> allergyRepository,
            IGenericRepository<NCD_Detail> ncdDetailRepository,
            IGenericRepository<Allergies_Detail> allergyDetailRepository
            )
        {
            _patientRepository = patientRepository;
            _diseaseRepository= diseaseRepository;
            _ncdRepository = ncdRepository;
            _allergyRepository = allergyRepository;
            _ncdDetailRepository= ncdDetailRepository;
            _allergyDetailRepository= allergyDetailRepository;

        }
        public async Task<IActionResult> Patient_View()
        {
            //var patients = await _patientRepository.GetAll();
            var diseases = await _diseaseRepository.GetAll();
            ViewBag.DiseasesList = new SelectList(diseases, "ID", "DiseaseName");
            ViewBag.EpilepsyList = Epilepsy.True.ToSelectList();
            ViewBag.NCDList = new SelectList(await _ncdRepository.GetAll(), "ID", "NCDName");
            ViewBag.AllergyList = new SelectList(await _allergyRepository.GetAll(), "ID", "AllergyName");


            return View();
        }

        [HttpPost]
        public IActionResult Add_RemoveNCD(string[] selectedNCDs, string action)
        {
            // Handle adding or removing NCDs based on the action
            if (action == "AddNCD")
            {
                // Logic to add NCDs
            }
            else if (action == "RemoveNCD")
            {
                // Logic to remove NCDs
            }

            // Perform any additional processing

            // Redirect back to the view or return a PartialView if required
            return View();
        }


        public async Task<IActionResult> Create()
        {
            ViewBag.NCDs = await _ncdRepository.GetAll();
            ViewBag.Allergies = await _allergyRepository.GetAll();
            return View();
        }

        [HttpPost]
       
        public async Task<IActionResult> Create([FromBody] PatientViewModel model)
        {

            if (ModelState.IsValid)
            {
                // Create and add the patient
                var patient = new Patient
                {
                    PatientName = model.PatientName,
                    DiseaseFK_Id = model.DiseaseFK_Id,
                    EpilepsyVal = model.EpilepsyVal==1 ? true : false
                };

            var patientId = await _patientRepository.AddPatient(patient); // This should return a non-null ID

                if (patientId == 0)
                {
                    // Handle the case where the patient ID could not be retrieved (this should not happen if ID is correctly generated)
                    return Json(new { success = false, message = "Error inserting patient." });
                }

                // Add NCD details
                foreach (var ncdId in model.SelectedNCDs)
                {
                    await _ncdDetailRepository.Add(new NCD_Detail { PatientID = patientId, NCDID = ncdId });
                }

                // Add allergy details
                foreach (var allergyId in model.SelectedAllergies)
                {
                    await _allergyDetailRepository.Add(new Allergies_Detail { PatientID = patientId, AllergyID = allergyId });
                }

                return Json(new { success = true, message= "Save successfully, Please check database" });
            }

            return Json(new { success = false, message = "Model not valid, please check" });
        }
    }
}
