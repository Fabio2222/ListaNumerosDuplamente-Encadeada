using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNumerosDuplamenteEncadeada
{
    internal class Telefone
    {
        public string Tipo { get; set; }
        public int DDD { get; set; }
        public int Numero { get; set; }

        public Telefone(string tipo, int ddd, int numero)
        {
            Tipo = tipo;
            DDD = ddd;
            Numero = numero;
        }
        public override string ToString()
        {
            return Tipo + ": (" + DDD + ")" + Numero;
        }
    }
}
