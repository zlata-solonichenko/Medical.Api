namespace Medical.Api.Domain.Entities;

/// <summary>
/// Представляет собой сущность участка, за котором может быть закреплен доктор
/// </summary>
public class Area
{
    /// <summary>
    /// Идентификатор участка
    /// </summary>
    public int Id { get; set; }
    
    /// <summary>
    /// Номер участка
    /// </summary>
    public int Number { get; set; }
}