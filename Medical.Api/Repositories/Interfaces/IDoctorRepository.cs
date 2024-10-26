using Medical.Api.Domain.Entities;

namespace Medical.Api.Repositories.Interfaces;

public interface IDoctorRepository
{
    Task<List<Doctor>> GetAllAsync();
    Task<Doctor?> GetByIdAsync(int id);
    Task AddAsync(Doctor entity, CancellationToken cancellationToken);
    Task UpdateAsync(Doctor entity);
    Task DeleteAsync(int id);

}