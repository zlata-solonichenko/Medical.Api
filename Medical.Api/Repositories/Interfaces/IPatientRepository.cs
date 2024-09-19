using Medical.Api.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Medical.Api.Domain.Entities;

/// <summary>
/// Интерфейс пациента
/// </summary>
public class IPatientRepository : IRepository<Patient>
{
    private readonly MedicalContext _context;
    private readonly DbSet<Patient> _patients;

    public IPatientRepository(MedicalContext context)
    {
        _context = context;
        _patients = _context.Set<Patient>();
    }

    public async Task<IEnumerable<Patient>> GetAllAsync()
    {
        return await _patients.ToListAsync();
    }

    public async Task<Patient> GetByIdAsync(int id)
    {
        return await _patients.FindAsync(id);
    }

    public async Task AddAsync(Patient entity)
    {
        await _patients.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Patient entity)
    {
        _patients.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _patients.FindAsync(id);
        if (entity != null)
        {
            _patients.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}