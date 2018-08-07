using System;

namespace Aula_02_08_2018.Modelos
{
    class Moto : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Pisando no pedal...");
            Velocidade += 5;

        }
        public void Frenar()
        {
            Console.WriteLine("Pisando no pedal(freio)...");
            Velocidade -= 3;

        }
    }
}
