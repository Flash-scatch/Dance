using System;

public class MainClass
{
    public static void Main()
    {
        AbstractCalc standardCalculator = new OrdinaryCalc("Standard Calculator");
        IAdvanced advancedCalculator = new AdvancedCalc("Scientific Calculator");
        string mode;
        string exitCommand = "exit";

        do
        {
            Console.WriteLine("Оберіть режим роботи (standard/scientific):");
            mode = Console.ReadLine()?.ToLower();

            try
            {
                if (mode == "standard")
                {
                    Console.WriteLine("Введіть перше число:");
                    double operand1 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Введіть друге число:");
                    double operand2 = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Оберіть операцію (+, -, *, /):");
                    string operation = Console.ReadLine();

                    double result = operation switch
                    {
                        "+" => standardCalculator.Add(operand1, operand2),
                        "-" => standardCalculator.Subtract(operand1, operand2),
                        "*" => standardCalculator.Multiply(operand1, operand2),
                        "/" => standardCalculator.Divide(operand1, operand2),
                        _ => throw new InvalidOperationException("Невідома операція.")
                    };

                    Console.WriteLine($"Результат: {result}");
                }
                else if (mode == "scientific")
                {
                    Console.WriteLine("Введіть значення для exp(a) (-5 <= a <= 5):");
                    double a = Convert.ToDouble(Console.ReadLine());

                    double result = advancedCalculator.Exp(a);
                    Console.WriteLine($"Результат: {result}");
                }
                else
                {
                    Console.WriteLine("Невідомий режим.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Помилка: {ex.Message}");
            }

            Console.WriteLine($"Щоб завершити програму, введіть \"{exitCommand}\". Щоб продовжити, натисніть Enter.");
        } while (Console.ReadLine()?.ToLower() != exitCommand);
    }
}
