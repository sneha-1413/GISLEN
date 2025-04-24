using System;

class Program
{
    static void Main()
    {

        Console.Write("How many numbers do you want to enter? ");
        int count = Convert.ToInt32(Console.ReadLine());


        int[] numbers = new int[count];


        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("\nChoose an operation:");
        Console.WriteLine("1. Sum");
        Console.WriteLine("2. Subtraction");
        Console.WriteLine("3. Multiplication");
        Console.WriteLine("4. Division");
        Console.Write("Enter your choice (1-4): ");
        int choice = Convert.ToInt32(Console.ReadLine());


        int result = numbers[0];


        switch (choice)
        {
            case 1:
                for (int i = 1; i < count; i++)
                {
                    result += numbers[i];
                }
                Console.WriteLine($"Result (Sum): {result}");
                break;

            case 2:
                for (int i = 1; i < count; i++)
                {
                    result -= numbers[i];
                }
                Console.WriteLine($"Result (Subtraction): {result}");
                break;

            case 3:
                for (int i = 1; i < count; i++)
                {
                    result *= numbers[i];
                }
                Console.WriteLine($"Result (Multiplication): {result}");
                break;

            case 4:
                for (int i = 1; i < count; i++)
                {
                    if (numbers[i] == 0)
                    {
                        Console.WriteLine("Error: Division by zero detected!");
                        return;
                    }
                    result /= numbers[i];
                }

                Console.WriteLine($"Result (Division): {result}");
                break;

            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
