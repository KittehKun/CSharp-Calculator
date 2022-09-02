// See https://aka.ms/new-console-template for more information
internal class Calculator
{

    public static int Add(int firstNum, int secondNum)
    {
        return firstNum + secondNum;
    }

    public static int Subtract(int firstNum, int secondNum)
    {
        return firstNum - secondNum;
    }

    public static double Multiply(int firstNum, int secondNum)
    {
        return firstNum * secondNum;
    }

    public static decimal Divide(decimal firstNum, decimal secondNum)
    {
        try
        {
            return firstNum/secondNum;
        } catch (Exception error)
        {
            Console.WriteLine($"{error.Message}\n");
            return 0;
        }
    }

}