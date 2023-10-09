using System;


namespace Interfaces_G2_2024_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Refrigerador miRefrigerador = new Refrigerador();
            IEncender encender = miRefrigerador;
            encender.Encender();
            miRefrigerador.Apagar();

            Estufa miEstufa = new Estufa();
            miEstufa.Encender();
            miEstufa.Apagar();

            Console.ReadLine();
        }
    }
}
