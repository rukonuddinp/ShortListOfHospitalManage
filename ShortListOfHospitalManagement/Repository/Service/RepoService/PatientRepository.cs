using Microsoft.EntityFrameworkCore;
using ShortListOfHospitalManagement.Context;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;
using ShortListOfHospitalManagement.Repository.Service.Interface;

namespace ShortListOfHospitalManagement.Repository.Service.RepoService
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(HospitalContext context) : base(context)
        {
        }

        public async Task<Patient> GetPatientWithDetails(int id)
        {
            return await _context.Patients
                .Include(p => p.NCD_Details)
                .ThenInclude(nd => nd.NCD)
                .Include(p => p.Allergies_Details)
                .ThenInclude(ad => ad.Allergy)
                .FirstOrDefaultAsync(p => p.ID == id);
        }

        public async Task<int?> LastInsertedId()
        {
            return _context.Patients.OrderByDescending(p => p.ID).Select(p => p.ID).FirstOrDefault();

        }

        public async Task<int> AddPatient(Patient patient)
        {
            try
            {
                _context.Patients.Add(patient);
                await _context.SaveChangesAsync();
                return patient.ID; // Ensure ID is being generated and returned
            }
            catch (Exception ex)
            {
                // Log the exception (you can use a logging framework)
                throw new Exception("An error occurred while adding the patient", ex);
            }
        }
    }
}
