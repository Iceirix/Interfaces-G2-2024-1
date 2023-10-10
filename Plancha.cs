using System;


namespace Interfaces_G2_2024_1
{
    internal class Plancha:Linea, IApagar, IEncender
    {
        public Plancha()
        {
            Marca = "";
        }
        public void Apagar()
        {
            Console.WriteLine("Apagando la plancha\n");
        }

        public void Encender()
        {
            Console.WriteLine("Plancha encendida, ignore este mensaje");
        }
    }
}
