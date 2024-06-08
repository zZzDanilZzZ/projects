using System;

public class Program
{
    static void Main()
    {
        string input = "3 4 + 2 * 7 /";
        double result = EvaluateRPN(input);
        Console.WriteLine($"Result: {result}");
    }

    static double EvaluateRPN(string input)
    {
        MyStack stack = new MyStack();
        string[] tokens = input.Split(' ');

        foreach (string token in tokens)
        {
            if (double.TryParse(token, out double number))
            {
                stack.Push(number);
            }
            else
            {
                double operand2 = stack.Pop();
                double operand1 = stack.Pop();
                double result = 0;

                switch (token)
                {
                    case "+":
                        result = operand1 + operand2;
                        break;
                    case "-":
                        result = operand1 - operand2;
                        break;
                    case "*":
                        result = operand1 * operand2;
                        break;
                    case "/":
                        result = operand1 / operand2;
                        break;
                    default:
                        throw new Exception("Invalid operator");
                }
                stack.Push(result);
            }
        }

        return stack.Pop();
    }
}
