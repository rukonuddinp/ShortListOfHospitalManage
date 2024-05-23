using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;

namespace ShortListOfHospitalManagement.Repository.Service.Interface
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        Task<Patient> GetPatientWithDetails(int id);

        Task<int> AddPatient(Patient patient);
    }
}
