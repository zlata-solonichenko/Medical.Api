namespace Medical.Api.Domain.Entities;

public class DoctorDto
{
    public string FIO { get; set; }
    
    public int Id { get; set; }
    
    public Cabinet Cabinet { get; set; }
    
    public Specialization Specialization { get; set; }
    
    public Area Area { get; set; }
}