using PassRegistry.Logic;

var passSerivce = new PassService();

Console.WriteLine($"Отобранные записи:");

var activePasses = passSerivce.GetActive();
foreach (var pass in activePasses)
{
    Console.WriteLine($"{pass.Id}: {pass.Visitor}");
}