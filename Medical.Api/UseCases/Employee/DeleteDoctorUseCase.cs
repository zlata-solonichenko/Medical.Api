using Medical.Api.Domain.Entities;
using Medical.Api.Persistance.Interfaces;
using Medical.Api.Repositories.Interfaces;

namespace Medical.Api.UseCases.Employee;

public class DeleteDoctorUseCase
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeleteDoctorUseCase(IDoctorRepository doctorRepository, IUnitOfWork unitOfWork)
    {
        _doctorRepository = doctorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task ExecuteAsync(int doctorId)
    {
        await _doctorRepository.DeleteAsync(doctorId);
    }
}