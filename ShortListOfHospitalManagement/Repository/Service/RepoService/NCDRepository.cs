using ShortListOfHospitalManagement.Context;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;

namespace ShortListOfHospitalManagement.Repository.Service.RepoService
{
    public class NCDRepository : GenericRepository<NCD>
    {
        public NCDRepository(HospitalContext context) : base(context)
        {
        }
    }
}
