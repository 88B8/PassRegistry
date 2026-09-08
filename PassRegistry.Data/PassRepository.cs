using PassRegistry.Logic;

namespace PassRegistry.Data;

/// <inheritdoc cref="IPassRepository"/>
public sealed class PassRepository : IPassRepository
{
    private readonly List<Pass> items = [
        new Pass
        {
            Id = Guid.NewGuid(),
            Visitor = "Федя",
            IsValid = true,
        },
        new Pass
        {
            Id = Guid.NewGuid(),
            Visitor = "Петя",
            IsValid = true,
        },
        new Pass
        {
            Id = Guid.NewGuid(),
            Visitor = "Вася",
            IsValid = false,
        },
        ];

    IReadOnlyCollection<Pass> IPassRepository.GetAll()
        => items.AsReadOnly();
}