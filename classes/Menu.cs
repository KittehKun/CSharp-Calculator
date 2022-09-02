// See https://aka.ms/new-console-template for more information
internal class Menu
{
    private readonly List<string> menu;
    private int firstNum;
    private int secondNum;

    public Menu()
    {
        menu = new List<string>();
        firstNum = 0;
        secondNum = 0;
        menu.Add("1. Add");
        menu.Add("2. Subtract");
        menu.Add("3. Multiply");
        menu.Add("4. Divide");
        menu.Add("\n0. Exit");
        SelectMenu();
    }

    private void SelectMenu()
    {
        DisplayMenu();
        bool isValidInput = int.TryParse(Console.ReadLine(), out int menuSelect);
        if(isValidInput)
        {
            Console.Clear();
            switch(menuSelect)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("Enter your first number:");
                    this.firstNum = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter your second number:");
                    this.secondNum = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"The total is: {Calculator.Add(firstNum, secondNum)}");
                    Environment.Exit(0);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Enter your first number:");
                    this.firstNum = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter your second number:");
                    this.secondNum = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"The total is: {Calculator.Subtract(firstNum, secondNum)}");
                    Environment.Exit(0);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Enter your first number:");
                    this.firstNum = int.Parse(Console.ReadLine()!);
                    Console.WriteLine("Enter your second number:");
                    this.secondNum = int.Parse(Console.ReadLine()!);
                    Console.WriteLine($"The product is: {Calculator.Multiply(firstNum, secondNum)}");
                    Environment.Exit(0);
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Enter your first number:");
                    this.firstNum = int.Parse(Console.ReadLine()!);
                    decimal doubleFNum = Convert.ToDecimal(this.firstNum);
                    Console.WriteLine("Enter your second number:");
                    this.secondNum = int.Parse(Console.ReadLine()!);
                    decimal doubleSNum = Convert.ToDecimal(this.secondNum);
                    Console.WriteLine($"The total is: {Calculator.Divide(doubleFNum, doubleSNum)}");
                    Environment.Exit(0);
                    break;
                case 0:
                    Console.Clear();
                    Console.WriteLine("Exiting program...");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Something went wrong! Exiting program.");
                    Environment.Exit(0);
                    break;
            }
        } else
        {
            Console.Clear();
            Console.WriteLine("ERROR: Invalid option selected.");
            SelectMenu();
        }
    }

    private void DisplayMenu()
    {
        Console.WriteLine("Select an option below:\n");
        foreach(string option in this.menu)
        {
            Console.WriteLine(option);
        }
    }
}