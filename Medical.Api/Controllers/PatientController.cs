using Medical.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Medical.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class PatientController : ControllerBase
{
    private readonly IPatientRepository _patientRepository;

    public PatientController(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }

    public async Task<IActionResult> Index()
    {
        var patients = await _patientRepository.GetAllAsync();
        return Ok(patients);
    }
    
    //далее остальные методы
}