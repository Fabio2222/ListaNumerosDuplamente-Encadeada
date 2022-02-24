using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNumerosDuplamenteEncadeada
{
    internal class ListaContato
    {
        public Contato Head { get; set; }

        public Contato Tail { get; set; }

        public ListaContato()
        {
            Tail = null;
            Head = null;
        }

        public bool Vazio()
        {
            if ((Tail == null) && (Head == null))
                return true;
            else
            
                return false;
            
        }
        public void Ordenacao(Contato aux)
        {
            if (Vazio())
            {
                Head = aux;
                Tail = aux;
            }
            else
            {
               // if ( )
                {

                }
            }
                

        }
        public void Push(Contato aux)
        {
            if (Vazio())
            {

            }
        }
    }
}
