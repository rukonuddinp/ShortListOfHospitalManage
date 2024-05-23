using ShortListOfHospitalManagement.Context;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;

namespace ShortListOfHospitalManagement.Repository.Service.RepoService
{
    public class NCDDetailRepository : GenericRepository<NCD_Detail>
    {
        public NCDDetailRepository(HospitalContext context) : base(context)
        {
        }
    }
}
