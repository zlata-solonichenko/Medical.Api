using Medical.Api.Persistance;

namespace Medical.Api.Domain.Entities;

public class PatientRepository : IPatientRepository
{
    private readonly MedicalContext _context;
    
    public PatientRepository(MedicalContext context) : base(context)
    {
        _context = context;
    }
    
}