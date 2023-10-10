using System;

namespace Interfaces_G2_2024_1
{
    internal class Refrigerador:Linea, IEncender, IApagar
    {
        
        internal Refrigerador()
        {
            Console.WriteLine("Verificando si hay alimentación");
            Marca = "";
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando el refrigerador\n");
        }

        void IEncender.Encender() 
        {
            Console.WriteLine("{0} te da la bienvenida", Marca);
        }


    }
}
