using ShortListOfHospitalManagement.Context;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;

namespace ShortListOfHospitalManagement.Repository.Service.RepoService
{
    public class AllergyDetailRepository : GenericRepository<Allergies_Detail>
    {
        public AllergyDetailRepository(HospitalContext context) : base(context)
        {
        }
    }
}
