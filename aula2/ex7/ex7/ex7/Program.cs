using System;
public class Program
{
    public static void Main()
    {
        double Result, Number1, Number2;

        Number1 = 3;
        Number2 = 5;

        Result = Math.Pow(Number1, Number2);
        Console.WriteLine(Result);

        double raiz_quadrada = Math.Sqrt(125);

        Console.WriteLine("Resultado raiz quadrada: " + raiz_quadrada);

        double number3 = 34.55;

        Console.WriteLine("Numero Arredondado: " + Math.Round(number3, 0));

        double seno = Math.Sin(30*Math.PI/180);
        Console.WriteLine("Valor do seno: " +  Math.Round(seno, 1));
    }
}