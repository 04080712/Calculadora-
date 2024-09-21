using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            double num1 = GetNumber("Enter a number: ");
            double num2 = GetNumber("Enter another number: ");

            string op = GetOperator();

            PerformOperation(num1, num2, op);

            if (!AskToReturn())
            {
                DisplayThankYouMessage();
                break;
            }
        }
    }

    static double GetNumber(string prompt)
    {
        double number;
        while (true)
        {
            Console.WriteLine(prompt);
            if (double.TryParse(Console.ReadLine(), out number))
                break;

            Console.WriteLine("Invalid input. Please enter a valid number.");
        }
        return number;
    }

    static string GetOperator()
    {
        Console.WriteLine("Enter an operator (+, -, *, /, ^, sqrt) or 'help' for assistance: ");
        return Console.ReadLine().ToLower().Trim();
    }

    static void PerformOperation(double num1, double num2, string op)
    {
        switch (op)
        {
            case "+":
                Console.WriteLine($"Result: {num1 + num2}");
                break;
            case "-":
                Console.WriteLine($"Result: {num1 - num2}");
                break;
            case "*":
                Console.WriteLine($"Result: {num1 * num2}");
                break;
            case "/":
                if (num2 != 0)
                    Console.WriteLine($"Result: {num1 / num2}");
                else
                    Console.WriteLine("Cannot divide by zero.");
                break;
            case "^":
                Console.WriteLine($"Result: {Math.Pow(num1, num2)}");
                break;
            case "sqrt":
                Console.WriteLine($"Square root of {num1}: {Math.Sqrt(num1)}");
                break;
            case "help":
                DisplayHelp();
                break;
            default:
                Console.WriteLine("Invalid operator.");
                break;
        }
    }

    static void DisplayHelp()
    {
        Console.WriteLine("The options for operation:");
        Console.WriteLine("+ for addition");
        Console.WriteLine("- for subtraction");
        Console.WriteLine("* for multiplication");
        Console.WriteLine("/ for division");
        Console.WriteLine("^ for exponentiation");
        Console.WriteLine("sqrt for square root");
    }

    static bool AskToReturn()
    {
        Console.WriteLine("Do you want to perform another operation? (S/N): ");
        return Console.ReadLine().Trim().ToLower() == "s";
    }

    static void DisplayThankYouMessage()
    {
        Console.WriteLine("░░░░░░░░░░░░░░░░░░░░░░░░░░░░░");
        Console.WriteLine("░░░░░░░░░░░░░▄▄▄▄▄▄▄░░░░░░░░░");
        Console.WriteLine("░░░░░░░░░▄▀▀▀░░░░░░░▀▄░░░░░░░");
        Console.WriteLine("░░░░░░░▄▀░░░░░░░░░░░░▀▄░░░░░░");
        Console.WriteLine("░░░░░░▄▀░░░░░░░░░░▄▀▀▄▀▄░░░░░");
        Console.WriteLine("░░░░▄▀░░░░░░░░░░▄▀░░██▄▀▄░░░░");
        Console.WriteLine("░░░▄▀░░▄▀▀▀▄░░░░█░░░▀▀░█▀▄░░░");
        Console.WriteLine("░░░█░░█▄▄░░░█░░░▀▄░░░░░▐░█░░░");
        Console.WriteLine("░░▐▌░░█▀▀░░▄▀░░░░░▀▄▄▄▄▀░░█░░");
        Console.WriteLine("░░▐▌░░█░░░▄▀░░░░░░░░░░░░░░█░░");
        Console.WriteLine("░░▐▌░░░▀▀▀░░░░░░░░░░░░░░░░▐▌░");
        Console.WriteLine("░░▐▌░░░░░░░░░░░░░░░▄░░░░░░▐▌░");
        Console.WriteLine("░░▐▌░░░░░░░░░▄░░░░░█░░░░░░▐▌░");
        Console.WriteLine("░░░█░░░░░░░░░▀█▄░░▄█░░░░░░▐▌░");
        Console.WriteLine("░░░▐▌░░░░░░░░░░▀▀▀▀░░░░░░░▐▌░");
        Console.WriteLine("░░░░█░░░░░░░░░░░░░░░░░░░░░█░░");
        Console.WriteLine("░░░░▐▌▀▄░░░░░░░░░░░░░░░░░▐▌░░");
        Console.WriteLine("░░░░░█░░▀░░░░░░░░░░░░░░░░░▀░░");
        Console.WriteLine("Thank you for using the calculator.");
        Console.WriteLine("By João Lucas");
    }
}
