namespace Medical.Api.Persistance.Interfaces;

public interface IUnitOfWork : IDisposable
{
    Task SaveChangesAsync(CancellationToken cancellationToken);
    void SaveChanges();
    void Migrate();
}