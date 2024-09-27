namespace Medical.Api.Domain.Entities;

public class PatientDto
{
    public string Surname { get; set; }

    public string Name { get; set; }
    
    public string SecondName { get; set; }
    
    public int Id { get; set; }

    public string Adress { get; set; }
    
    public DateTime DateOfBirth { get; set; }
    
    public string Gender { get; set; }
    
    public Area Area { get; set; }
}