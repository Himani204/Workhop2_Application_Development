public partial class Calculator
{
    double num1;
    double num2;
    double result;

    void Add() => result = num1 + num2;
    void Subtract() => result = num1 - num2;
    void Multiply() => result = num1 * num2;
    void Divide() => result = num2 != 0 ? num1 / num2 : 0;
}
