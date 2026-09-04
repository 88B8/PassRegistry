namespace PassRegistry.Data;

/// <summary>
/// Репозиторий работы с <see cref="Pass"/>
/// </summary>
public sealed class PassRepository
{
    private readonly List<Pass> items = [
        new Pass{
            Id = Guid.NewGuid(),
            Visitor = "Федя",
            IsValid = true,
        },
        new Pass{
            Id = Guid.NewGuid(),
            Visitor = "Петя",
            IsValid = true,
        },
        new Pass{
            Id = Guid.NewGuid(),
            Visitor = "Вася",
            IsValid = false,
        },
        ];

    /// <summary>
    /// Получить все сущности <see cref="Pass"/>
    /// </summary>
    public IReadOnlyCollection<Pass> GetAll()
        => items.AsReadOnly();
}