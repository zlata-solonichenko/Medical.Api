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

    [HttpGet("all")]
    public async Task<IActionResult> GetAllPatients()
    {
        var patients = await _patientRepository.GetAllAsync();
        return Ok(patients);
    }
    
    [HttpGet("{id}")] // GET: api/patient/{id}
    public async Task<ActionResult<Patient>> GetPatientById(int id)
    {
        var patient = await _patientRepository.GetByIdAsync(id);
        if (patient == null)
        {
            return NotFound();
        }

        return Ok(patient);
    }

    [HttpPost("create")] // POST: api/patient
    public async Task<IActionResult> AddPatient([FromBody] Patient patient)
    {
        if (patient == null)
        {
            return BadRequest();
        }
        await _patientRepository.AddAsync(patient);
        return CreatedAtAction(nameof(GetPatientById), new { id = patient.Id }, patient);
    }

    [HttpPut("delete {id}")] // DELETE: api/patient/{id}
    public async Task<IActionResult> DeletePatient(int id)
    {
        var patient = await _patientRepository.GetByIdAsync(id);
        if (patient == null)
        {
            return NotFound();
        }

        await _patientRepository.DeleteAsync(id);
        return Ok();
    }

    [HttpPut("update {id}")] // PUT: api/patient/{id}
    public async Task<IActionResult> UpdatePatient(int id, [FromBody] Patient patient)
    {
        if (patient == null || patient.Id != id)
        {
            return BadRequest();
        }

        var existingPatient = await _patientRepository.GetByIdAsync(id);
        if (existingPatient == null)
        {
            return NotFound();
        }

        await _patientRepository.UpdateAsync(patient);
        return Ok(); //NoContent
    }
}