using System;

namespace Manager;

internal static class Program
{
    public static void Main(string[] args)
    {
        try
        {
            new Application().Run();
        }
        catch(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.ToString());
            Console.ResetColor();
        }
    }
}
