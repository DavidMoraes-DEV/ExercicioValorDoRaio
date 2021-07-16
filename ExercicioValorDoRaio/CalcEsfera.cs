using System;

namespace ExercicioValorDoRaio
{
    class CalcEsfera
    {
        public double Raio;
        public double PI = 3.14;

        public double Circunferencia()
        {
            return 2 * PI * Raio;    
        }

        public double Volume ()
        {
            return 4 * PI * Math.Pow(Raio, 3) / 3;
        }
    }
}
