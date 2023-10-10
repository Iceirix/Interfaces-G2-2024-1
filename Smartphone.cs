using System;


namespace Interfaces_G2_2024_1
{
    internal class Smartphone:Linea, IEncender, IApagar
    {
        public Smartphone()
        {
            Marca = "Realme X2 Pro";
        }

        public void Apagar()
        {
            Console.WriteLine("Bateria baja, apagando el equipo\n");
        }

        public void Encender()
        {
            Console.WriteLine("Dispositivo {0} encendido. Ingrese su contraseña para continuar", Marca);
        }
    }
}
