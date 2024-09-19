using Medical.Api.Persistance;

namespace Medical.Api.Domain.Entities;

public class DoctorRepository : IDoctorRepository
{
    private readonly MedicalContext _context;
    
    public DoctorRepository(MedicalContext context) : base(context)
    {
        _context = context;
    }
    
}