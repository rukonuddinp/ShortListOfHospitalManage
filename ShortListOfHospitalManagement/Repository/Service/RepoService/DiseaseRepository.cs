using Microsoft.EntityFrameworkCore;
using ShortListOfHospitalManagement.Context;
using ShortListOfHospitalManagement.Models;
using ShortListOfHospitalManagement.Repository.Manager;
using ShortListOfHospitalManagement.Repository.Service.Interface;

namespace ShortListOfHospitalManagement.Repository.Service.RepoService
{
    public class DiseaseRepository : GenericRepository<DiseaseInformation>, IDiseaseRepository
    {
        public DiseaseRepository(HospitalContext context) : base(context)
        {
        }

        public async Task<DiseaseInformation> GetDiseaseByName(string name)
        {
            return await _context.DiseaseInformations.FirstOrDefaultAsync(d => d.DiseaseName == name);
            
        }

        public async Task Insert(DiseaseInformation entity)
        {
            await _context.DiseaseInformations.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Update(DiseaseInformation entity)
        {
            _context.DiseaseInformations.Update(entity);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var entity = await _context.DiseaseInformations.FindAsync(id);
            if (entity != null)
            {
                _context.DiseaseInformations.Remove(entity);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<DiseaseInformation>> GetAll()
        {
            return await _context.DiseaseInformations.ToListAsync();
        }

        public async Task<DiseaseInformation> GetById(int id)
        {
            return await _context.DiseaseInformations.FindAsync(id);
        }
    }
}
