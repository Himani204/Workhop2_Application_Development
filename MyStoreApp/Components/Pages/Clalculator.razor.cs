using Microsoft.AspNetCore.Components;

public partial class Calculator
{
    protected double num1 = 0;
    protected double num2 = 0;
    protected double result = 0;

    protected void Add()
    {
        result = num1 + num2;
    }

    protected void Subtract()
    {
        result = num1 - num2;
    }

    protected void Multiply()
    {
        result = num1 * num2;
    }

    protected void Divide()
    {
        if (num2 != 0)
        {
            result = num1 / num2;
        }
    }
}
