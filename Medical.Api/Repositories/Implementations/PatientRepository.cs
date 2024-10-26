using Medical.Api.Domain.Entities;
using Medical.Api.Persistance;
using Medical.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Medical.Api.Repositories.Implementations;

/// <summary>
/// Репозиторий пациента
/// </summary>
public class PatientRepository : IPatientRepository
{
    private readonly MedicalContext _context;

    public PatientRepository(MedicalContext context)
    {
        _context = context;
    }

    public Task<List<Patient>> GetAllAsync()
    {
        return _context.Patients.ToListAsync();
    }

    public Task<Patient?> GetByIdAsync(int id)
    {
        return _context.Patients.FindAsync(id).AsTask();
    }

    public Task AddAsync(Patient entity, CancellationToken cancellationToken)
    {
        return _context.Patients.AddAsync(entity).AsTask();
    }

    public Task UpdateAsync(Patient entity)
    {
        _context.Patients.Update(entity);
        return Task.CompletedTask;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Patients.FindAsync(id);
        if (entity != null)
        {
            _context.Patients.Remove(entity);
        }
    }
}