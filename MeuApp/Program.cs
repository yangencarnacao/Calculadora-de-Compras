using System;
namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {

            Console.WriteLine("Olá! Escolha uma das opções: ");
            Console.WriteLine("1 - SOMAR");
            System.Console.WriteLine("2 - SUBTRAIR");
            System.Console.WriteLine("3 - MULTIPLICAR");
            System.Console.WriteLine("4 - DIVIDIR");
            Console.WriteLine("0 - SAIR");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Multiplicacao(); break;
                case 4: Divisao(); break;
                case 0: System.Environment.Exit(0); break;
                default: Menu(); break;
            }



        }

        static void Soma()
        {
            Console.Clear();
            Console.WriteLine("Valor do produto: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Valor do 2º produto: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            float total = v1 + v2;

            Console.WriteLine($"Valor total dos produtos: {total} reais");
            System.Console.ReadKey();
            Menu();
        }

        static void Subtracao()
        {
            Console.Clear();
            System.Console.WriteLine("Digite o valor do produto: ");
            float v1 = float.Parse(System.Console.ReadLine());

            System.Console.WriteLine("");
            System.Console.WriteLine("Digite o valor do desconto: ");
            float v2 = float.Parse(System.Console.ReadLine());

            float sub = v1 - v2;

            System.Console.WriteLine($"O valor total do produto é {sub} reais ");
            System.Console.ReadKey();
            Menu();
        }

        static void Divisao()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do produto: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("Deseja parcelar em quantas vezes? ");
            float parcelas = float.Parse(Console.ReadLine());
            float div = v1 / parcelas;

            Console.WriteLine($"Valor total: {div} reais em {parcelas} parcelas");
            Console.ReadKey();
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();
            Console.WriteLine("Digite o valor do produto: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Digite quantos produtos deseja levar: ");
            float qtde = float.Parse(Console.ReadLine());

            float multi = v1 * qtde;

            Console.WriteLine($"O total a pagar é de {multi} reais em {qtde} produtos");
            Console.ReadKey();
            Menu();
        }

        static void Sair()
        {
            Console.Clear();
            Console.WriteLine("OBRIGADO POR COMPRAR AQUI! VOLTE SEMPRE!");
        }

    }
}
