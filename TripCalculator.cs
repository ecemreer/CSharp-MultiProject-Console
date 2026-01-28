using System;

public class TripCalculator
{
   
    public static void TripCalc()
    {
        Console.Clear();
        Console.WriteLine("--- Calculate Travel Expenses ---");

        try
        {
            
            Console.Write("Trip distance (km): ");
            decimal distance = Convert.ToDecimal(Console.ReadLine());

           
            Console.Write("Fuel consumption per 100km (L): ");
            decimal consumption_per_100km = Convert.ToDecimal(Console.ReadLine());

            
            Console.Write("Petrol price (per L): ");
            decimal price_per_liter = Convert.ToDecimal(Console.ReadLine());

           
            decimal total_cost = (distance / 100m) * consumption_per_100km * price_per_liter;

            Console.WriteLine($"\nTotal trip expense: {total_cost:C2}"); 
        }
        catch (FormatException)
        {
           
            Console.WriteLine("\nERROR: Please enter numeric values for distance, consumption, and price.");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"\nAn unexpected error occurred: {ex.Message}");
        }

        Console.WriteLine("\n[To continue press a button...]");
        Console.ReadKey();
    }
}