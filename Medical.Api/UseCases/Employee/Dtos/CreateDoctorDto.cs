namespace Medical.Api.UseCases.Employee.Dtos;

public class CreateDoctorDto
{
    /// <summary>
    /// ФИО доктора
    /// </summary>
    public string FIO { get; set; }
    
    /// <summary>
    /// Кабинет доктора
    /// </summary>
    public int Cabinet { get; set; }

    /// <summary>
    /// Специализация доктора
    /// </summary>
    public string Specialization { get; set; }

    /// <summary>
    /// Участок доктора (участковый врач)
    /// </summary>
    public int Area { get; set; }
}