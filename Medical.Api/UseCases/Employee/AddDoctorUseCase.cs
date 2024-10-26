using Medical.Api.Domain.Entities;
using Medical.Api.Persistance.Interfaces;
using Medical.Api.Repositories.Interfaces;
using Medical.Api.UseCases.Employee.Dtos;

namespace Medical.Api.UseCases.Employee;

public class AddDoctorUseCase
{
    private readonly IDoctorRepository _doctorRepository;
    private readonly IUnitOfWork _unitOfWork;

    public AddDoctorUseCase(IDoctorRepository doctorRepository, IUnitOfWork unitOfWork)
    {
        _doctorRepository = doctorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task ExecuteAsync(CreateDoctorDto dto, CancellationToken cancellationToken)
    {
        var doctor = new Domain.Entities.Doctor
        {
            FIO = dto.FIO,
            Cabinet = new Cabinet{Number = dto.Cabinet},
            Specialization = new Specialization{Name = dto.Specialization},
            Area = new Area{Number = dto.Area}
        };

        await _doctorRepository.AddAsync(doctor, cancellationToken);
        await _unitOfWork.SaveChangesAsync(cancellationToken);
    }
}