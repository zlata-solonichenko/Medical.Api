using System.ComponentModel.DataAnnotations;

namespace Medical.Api.Domain.Entities;

/// <summary>
/// Представляет собой сущность доктора
/// </summary>
public class Doctor
{
    /// <summary>
    /// ФИО доктора
    /// </summary>
    public string FIO { get; set; }
    
    /// <summary>
    /// Идентификатор доктора
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Кабинет доктора
    /// </summary>
    public Cabinet Cabinet { get; set; }

    /// <summary>
    /// Специализация доктора
    /// </summary>
    public Specialization Specialization { get; set; }

    /// <summary>
    /// Участок доктора (участковый врач)
    /// </summary>
    public Area Area { get; set; }

    /// <summary>
    /// Список пациентов доктора
    /// </summary>
    public List<Patient> Patients { get; set; } = new List<Patient>();
}