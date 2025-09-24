using System;

class CalculadoraSimples
{
    static void Main()
    {
        double num1, num2, resultado;
        char operacao;

        Console.WriteLine("Calculadora Simples");

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /): ");
        operacao = Convert.ToChar(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        switch (operacao)
        {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                break;

            case '-':
                resultado = num1 - num2;
                Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                break;

            case '*':
                resultado = num1 * num2;
                Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                break;

            case '/':
                if (num2 != 0)
                {
                    resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                }
                else
                {
                    Console.WriteLine("Erro: Divisão por zero não é permitida.");
                }
                break;

            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}

