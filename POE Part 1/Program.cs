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
                Console.WriteLine("1. Enter recipe details");
                Console.WriteLine("2. Display recipe");
                Console.WriteLine("3. Scale recipe");
                Console.WriteLine("4. Reset quantities");
                Console.WriteLine("5. Clear all data");
                Console.WriteLine("6. Exit");

