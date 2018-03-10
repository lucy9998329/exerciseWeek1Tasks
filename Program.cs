using System;

namespace exerciseWeek1Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
            //Task1 - Create an app that displays "Hello World" in the console and requires a user to type in a key before the program ends.            
            //Console.WriteLine("Hello World!");


            //Task2 - Write a console application to store the numbers 74 & 36, add them together and display the sum of them on the screen. (i.e. 74 + 36 = 110)
            /*var int1 = 74;
            var int2 = 36;
            Console.WriteLine($"{int1} + {int2} = {int1 + int2}");*/

            
            //Task3 - Write a console application that takes two numbers as input from the user and displays the product of the two numbers (i.e. 2 x 4 = 8)
            /*Console.Write("Please enter in the first number: ");
            int num1;
            int num2;
            string answer = "";
            if (int.TryParse(Console.ReadLine(), out num1))
            {
                answer += $"{num1}";
            }
            Console.Write("Please enter in the first number: ");
            if (int.TryParse(Console.ReadLine(), out num2))
            {
                answer += $"{num2}";
            }
            Console.WriteLine($"{num1} x {num2} = {num1 * num2}");*/


            //Task4 - Write a console application that accepts the users first name and last name and then greets them by their full name.
            /*var answer = "";
            Console.Write("Please enter in the first name: ");
            var firstName = Console.ReadLine();
            Console.Write("Please enter in the last name: ");
            var lastName = Console.ReadLine();
            Console.WriteLine(answer += $"{firstName} {lastName}");*/


            //Task5 -Write a console application that asks the user for a number between 1 and 12 and shows the times tables for that number. HINT: Use a loop. (i.e. 8 x 1 = 8 8 x 2 = 16 b&..)
            /*Console.Write("Please enter in a number between 1 and 12 to see the time table: ");
            var userInput = Console.ReadLine();
            int number;
            string answer = "";
            if (int.TryParse(userInput, out number))
            {
                for (var i = 0; i < 12; i++) {
                    var a = i + 1;
                    answer += $"{number} x {a} = {number * a}\n";
                }
                
            }
            Console.WriteLine(answer);*/


            //Task6 - Write a console application that asks the user to enter two numbers, num1 and num2, then swap the two variables and display back to the screen. 
            //(i.e. test data: Enter num1: 8 Enter num2: 5, Expected output: num1 is 5 num2 is 8) 
            /*int num1;
            int num2;
            string answer = "";
            Console.Write("Please enter in a number: ");
            var userInput = Console.ReadLine();
            if (int.TryParse(username, out num1))
            {
                Console.WriteLine(answer += $"{num2}");
            }*/
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            
        }
    }
}
