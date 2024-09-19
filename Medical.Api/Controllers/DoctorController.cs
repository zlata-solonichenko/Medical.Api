using Medical.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Medical.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DoctorController : ControllerBase
{
    private readonly IDoctorRepository _doctorRepository;

    public DoctorController(IDoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    public async Task<IActionResult> Index()
    {
        var doctors = await _doctorRepository.GetAllAsync();
        return Ok(doctors);
    }
    
    //далее остальные методы
}