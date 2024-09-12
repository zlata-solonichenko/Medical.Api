namespace Medical.Api.Domain.Entities;

/// <summary>
/// Представляет собой сущность кабинета доктора
/// </summary>
public class Cabinet
{
    /// <summary>
    /// Идентификатор кабинета
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Номер кабинета
    /// </summary>
    public int Number { get; set; }
}