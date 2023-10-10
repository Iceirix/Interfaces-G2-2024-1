using System;

namespace Interfaces_G2_2024_1
{
    internal abstract class Linea
    {
        private string marca;

        public string Marca { get => marca;
            set => marca = (value == "") ? "Genérica" : value; }
    }
}
