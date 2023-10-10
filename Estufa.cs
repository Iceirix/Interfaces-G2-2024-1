using System;

namespace Interfaces_G2_2024_1
{
    internal class Estufa:Linea, IEncender, IApagar
    {
        internal Estufa()
        {
            Marca = "LG";

        }

        public void Apagar()
        {
            Console.WriteLine("Apagando la estufa\n");
        }

        public void Encender()
        {
            Console.WriteLine("{0} Hola :)", Marca);
        }
    }
}
