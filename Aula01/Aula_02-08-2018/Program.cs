using Aula_02_08_2018.Modelos;
using System;

namespace Aula_02_08_2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
   
            car.Ano = 2012;
            car.Modelo = "Ferrari";
            car.Placa = "AWE-7379";
            car.Acelerar();

            ExecutaTesteMotor(car);

            Console.ReadKey();
        }

        static void ExecutaTesteMotor(IMotorizado vec)
        {

            Console.WriteLine("Velocidade atual:" + vec.Velocidade);
            vec.Acelerar();
            vec.Acelerar();
            vec.Acelerar();
            Console.WriteLine("Velocidade atual:" + vec.Velocidade);
            vec.Frenar();
            vec.Frenar();
            Console.WriteLine("Velocidade atual:" + vec.Velocidade);

        }
    }
}