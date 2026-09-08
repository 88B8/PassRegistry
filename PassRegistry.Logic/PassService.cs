namespace PassRegistry.Logic;

/// <summary>
/// Сервис работы с <see cref="Pass"/>
/// </summary>
public sealed class PassService
{
    private readonly IPassRepository passRepository;

    /// <summary>
    /// ctor
    /// </summary>
    public PassService(IPassRepository passRepository)
    {
        this.passRepository = passRepository;
    }

    /// <summary>
    /// Получить список активных <see cref="Pass"/>
    /// </summary>
    public IReadOnlyCollection<Pass> GetActive()
        => passRepository.GetAll()
        .Where(x => x.IsValid)
        .ToList()
        .AsReadOnly();
}