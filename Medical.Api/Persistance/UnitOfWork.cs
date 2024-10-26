using Medical.Api.Persistance.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Medical.Api.Persistance;

public class UnitOfWork : IUnitOfWork
{
    private readonly MedicalContext _medicalContext;

    public UnitOfWork(MedicalContext medicalContext)
    {
        _medicalContext = medicalContext;
    }

    public Task SaveChangesAsync(CancellationToken cancellationToken)
    {
        return _medicalContext.SaveChangesAsync(cancellationToken);
    }

    public void SaveChanges()
    {
        _medicalContext.SaveChanges();
    }

    public void Migrate()
    {
        _medicalContext.Database.Migrate();
    }
    
    public void Dispose()
    {
        _medicalContext.Dispose();
    }
}