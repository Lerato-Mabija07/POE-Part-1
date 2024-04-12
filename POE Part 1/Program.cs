using System;

namespace RecipeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Recipe recipe = new Recipe();
            while (true)
            {
                Console.WriteLine("1. Enter the details of the recipe");
                Console.WriteLine("2. Display the recipe");
                Console.WriteLine("3. Scale the recipe");
                Console.WriteLine("4. Reset the quantities");
                Console.WriteLine("5. Clear all the data");
                Console.WriteLine("6. Exit the Application");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 6.");
                    continue;
                }


