using Medical.Api.Domain.Entities;
using Medical.Api.Persistance;
using Medical.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Medical.Api.Repositories.Implementations;

/// <summary>
/// Репозиторий доктора
/// </summary>
public class DoctorRepository : IDoctorRepository
{
    private readonly MedicalContext _context;

    public DoctorRepository(MedicalContext context)
    {
        _context = context;
    }

    public  Task<List<Doctor>> GetAllAsync()
    {
        return _context.Doctors.ToListAsync();
    }

    public Task<Doctor?> GetByIdAsync(int id)
    {
        return _context.Doctors.FindAsync(id).AsTask();
    }

    public Task AddAsync(Doctor entity, CancellationToken cancellationToken)
    { 
         return _context.Doctors.AddAsync(entity).AsTask();
    }

    public Task UpdateAsync(Doctor entity)
    {
        _context.Doctors.Update(entity);
        return Task.CompletedTask;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Doctors.FindAsync(id);
        if (entity != null)
        {
            _context.Doctors.Remove(entity);
        }
    }
}