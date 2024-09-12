namespace Medical.Api.Domain.Entities;

/// <summary>
/// Представляет собой сущность пациента
/// </summary>
public class Patient
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
    /// Идентификатор пациента
    /// </summary>
    public int Id { get; set; }

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
    public Area Area { get; set; }
    
    /// <summary>
    /// Внешний ключ
    /// </summary>
    public int PatientId { get; set; } 
    
    /// <summary>
    /// Навигационное свойство
    /// </summary>
    public Doctor Doctor { get; set; }
}