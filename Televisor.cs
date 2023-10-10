using System;


namespace Interfaces_G2_2024_1
{
    internal class Televisor:Linea, IEncender, IApagar
    {
        internal Televisor()
        {
            Marca = "Samsung";
        }
        public void Apagar()
        {
            Console.WriteLine("Apagando el televisor {0}\n",Marca);
        }

        public void Encender()
        {
            Console.WriteLine("El televisor {0} esta encendido", Marca);
        }
    }
}
