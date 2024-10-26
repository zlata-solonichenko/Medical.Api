using Medical.Api.Domain.Entities;
using Medical.Api.Persistance.Interfaces;
using Medical.Api.Repositories.Interfaces;
using Medical.Api.UseCases.Employee.Dtos;

namespace Medical.Api.UseCases.Employee;

public class AddPatientUseCase
{
    private readonly IPatientRepository _patientRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddPatientUseCase(IPatientRepository patientRepository, IUnitOfWork unitOfWork)
    {
        _patientRepository = patientRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task ExecuteAsync(CreatePatientDto dto, CancellationToken cancellationToken)
    {
        var patient = new Domain.Entities.Patient
        {
            Surname = dto.Surname,
            Name = dto.Name,
            SecondName = dto.SecondName,
            Adress = dto.Adress,
            DateOfBirth = dto.DateOfBirth,
            Gender = dto.Gender,
            Area = new Area{Number = dto.Area}
        };

        await _patientRepository.AddAsync(patient, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}