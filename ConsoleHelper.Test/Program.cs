using ConsoleHelper.Lib;

TUI.PrintError("Test");
TUI.PrintInfo("Test");

var str = TUI.InputString("message: ");
TUI.PrintInfo($"message = {str}");

var num = TUI.InputInt("number: ");
TUI.PrintInfo($"number = {num}");

num = TUI.InputInt("number: ", TUI.PrintError);
TUI.PrintInfo($"number = {num}");

num = TUI.InputInt("number: ", msg =>
{
    Console.BackgroundColor = ConsoleColor.Yellow;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.WriteLine(msg);
    Console.ResetColor();
});
TUI.PrintInfo($"number = {num}");