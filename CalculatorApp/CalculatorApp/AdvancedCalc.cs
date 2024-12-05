using System;

public class AdvancedCalc : OrdinaryCalc, IAdvanced
{
    // Конструктор
    public AdvancedCalc(string model) : base(model) { }

    // Реалізація додаткової операції exp(a)
    public double Exp(double a)
    {
        if (a < -5 || a > 5)
            throw new ArgumentOutOfRangeException(nameof(a), "Значення a повинно бути в межах від -5 до 5.");
        return Math.Exp(a);
    }
}
