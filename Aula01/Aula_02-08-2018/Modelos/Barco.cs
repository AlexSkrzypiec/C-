using System;

namespace Aula_02_08_2018.Modelos
{
    class Barco : Veiculo, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("REMOS!!!...");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("ANCORAAAA!!...");
            Velocidade -= 3;
        }
    }
}
