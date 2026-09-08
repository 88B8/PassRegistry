namespace PassRegistry.Logic;

/// <summary>
/// Репозиторий для работы с сущностью <see cref="Pass"/>
/// </summary>
public interface IPassRepository
{
    /// <summary>
    /// Получить список всех <see cref="Pass"/>
    /// </summary>
    IReadOnlyCollection<Pass> GetAll();
}