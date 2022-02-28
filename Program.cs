using System;

namespace ProjetoCalculadoraPetuly
{
    class Program
    {
        private static int opcao;

        static void Main(string[] args)
        {
            Opcoes();
        }

        static void Opcoes()
        {
            Console.WriteLine("Selecione uma das opcoes a seguir: ");
            Console.WriteLine("(1) Adicao");
            Console.WriteLine("(2) Subtracao");
            Console.WriteLine("(3) Divisao");
            Console.WriteLine("(4) Multiplicacao");
            Console.WriteLine("(5) Sair");
            Console.Write("--> ");

            opcao = int.Parse(Console.ReadLine());

            switch(opcao)
            {
                case 1: Adicao();
                    break;
                case 2: Subtracao();
                    break;
                case 3: Divisao();
                    break;
                case 4: Multiplicacao();
                    break;

                default:
                    Console.WriteLine("Encerrar calculadora");
                    break;
            } 
        }

        static void Adicao()
        {
            Console.WriteLine("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = n1 + n2;

            Console.WriteLine($"O resultado da adicao e: {resultado}");
            Console.ReadKey();
            Opcoes();
        }

        static void Subtracao()
        {
            Console.WriteLine("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = n1 - n2;

            Console.WriteLine($"O resultado da subtracao e: {resultado}");
            Console.ReadKey();
            Opcoes();
        }

        static void Divisao()
        {
            Console.WriteLine("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = n1 / n2;

            Console.WriteLine($"O resultado da divisao e: {resultado}");
            Console.ReadKey();
            Opcoes();
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Insira o primeiro numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            double resultado = n1 * n2;

            Console.WriteLine($"O resultado da multiplicacao e: {resultado}");
            Console.ReadKey();
            Opcoes();
        }
    }
}
