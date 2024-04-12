using System;

namespace RecipeApplication
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
                switch (choice)
                {
                    case 1:
                        recipe.EnterDetails();
                        break;
                    case 2:
                        recipe.DisplayRecipe();
                        break;
                    case 3:
                        recipe.ScaleRecipe();
                        break;
                    case 4:
                        recipe.ResetQuantities();
                        break;
                    case 5:
                        recipe.ClearData();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                        break;
                }
        class Recipe
        {
            private string[] ingredients;
            private double[] quantities;
            private string[] units;
            private string[] steps;
            public void EnterDetails()
            {
                Console.WriteLine("Enter the number of ingredients:");
                int numIngredients;
                if (!int.TryParse(Console.ReadLine(), out numIngredients) || numIngredients <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    return;
                }
                ingredients = new string[numIngredients];
                quantities = new double[numIngredients];
                units = new string[numIngredients];
                for (int i = 0; i < numIngredients; i++)
                {
                    Console.WriteLine($"Enter the name of ingredient {i + 1}:");
                    ingredients[i] = Console.ReadLine();

                    Console.WriteLine($"Enter the quantity of {ingredients[i]}:");
                    double quantity;
                    if (!double.TryParse(Console.ReadLine(), out quantity) || quantity <= 0)
                    {
                        Console.WriteLine("Invalid input. Please enter a positive number.");
                        return;
                    }
                    quantities[i] = quantity;

                    Console.WriteLine($"Enter the unit of measurement for {ingredients[i]}:");
                    units[i] = Console.ReadLine();
                }
                Console.WriteLine("Enter the number of steps:");
                int numSteps;
                if (!int.TryParse(Console.ReadLine(), out numSteps) || numSteps <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a positive integer.");
                    return;
                }
                steps = new string[numSteps];

                for (int i = 0; i < numSteps; i++)
                {
                    Console.WriteLine($"Enter step {i + 1}:");
                    steps[i] = Console.ReadLine();
                }











