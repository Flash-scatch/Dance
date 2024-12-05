public class OrdinaryCalc : AbstractCalc
{
    // Конструктор
    public OrdinaryCalc(string model) : base(model) { }

    // Реалізація арифметичних операцій
    public override double Add(double operand1, double operand2) => operand1 + operand2;
    public override double Subtract(double operand1, double operand2) => operand1 - operand2;
    public override double Multiply(double operand1, double operand2) => operand1 * operand2;

    public override double Divide(double operand1, double operand2)
    {
        if (operand2 == 0)
            throw new DivideByZeroException("Ділення на нуль заборонено.");
        return operand1 / operand2;
    }
}
