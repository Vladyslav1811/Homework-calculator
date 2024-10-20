class Programm
{
    static void Main(string[] args)
    {
        double num1, num2;
        string operation;
        while (true)
        {
            Console.WriteLine("Write your first number: ");
            try
            {
                num1 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("No letters");
                continue;
            }
            Console.WriteLine("Write second number: ");
            try
            {
                num2 = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("No letters");
                continue;
            }
            Console.WriteLine("Write your operation (+,-,*,/,): ");
            operation = Console.ReadLine();

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"answer{num1} + {num2} = {num1 + num2}");
                    break;
                case "-":
                    Console.WriteLine($"answer{num1} - {num2} = {num1 - num2}");
                    break;
                case "*":
                    Console.WriteLine($"answer{num1} * {num2} = {num1 * num2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("ERROR");
                    }
                    else
                    {
                        Console.WriteLine($"answer{num1} / {num2} = {num1 / num2}");
                    }
                    break;

                default:
                    Console.WriteLine("Wrong operation");
                    break;
            }
        }
    }
}
