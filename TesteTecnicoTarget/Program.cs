using System;

public class Program
{
    public static void Main(String[] args)
    {
        string teste1 = Teste1();
        Console.WriteLine(teste1);

        string teste2 = Teste2();
        Console.WriteLine(teste2);


    }


    public static string Teste1()
    {
        string resultado = string.Empty;
        Console.Write("Informe um número: ");
        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            resultado = PertenceFibonacci(numero);
            
        }
        return resultado;
    }

    public static string PertenceFibonacci(int numero)
    {
        int a = 0;
        int b = 1;

        while (b <= numero)
        {
            if (b == numero)
            {
                return $"O número {numero} pertence à sequência de Fibonacci.";
            }
            int temp = a;
            a = b;
            b = temp + b;
        }
        return $"O número {numero} não pertence à sequência de Fibonacci.";
    }


    public static string Teste2()
    {
        string resultado = string.Empty;
        Console.Write("Informe uma frase: ");
        string entrada = Console.ReadLine();

        int contador = ContaOcorrenciasDeA(entrada);

        if (contador > 0)
        {
            resultado = $"A letra 'a' aparece {contador} vez(es) na string.";
            return resultado;
        }
        else
        {
            resultado = "A letra 'a' não aparece na string.";
            return resultado;
        }

    }


    public static int ContaOcorrenciasDeA(string texto)
    {
        int contador = 0;

        foreach (char c in texto)
        {
            if (c == 'a' || c == 'A')
            {
                contador++;
            }
        }

        return contador;
    }


    public static string Teste3() 
    {
        return null;
    }
}
