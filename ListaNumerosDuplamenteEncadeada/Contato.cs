using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNumerosDuplamenteEncadeada
{
    internal class Contato

    {
        public Contato Proximo { get; set; }
        public Contato Anterior { get; set; }
       public  string Nome { get; set; }

       public string Email { get; set; }

        public Telefone Telefones { get; set; }

        public Contato(string nome, string email, Telefone telefones)
        {
            Nome = nome;
            Email = email;
            Telefones = telefones;
            Anterior = null;
            Proximo = null;
        }

        public override string ToString()
        {
            return "=======================\nNome: " + Nome + "\nEmail: " + Email + "\nTelefone: "+Telefones.ToString(); 
        }
    }
}
