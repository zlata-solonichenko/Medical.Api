using Medical.Api.Domain.Entities;
using Medical.Api.Persistance.Interfaces;
using Medical.Api.Repositories.Interfaces;

namespace Medical.Api.UseCases.Employee;

public class UpdateDoctorUseCase
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdateDoctorUseCase(IDoctorRepository doctorRepository, IUnitOfWork unitOfWork)
    {
        _doctorRepository = doctorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task ExecuteAsync(int doctorId, Domain.Entities.Doctor doctor)
    {
        await _doctorRepository.UpdateAsync(doctor);
    }
}