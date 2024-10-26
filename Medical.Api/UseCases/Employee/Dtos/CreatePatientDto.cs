using Medical.Api.Domain.Entities;

namespace Medical.Api.UseCases.Employee.Dtos;

public class CreatePatientDto
{
    
    /// <summary>
    /// Фамилия пациента
    /// </summary>
    public string Surname { get; set; }

    /// <summary>
    /// Имя пациента
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Отчество пациента
    /// </summary>
    public string SecondName { get; set; }
    
    /// <summary>
    /// Адрес пациента
    /// </summary>
    public string Adress { get; set; }

    /// <summary>
    /// Дата рождения пациента
    /// </summary>
    public DateTime DateOfBirth { get; set; }

    /// <summary>
    /// Пол пациента
    /// </summary>
    public string Gender { get; set; }

    /// <summary>
    /// Участок пациента
    /// </summary>
    public int Area { get; set; }
}