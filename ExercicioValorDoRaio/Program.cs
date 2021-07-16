using System;
using System.Globalization;

namespace ExercicioValorDoRaio
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcEsfera esfera = new CalcEsfera();

            Console.Write("Entre o valor do raio: ");
            esfera.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nCircunferência: " + esfera.Circunferencia().ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("\nVolume: " + esfera.Volume().ToString("F2", CultureInfo.InvariantCulture));
            Console.Write("\nValor de PI: " + esfera.PI.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
/*
 Fazer um programa para ler um valor numérico qualquer, e daí mostrar quanto seria o valor de uma
circuferência e do volume de uma esfera para um raio daquele valor. Informar também o valor de PI
com duas casas decimais.

Exemplo:

Digite o valor do raio: 3.0
Cirfunferência: 18.84
Volume: 113.04
Valor de PI: 3.14
 */