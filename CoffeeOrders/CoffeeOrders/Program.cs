namespace CoffeeShop;

internal class Program
{
    // Coffee price list stored in a dictionary
    static readonly Dictionary<string, decimal> CoffeePrices = new()
    {
        { "espresso", 8m },
        { "latte", 12m },
        { "cappuccino", 10m }
    };

    static void Main(string[] args)
    {
        Console.WriteLine("=== COFFEE SHOP ORDER SYSTEM ===");

        try
        {
            // TODO 1:
            // Ask user for coffee type using a method with validation.
            string coffeeType = ReadCoffeeType();

            // TODO 2:
            // Ask for quantity using a safe parsing method with exceptions.
            int quantity = ReadPositiveInt("Enter number of cups: ");

            // TODO 3:
            // Calculate price based on dictionary lookup.
            decimal total = CalculatePrice(coffeeType, quantity);

            Console.WriteLine("\nOrder summary:");
            Console.WriteLine($"- Coffee: {coffeeType}");
            Console.WriteLine($"- Quantity: {quantity}");
            Console.WriteLine($"Total price: {total} PLN");
        }
        catch (Exception ex)
        {
            // Friendly error message for any invalid operation
            Console.WriteLine($"\nError: {ex.Message}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }

    // ================================
    // METHODS TO IMPLEMENT
    // ================================

    // ReadCoffeeType()
    // - Show available types from the dictionary
    // - Normalize input
    // - Validate using dictionary lookup
    // - On invalid -> throw ArgumentException
    static string ReadCoffeeType()
    {
        return ""; // TODO: implement
    }

    // ReadPositiveInt(message)
    // - Ask for input
    // - Use int.Parse inside try/catch
    // - Throw exceptions for invalid or non-positive values
    static int ReadPositiveInt(string message)
    {
        return 0; // TODO: implement
    }

    // CalculatePrice(type, quantity)
    // - Lookup price in dictionary (CoffeePrices[type])
    // - Multiply by quantity
    // - If type missing -> throw exception
    static decimal CalculatePrice(string type, int quantity)
    {
        return 0; // TODO: implement
    }
}