using PassRegistry.Data;

namespace PassRegistry.Logic;

/// <summary>
/// Сервис работы с <see cref="Pass"/>
/// </summary>
public sealed class PassService
{
    private readonly PassRepository passRepository = new();

    /// <summary>
    /// Получить список активных <see cref="Pass"/>
    /// </summary>
    public IReadOnlyCollection<Pass> GetActive()
        => passRepository.GetAll()
        .Where(x => x.IsValid)
        .ToList()
        .AsReadOnly();
}