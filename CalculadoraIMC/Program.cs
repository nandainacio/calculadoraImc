using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********** CALCULADORA IMC **********");

            Console.WriteLine("Digite o seu nome: ");
            Pessoa pessoa = new Pessoa();
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu peso: ");
            pessoa.Peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sua altura: ");
            pessoa.Altura = double.Parse(Console.ReadLine());
            double resultadoImc = pessoa.Resultado();

            Console.WriteLine("********** RESULTADO ********** ");
            Console.WriteLine("Nome: " + pessoa.Nome);
            Console.WriteLine("Peso: " + pessoa.Peso);
            Console.WriteLine("Altura: " + pessoa.Altura);
            Console.WriteLine("IMC: " + Math.Round(resultadoImc, 2));
            Console.ReadLine();
        }
    }
}
