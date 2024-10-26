using Medical.Api.Domain.Entities;
using Medical.Api.Repositories.Implementations;
using Medical.Api.UseCases.Employee;
using Microsoft.AspNetCore.Mvc;

namespace Medical.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class DoctorController : ControllerBase
{
    private readonly DoctorRepository _doctorRepository;
    
    public DoctorController(DoctorRepository doctorRepository)
    {
        _doctorRepository = doctorRepository;
    }

    [HttpGet("all")]
    public async Task<IActionResult> GetAllDoctors()
    {
        var patients = await _doctorRepository.GetAllAsync();
        return Ok(patients);
    }
    
    [HttpGet("{id}")] // GET: api/doctor/{id}
    public async Task<ActionResult<Doctor>> GetDoctorById(int id)
    {
        var doctor = await _doctorRepository.GetByIdAsync(id);
        if (doctor == null)
        {
            return NotFound();
        }

        return Ok(doctor);
    }

    [HttpPost("create")] // POST: api/patient
    public async Task<IActionResult> AddDoctor([FromBody] Doctor doctor, CancellationToken cancellationToken)
    {
        if (doctor == null)
        {
            return BadRequest();
        }
        await _doctorRepository.AddAsync(doctor, cancellationToken);
        return CreatedAtAction(nameof(GetDoctorById), new { id = doctor.Id }, doctor);
    }

    [HttpPut("delete {id}")] // DELETE: api/doctor/{id}
    public async Task<IActionResult> DeleteDoctor(int id)
    {
        var doctor = await _doctorRepository.GetByIdAsync(id);
        if (doctor == null)
        {
            return NotFound();
        }

        await _doctorRepository.DeleteAsync(id);
        return Ok();
    }

    [HttpPut("update {id}")] // PUT: api/doctor/{id}
    public async Task<IActionResult> UpdateDoctor(int id, [FromBody] Doctor doctor)
    {
        if (doctor == null || doctor.Id != id)
        {
            return BadRequest();
        }

        var existingDoctor = await _doctorRepository.GetByIdAsync(id);
        if (existingDoctor == null)
        {
            return NotFound();
        }

        await _doctorRepository.UpdateAsync(doctor);
        return Ok(); //NoContent
    }
}