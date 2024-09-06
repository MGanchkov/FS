using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FS.Repositories;

using MEntry = FS.Models.IEntry;
using VEntry = FS.ViewModels.IEntry;
using REntry = FS.ViewReferences.IEntry<FS.ViewModels.IEntry>;

namespace FS.Services;

/// <summary>
/// Базовая реализация сервиса
/// </summary>
/// <typeparam name="MValue"></typeparam>
/// <typeparam name="VValue"></typeparam>
/// <typeparam name="RValue"></typeparam>
/// <param name="repository">Класс подключения к запясям типа <see cref="MValue"/> из базы данных.</param>
public abstract class BaseService<MValue, VValue, RValue>(IBaseRepository<MValue> repository)
	where MValue : MEntry 
	where VValue : VEntry
	where RValue : REntry
{

	#region Property

	public IBaseRepository<MValue> Repository { get; set; } = repository;

	#endregion

	#region Actions

	/// <summary>
	/// Возращает объект, если он существует в базе данных
	/// </summary>
	/// <param name="id"></param>
	/// <returns></returns>
	public VValue? Item(long id)
	{
		MValue? item = Repository.Item(id);
		if (item is null) return default;
		return ConvertingToView(item);
    }

	/// <summary>
	/// Возращает объект-ссылку
	/// </summary>
	/// <param name="id">Идентификатор объекта</param>
	/// <returns></returns>
	public RValue Reference(long id) => ConvertingToReference(Repository.Item(id));

    /// <summary>
    /// Поиск и возрат объекта если он существует.
    /// </summary>
    /// <param name="id">Идентификатор объекта</param>
    /// <param name="item">Сюда будет установлен объект</param>
    /// <returns><see cref="true"/> если объект существует и не <see cref="Nullable"/>.</returns>
    public bool TryGetValue(long id, out VValue? item) => (item = Item(id)) is not null;

	/// <summary>
	/// Существует ли объект с таким идентификатором
	/// </summary>
	/// <param name="id">Идентификатор объекта</param>
	/// <returns>Возвращает <see cref="true"/> если объект существует</returns>
	public bool Contains(long id) => Item(id) is not null;

    #endregion

    #region Converting

    protected abstract VValue ConvertingToView(MValue item);
    protected abstract RValue ConvertingToReference(MValue? item);

    #endregion

}
