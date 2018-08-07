namespace Aula_02_08_2018.Modelos
{
    interface IMotorizado
    {
        int Velocidade { get; set; }

        void Acelerar();
       
        void Frenar();
    }
}
