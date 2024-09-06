using VEntry = FS.ViewModels.IEntry;

namespace FS.ViewReferences;

/// <summary>
/// Объект-ссылка
/// </summary>
/// <typeparam name="VValue">Тип из ViewModels</typeparam>
public interface IEntry<VValue> where VValue : VEntry
{
    /// <summary>
    /// Идентификатор объекта
    /// </summary>
    public long ID { get; }

    /// <summary>
    /// Является ли объект <see cref="Nullable"/>
    /// </summary>
    public bool IsNull { get; }

    /// <summary>
    /// Загрузка и возрат полной копии объекта для отображения.
    /// </summary>
    /// <returns></returns>
    public VValue Loading();

}
