using System;


namespace Interfaces_G2_2024_1
{
    internal class Laptop : Linea, IApagar, IEncender
    {
        public Laptop()
        {
            Marca = "Asus";
        }
        public void Apagar()
        {
            Console.WriteLine("Cerrando aplicaciones y apagando el equipo\n");
        }

        public void Encender()
        {
            Console.WriteLine("Laptop {0} se encendio correctamente", Marca);
        }
    }
}
