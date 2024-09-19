namespace Medical.Api.Domain.Entities;

/// <summary>
/// Интерфейс репозитория
/// </summary>
/// <typeparam name="T"></typeparam>
public interface IRepository<T> where T : class
{
    /// <summary>
    /// Получить все объекты
    /// </summary>
    /// <returns></returns>
    Task<IEnumerable<T>> GetAllAsync();
    
    /// <summary>
    /// Получить айди объекта
    /// </summary>
    /// <param name="id">айди объекта</param>
    /// <returns></returns>
    Task<T> GetByIdAsync(int id);
    
    /// <summary>
    /// Добавить объект
    /// </summary>
    /// <param name="entity">сущность</param>
    /// <returns></returns>
    Task AddAsync(T entity);
    
    /// <summary>
    /// Обновить объект
    /// </summary>
    /// <param name="entity">сущность</param>
    /// <returns></returns>
    Task UpdateAsync(T entity);
    
    /// <summary>
    /// Удалить объект по айди
    /// </summary>
    /// <param name="id">айди объекта</param>
    /// <returns></returns>
    Task DeleteAsync(int id);
}