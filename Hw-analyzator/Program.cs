using System;
using Hardware.Info;
using Spectre.Console;

HardwareInfo infopocitace = new HardwareInfo();
//HardwareInfo.RefreshAll();
Console.WriteLine(infopocitace.OperatingSystem);

//zepta se uzivatele na vyber

var fruit = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("*")
        .PageSize(10)
        .AddChoices(new[] {
            "CPU", "Motherboard", "RAM", "GPU","Storage"
        }));

if (fruit == "CPU")
{
    foreach (var cpu in infopocitace.CpuList)
    {
        Console.WriteLine(cpu);
        foreach (var cpuCore in cpu.CpuCoreList)
            Console.WriteLine(cpuCore);
    }
}
if (fruit == "Motherboard")
{
    foreach (var motherboard in infopocitace.MotherboardList)
        Console.WriteLine(motherboard);
}
if (fruit == "RAM")
{
    foreach (var memory in infopocitace.MemoryList)
        Console.WriteLine(memory);
}
if( fruit == "GPU")
{
    foreach (var videoController in infopocitace.VideoControllerList)
        Console.WriteLine(videoController);
}