using PassRegistry.Data;
using PassRegistry.Logic;

IPassRepository passRepository = new DemoPassRepository();
var passService = new PassService(passRepository);

Console.WriteLine($"Отобранные записи:");

var activePasses = passService.GetActive();
foreach (var pass in activePasses)
{
    Console.WriteLine($"{pass.Id}: {pass.Visitor}");
}