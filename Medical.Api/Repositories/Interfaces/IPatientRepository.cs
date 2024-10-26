using Medical.Api.Domain.Entities;

namespace Medical.Api.Repositories.Interfaces;

public interface IPatientRepository
{
    Task<List<Patient>> GetAllAsync();
    Task<Patient?> GetByIdAsync(int id);
    Task AddAsync(Patient entity, CancellationToken cancellationToken);
    Task UpdateAsync(Patient entity);
    Task DeleteAsync(int id);
    
}