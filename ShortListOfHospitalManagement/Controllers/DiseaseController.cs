using Microsoft.AspNetCore.Mvc;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Service.Interface;
using ShortListOfHospitalManagement.ViewModel;

namespace ShortListOfHospitalManagement.Controllers
{
    public class DiseaseController : Controller
    {
        private readonly IDiseaseRepository _diseaseRepository;
        public DiseaseController(IDiseaseRepository diseaseRepository)
        {
            _diseaseRepository= diseaseRepository;
            
        }
        public async Task<IActionResult> Disease_Index()
        {
            var diseaseData = await _diseaseRepository.GetAll();
            var diseasesViewList = new DiseasesViewModel()
            {
                DiseasesList = diseaseData
            };
            return View(diseasesViewList);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDisease(string diseaseName)
        {
            if (!string.IsNullOrWhiteSpace(diseaseName))
            {
                var disease = new DiseaseInformation { DiseaseName = diseaseName };
                await _diseaseRepository.Insert(disease);
            }
            return RedirectToAction(nameof(Disease_Index));
        }
    }
}
