using PassRegistry.Logic;

namespace PassRegistry.Data;

/// <inheritdoc cref="IPassRepository"/>
public sealed class DemoPassRepository : IPassRepository
{
    private readonly List<Pass> demoItems = [
        new Pass{
            Id = Guid.NewGuid(),
            Visitor = "Demo",
            IsValid = true,
        }
        ];

    IReadOnlyCollection<Pass> IPassRepository.GetAll()
        => demoItems.AsReadOnly();
}