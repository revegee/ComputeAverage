using System;
using System.IO;
public class ComputerAverageProgram
{
  public static void Main()
  {
      Console.WriteLine("Enter the 5 grades separated by new line \n");
     double number1,number2,number3,number4, number5;
      
     Console.Write("First number: ");
     number1 = Convert.ToDouble(Console.ReadLine());
 
     Console.Write("Second number: ");
     number2 = Convert.ToDouble(Console.ReadLine());
 
     Console.Write("Third number: ");
     number3 = Convert.ToDouble(Console.ReadLine());
 
     Console.Write("Fourth number: ");
     number4 = Convert.ToDouble(Console.ReadLine());
	 
	 Console.Write("Fifth number: ");
     number5 = Convert.ToDouble(Console.ReadLine());
 
     double result = (number1 + number2 + number3 + number4 + number5) / 5;
     Console.WriteLine("The average of {0}, {1}, {2}, {3}, {4} is {5} ",
  number1, number2, number3, number4, number5, result + " and round off to " + (Convert.ToInt32(result)), "\n");
  
  Console.WriteLine("Press any key to exit...");
   }
}