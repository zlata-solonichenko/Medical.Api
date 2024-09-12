using Medical.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Medical.Api.Persistance;

public class MedicalContext : DbContext, IDesignTimeDbContextFactory<MedicalContext>
{
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Patient> Patients { get; set; }

    public MedicalContext(DbContextOptions<MedicalContext> options)
    {
        Database.EnsureCreated();
    }

    public MedicalContext()
    {
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseNpgsql("");
    }

    public MedicalContext CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<MedicalContext>();
        //optionBuilder.UseNpgsql("");

        return new MedicalContext(optionBuilder.Options);
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
    
}