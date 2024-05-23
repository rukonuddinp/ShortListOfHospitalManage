namespace ShortListOfHospitalManagement.Models
{
    public class Allergies_Detail
    {
        public int ID { get; set; }
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        public int AllergyID { get; set; }
        public Allergy Allergy { get; set; }
    }
}
