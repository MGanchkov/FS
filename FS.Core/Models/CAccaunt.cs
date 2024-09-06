using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Models;

public class CAccaunt : IEntry
{
    #region ctor

    #endregion

    #region Property


    public long ID { get; set; }

    /// <summary>
    /// Отображаемое имя
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Логин подключения
    /// </summary>    
    public string Login { get; set; }

    /// <summary>
    /// Пароль для подключения
    /// </summary>
    public string Password { get; set; }

    #endregion

}
