using System;


namespace Interfaces_G2_2024_1
{
    internal class Automovil:Linea, IApagar, IEncender
    {
        public Automovil()
        {
            Marca = "Fiat";
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando el carro {0}, aseegurese de colocar el freno de mano\n", Marca);
        }

        public void Encender()
        {
            Console.WriteLine("El motor del auto {0} esta encendido y funcionando correctamente", Marca);
        }
    }
}
