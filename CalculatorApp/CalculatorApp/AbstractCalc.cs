using System;

public abstract class AbstractCalc
{
    // Поле - модель калькулятора
    private readonly string model;

    // Конструктор
    protected AbstractCalc(string model)
    {
        this.model = model;
    }

    // Метод для отримання поточного значення поля
    public string GetModel() => model;

    // Абстрактні методи для арифметичних операцій
    public abstract double Add(double operand1, double operand2);
    public abstract double Subtract(double operand1, double operand2);
    public abstract double Multiply(double operand1, double operand2);
    public abstract double Divide(double operand1, double operand2);
}