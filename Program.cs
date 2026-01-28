using System;
using System.Threading;


public class Program
{
    
    public static void SystemInfo()
    {
        Console.Clear();
        string info = "System Info "
                    + "\nVersion system: " + Environment.OSVersion
                    + "\nVersion Microsoft .NET Framework: " + Environment.Version 
                    + "\nComputer name: " + Environment.MachineName           
                    + "\nSystem Directory: " + Environment.SystemDirectory;

        Console.WriteLine(info);
        Console.WriteLine("\n[To continue press a button...]");
        Console.ReadKey();
    }

    public static void Main(string[] args)
    {
        ConsoleKeyInfo key1;

        while (true)
        {
            Console.Clear();
            Console.WriteLine("----------------Main Menu ----------------");
            Console.WriteLine(" <Up>-System Info");
            Console.WriteLine(" <Down>-Student Info");
            Console.WriteLine(" <Right>-Trip Calculator");
            Console.WriteLine(" <Esc>-Escape");
            Console.WriteLine("------------------------------------------");

            key1 = Console.ReadKey(true);

            switch (key1.Key)
            {
                case ConsoleKey.UpArrow:
                    SystemInfo();
                    break;
                case ConsoleKey.DownArrow:
                    StudentTools.StudentInfo(); 
                    break;
                case ConsoleKey.RightArrow:
                    TripCalculator.TripCalc(); 
                    break;
                case ConsoleKey.Escape:
                    Console.WriteLine("\nExit program...");
                    return;
                default:
                    break;
            }
        }
    }
}

public class StudentTools
{
   
    public static void StudentInfo()
    {
        Console.Clear();
        Console.Write("What is your name? ");
        string name = Console.ReadLine();

        Console.Write("What is your year of birthday? ");

        try
        {
        
            int s_year = Convert.ToInt32(Console.ReadLine());

            
            int difference = DateTime.Today.Year - s_year;

          
            Console.WriteLine($"\nStudent: {name} is {difference} years old!");
        }
        catch (FormatException)
        {
            Console.WriteLine("\nERROR: Please enter a valid numerical year for your birthday.");
        }

        Console.WriteLine("\n[To continue press a button...]");
        Console.ReadKey();
    }
}