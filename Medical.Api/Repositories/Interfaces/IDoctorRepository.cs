using Medical.Api.Persistance;
using Microsoft.EntityFrameworkCore;

namespace Medical.Api.Domain.Entities;

/// <summary>
/// Интерфейс доктора
/// </summary>
public class IDoctorRepository : IRepository<Doctor> 
{
    private readonly MedicalContext _context;
    private readonly DbSet<Doctor> _doctors;

    public IDoctorRepository(MedicalContext context)
    {
        _context = context;
        _doctors = _context.Set<Doctor>();
    }

    public async Task<IEnumerable<Doctor>> GetAllAsync()
    {
        return await _doctors.ToListAsync();
    }

    public async Task<Doctor> GetByIdAsync(int id)
    {
        return await _doctors.FindAsync(id);
    }

    public async Task AddAsync(Doctor entity)
    {
        await _doctors.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Doctor entity)
    {
        _doctors.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _doctors.FindAsync(id);
        if (entity != null)
        {
            _doctors.Remove(entity);
            await _context.SaveChangesAsync();
        }
    }
}