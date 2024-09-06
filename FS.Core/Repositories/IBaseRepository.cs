using FS.Models;

namespace FS.Repositories;

/// <summary>
/// Базовый интерфейс доступа к базе данных
/// </summary>
/// <typeparam name="TValue"></typeparam>
public interface IBaseRepository<TValue> where TValue : IEntry
{

    #region CRUD

    /// <summary>
    /// Добавить объект в базу данных
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public long Insert(TValue item);
    /// <summary>
    /// Вернуть объект из базы данных
    /// </summary>
    /// <param name="id"></param>
    /// <returns>Если объект не существуует, то возращает <see cref="Nullable"/></returns>
    public TValue? Item(long id);
    /// <summary>
    /// Обновляет объект в базе данных
    /// </summary>
    /// <param name="item"></param>
    /// <returns></returns>
    public bool Update(TValue item);
    /// <summary>
    /// Удалить объект из базы данных
    /// </summary>
    /// <param name="id"></param>
    /// <returns></returns>
    public bool Delete(long id);

    #endregion

    /// <summary>
    /// Все объекты
    /// </summary>
    /// <returns></returns>
    public IEnumerable<TValue> GetAll();

    /// <summary>
    /// Поиск объектов
    /// </summary>
    /// <param name="predicate"></param>
    /// <returns></returns>
    public IEnumerable<TValue> Find(Func<TValue, bool> predicate) => GetAll().Where(predicate);


}
