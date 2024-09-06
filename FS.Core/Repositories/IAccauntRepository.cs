using FS.Models;

namespace FS.Repositories;

public interface IAccauntRepository : IBaseRepository<CAccaunt>
{

    /// <summary>
    /// Создание нового аккаунта
    /// </summary>
    /// <param name="login">Логин создаваемого аккаунта (должен быть уникальным)</param>
    /// <param name="password">Пароль создаваемого аккаунта</param>
    /// <param name="name">Отображаемое имя</param>
    /// <returns>Если создание не удалось, то вернёт <see cref="Nullable"/></returns>
    public CAccaunt? Create(string login, string password, string? name = null);

}
