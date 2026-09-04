namespace PassRegistry.Data;

/// <summary>
/// Модель сущности пропуска
/// </summary>
public sealed record Pass
{
    /// <summary>
    /// Идентификатор
    /// </summary>
    public Guid Id { get; init; }

    /// <summary>
    /// Посетитель
    /// </summary>
    public string Visitor { get; init; } = string.Empty;

    /// <summary>
    /// Флаг актуальности
    /// </summary>
    public bool IsValid { get; init; }
}