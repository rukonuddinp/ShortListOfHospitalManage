using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;

namespace ShortListOfHospitalManagement.Repository.Service.Interface
{
    public interface IDiseaseRepository : IGenericRepository<DiseaseInformation>
    {
        Task<DiseaseInformation> GetDiseaseByName(string name);
        Task Insert(DiseaseInformation entity);
        Task Update(DiseaseInformation entity);
        Task Delete(int id);
        Task<IEnumerable<DiseaseInformation>> GetAll();
        Task<DiseaseInformation> GetById(int id);

    }
}
