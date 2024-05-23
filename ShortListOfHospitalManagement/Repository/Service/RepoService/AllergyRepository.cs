using ShortListOfHospitalManagement.Context;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;

namespace ShortListOfHospitalManagement.Repository.Service.RepoService
{
    public class AllergyRepository : GenericRepository<Allergy>
    {
        public AllergyRepository(HospitalContext context) : base(context)
        {
        }
    }
}
