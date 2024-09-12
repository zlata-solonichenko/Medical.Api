namespace Medical.Api.Domain.Entities;

/// <summary>
/// Представляет собой сущность специализации доктора
/// </summary>
public class Specialization
{
    /// <summary>
    /// Идентификатор специализации
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Название специализации
    /// </summary>
    public string Name { get; set; }
}