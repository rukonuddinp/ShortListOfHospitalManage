using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShortListOfHospitalManagement.Models
{
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        public string? PatientName { get; set; }
        public int DiseaseFK_Id { get; set; }
        public bool EpilepsyVal { get; set; }
        public ICollection<NCD_Detail>? NCD_Details { get; set; }
        public ICollection<Allergies_Detail>? Allergies_Details { get; set; }
    }
}
