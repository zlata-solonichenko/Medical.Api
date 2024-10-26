using Medical.Api.Persistance.Interfaces;
using Medical.Api.Repositories.Interfaces;

namespace Medical.Api.UseCases.Employee;

public class UpdatePatientUseCase
{
    private readonly IPatientRepository _patientRepository;
    private readonly IUnitOfWork _unitOfWork;

    public UpdatePatientUseCase(IPatientRepository patientRepository, IUnitOfWork unitOfWork)
    {
        _patientRepository = patientRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task ExecuteAsync(int patientId, Domain.Entities.Patient patient)
    {
        await _patientRepository.UpdateAsync(patient);
    }
}