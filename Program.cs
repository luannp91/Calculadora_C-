using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            System.Console.Write("Digite o primeiro número: ");
            double num1 = Double.Parse(Console.ReadLine());

            System.Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            System.Console.Write("Escolha a operação (+ - * /): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    System.Console.WriteLine("Erro, opção inválida!!!");
                    break;
                case '+':
                    resultado = num1 + num2;
                    System.Console.WriteLine("O resultado da soma é: " + resultado);
                    break;
                case '-':
                    resultado = num1 - num2;
                    System.Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;
                case '*':
                    resultado = num1 * num2;
                    System.Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        System.Console.WriteLine("Não é possivel dividir por 0!!!");
                    }
                    else
                    {
                        resultado = num1 / num2;
                        System.Console.WriteLine("O resultado da divisão é: " + resultado);  
                    }                    
                    break;
            }

            System.Console.Write("Continuar calculando (s / n)? ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }
        }
    }
}