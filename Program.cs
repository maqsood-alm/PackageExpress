using System;

class Program
{
static void Main()
{
// Display welcome message
Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

// Ask for package weight
Console.WriteLine("Please enter the package weight:");
decimal weight = Convert.ToDecimal(Console.ReadLine());

// Check if weight exceeds limit
if (weight > 50)
{
Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day!");
return; // Ends the program
}

// Ask for package width
Console.WriteLine("Please enter the package width:");
decimal width = Convert.ToDecimal(Console.ReadLine());

// Ask for package height
Console.WriteLine("Please enter the package height:");
decimal height = Convert.ToDecimal(Console.ReadLine());

// Ask for package length
Console.WriteLine("Please enter the package length:");
decimal length = Convert.ToDecimal(Console.ReadLine());

// Calculate total dimensions
decimal dimensionTotal = width + height + length;

// Check if dimensions exceed limit
if (dimensionTotal > 50)
{
Console.WriteLine("Package too big to be shipped via Package Express.");
return; // Ends the program
}

// Calculate shipping quote
decimal quote = (width * height * length * weight) / 100;

// Display result formatted as currency
Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

// Thank the user
Console.WriteLine("Thank you!");
}
}