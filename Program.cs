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

            Televisor miTelevisor = new Televisor();
            miTelevisor.Encender();
            miTelevisor.Apagar();

            Automovil miAutomovil = new Automovil();
            miAutomovil.Encender();
            miAutomovil.Apagar();

            Smartphone miSmartphone = new Smartphone();
            miSmartphone.Encender();
            miSmartphone.Apagar();

            Laptop miLaptop = new Laptop();
            miLaptop.Encender();
            miLaptop.Apagar();

            Plancha miPlancha = new Plancha();
            miPlancha.Encender();
            miPlancha.Apagar();

            Console.ReadLine();


        }
    }
}
