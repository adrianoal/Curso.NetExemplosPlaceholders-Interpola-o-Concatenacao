using System;
using System.Globalization;

namespace ImprimirSaidaPadraoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bom dia!");
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");

            Console.WriteLine("--------------------");
            Console.WriteLine();

            Console.WriteLine("Imprimindo conteúdo de variáveis");
            Console.WriteLine();

            // Declaração de variaveis:
            char genero = 'F';
            int idade = 32;
            double saldo = 10.35784;
            string nome = "Maria";
            Console.WriteLine();


            // Impressão de variaveis:

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo);
            Console.WriteLine(nome);
            Console.WriteLine();

            Console.WriteLine("saldo.ToString (F2)  Para limitar duas casas decimais:");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine();

            Console.WriteLine("using System.Globalization --> CultureInfo.InvariantCulture: Para substituir , por .");
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();




            idade = 32;
            saldo = 10.35784;
            nome = "Maria";

            // Placeholders de String                      
            Console.WriteLine("{0} tem {1} anos e tem saldo igual a R$ {2} reais", nome, idade, saldo.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine();

            // Interpolação de String
            Console.WriteLine($"{nome} tem {idade} anos e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais");
            Console.WriteLine();

            // Concatenação de String
            Console.WriteLine(nome + " tem " + idade + " anos e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            Console.WriteLine();



        }
    }
}
