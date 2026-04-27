using System;

class Program
{
    // Delegate
    public delegate double Operacao(double a, double b);

    // Métodos
    static double Somar(double a, double b) => a + b;
    static double Subtrair(double a, double b) => a - b;
    static double Multiplicar(double a, double b) => a * b;
    static double Dividir(double a, double b) => b != 0 ? a / b : 0;

    static void Main()
    {
        Operacao op;

        op = Somar;
        Console.WriteLine("Soma: " + op(10, 5));

        op = Subtrair;
        Console.WriteLine("Subtração: " + op(10, 5));

        op = Multiplicar;
        Console.WriteLine("Multiplicação: " + op(10, 5));

        op = Dividir;
        Console.WriteLine("Divisão: " + op(10, 5));
    }
}