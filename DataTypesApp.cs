using System;

public class DataTypesProgram
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the pieces of apple: ");
		int pieces;
		pieces = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the total price of apple(s): ");
		double price;
		price = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("The total price of " + pieces + " apple(s) is: " + price);
		Console.WriteLine("The value of original price is " + price);
		Console.WriteLine("The value of converted price is " + (Convert.ToInt64(price)), "\n");
		
		Console.Write("Press any key to exit...");
		Console.ReadKey();
    }
}