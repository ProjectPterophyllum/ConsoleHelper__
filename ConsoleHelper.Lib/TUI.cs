namespace ConsoleHelper.Lib;

public static class TUI
{
    #region Print

    private static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine(message);
        Console.ResetColor();
    }
    public static void PrintError(string message)
    {
        Print(message, ConsoleColor.Red);
    }
    public static void PrintInfo(string message)
    {
        Print(message, ConsoleColor.Blue);
    }

    #endregion

    #region Input

    public static string InputString(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }
    public static int InputInt(string message, Action<string>? exceptionHandler = null)
    {
        do
        {
            try
            {
                Console.Write(message);
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                exceptionHandler?.Invoke("Неправильный ввод! Повторите.");
            }
        } while (true);
    }

    #endregion
    
}