// Figure 3.14: Addition.cs
// Displaying the sum of two numbers input from keyboard.

using System;

class Addition // Begins class Addition
{
   static void Main()  // Begins method Main
   {
      int number1; // Declare three simple variables of type integer
      int number2;
      int sum;

      Console.Write("Enter the first number: "); // Display user prompt
      number1 = int.Parse(Console.ReadLine()); //Read text from console and pass to method Parse belonging to the int type

      Console.Write("Enter the second number: "); // Display user prompt
      number2 = int.Parse(Console.ReadLine()); //Read text from console and pass to method Parse belonging to the int type

      sum = number1 + number2; // Add the two numbers and pass to int variable sum

      Console.WriteLine($"The sum is {sum}."); // Insert the value of sum into interpolated string
      // Can also just insert {number1 + number2} into the interpolation instead, and therefore won't need the variable sum

   }  // Ends method Main
} // Ends class Addition


//using System;

//class Addition
//{
//   static void Main()
//   {
//      int number1;
//      int number2;
//      int sum;

//      Console.Write("Please provide the first number: ");
//      number1 = int.Parse(Console.ReadLine());

//      Console.Write("Please provide the second number: ");
//      number2 = int.Parse(Console.ReadLine());

//      sum = number1 + number2;

//      Console.WriteLine($"The sum of the two numbers is {sum}.");
//   }
//}








//// Fig. 3.14: Addition.cs
//// Displaying the sum of two numbers input from the keyboard.
//using System;

//class Addition
//{
//   // Main method begins execution of C# app
//   static void Main()
//   {
//      int number1; // declare first number to add
//      int number2; // declare second number to add
//      int sum; // declare sum of number1 and number2

//      Console.Write("Enter first integer: "); // prompt user 
//      // read first number from user
//      number1 = int.Parse(Console.ReadLine());

//      Console.Write("Enter second integer: "); // prompt user
//      // read second number from user
//      number2 = int.Parse(Console.ReadLine());

//      sum = number1 + number2; // add numbers

//      Console.WriteLine($"Sum is {sum}"); // display sum
//   } // end Main
//} // end class Addition