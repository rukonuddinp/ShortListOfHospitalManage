using ShortListOfHospitalManagement.Models;

namespace ShortListOfHospitalManagement.ViewModel
{
    public class PatientViewModel
    {
        public string PatientName { get; set; }
        public int DiseaseFK_Id { get; set; }
        public int EpilepsyVal { get; set; }
        public int[] SelectedNCDs { get; set; }
        public int[] SelectedAllergies { get; set; }
    }
}
