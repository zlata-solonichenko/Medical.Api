using Medical.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Medical.Api.Persistance;

public class MedicalContext : DbContext, IDesignTimeDbContextFactory<MedicalContext>
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }

    public MedicalContext(){}

    public MedicalContext(DbContextOptions<MedicalContext> options) : base(options)
    {
        //Database.EnsureCreated();
    }
    
    /// <summary>
    /// Связь один ко многим (один врач - много пациентов)
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Doctor>().HasKey(d => d.Id);
        modelBuilder.Entity<Doctor>()
            .HasMany<Patient>(d => d.Patients)
            .WithOne(patient => patient.Doctor);
        modelBuilder.Entity<Patient>().HasKey(p => p.Id);

    }

    /// <summary>
    /// Для создания контекста во время миграции
    /// </summary>
    /// <param name="args">аргументы</param>
    /// <returns></returns>
    public MedicalContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<MedicalContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=medical;Username=postgres;Password=postgres");
        
        return new MedicalContext(optionsBuilder.Options);
    }

   
}