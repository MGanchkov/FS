using FS.Models;
using FS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FS.Services;

public class BaseService<TValue>(IBaseRepository<TValue> repository) where TValue : IEntry
{

	#region property

	public IBaseRepository<TValue> Repository { get; set; } = repository;

	#endregion

	
	/// <summary>
	/// Возращает объект, если он существует в базе данных
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public TValue? Item(long id) => Repository.Item(id);

	/// <summary>
	/// Поиск и возрат объекта если он существует.
	/// </summary>
	/// <param name="id">Идентификатор объекта</param>
	/// <param name="item">Сюда будет установлен объект</param>
	/// <returns><see cref="true"/> если объект существует и не <see cref="Nullable"/>.</returns>
	public bool TryGetValue(long id, out TValue? item) => (item = Item(id)) is not null;

	/// <summary>
	/// Существует ли объект с таким идентификатором
	/// </summary>
	/// <param name="id">Идентификатор объекта</param>
	/// <returns>Возвращает <see cref="true"/> если объект существует</returns>
	public bool Contains(long id) => Item(id) is not null;


}
