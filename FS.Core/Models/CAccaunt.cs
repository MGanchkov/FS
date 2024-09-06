using System.Text.Json.Serialization;

namespace FS.Models;

[method: JsonConstructor]
public class CAccaunt(long id, string name, string login, string password) : IEntry
{

    #region ctor

    public CAccaunt() : this(0, string.Empty, string.Empty, string.Empty) { }

    #endregion

    #region Property

    public long ID { get; set; } = id;

    /// <summary>
    /// Отображаемое имя
    /// </summary>
    public string Name { get; set; } = name;

    /// <summary>
    /// Логин подключения
    /// </summary>    
    public string Login { get; set; } = login;

    /// <summary>
    /// Пароль для подключения
    /// </summary>
    public string Password { get; set; } = password;

    #endregion

}
