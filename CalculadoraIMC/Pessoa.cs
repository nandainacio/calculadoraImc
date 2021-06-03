using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraIMC
{
    public class Pessoa 
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        public double Imc { get; set; }
        public string Nome { get; set; }

        public Pessoa(double peso, double altura)
        {
            Altura = altura;
            Peso = peso;

        }
        public Pessoa(double imc)
        {
            Imc = imc;

        }

        public Pessoa()
        {

        }
        public double Resultado()
        {

            var Imc = Peso / (Altura * Altura);
            return Imc;
        }
    }

}
