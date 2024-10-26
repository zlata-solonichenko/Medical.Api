using Medical.Api.Persistance.Interfaces;
using Medical.Api.Repositories.Interfaces;

namespace Medical.Api.UseCases.Employee;

public class DeletePatientUseCase
{
    private readonly IPatientRepository _patientRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DeletePatientUseCase(IPatientRepository patientRepository, IUnitOfWork unitOfWork)
    {
        _patientRepository = patientRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task ExecuteAsync(int patientId)
    {
        await _patientRepository.DeleteAsync(patientId);
    }
}