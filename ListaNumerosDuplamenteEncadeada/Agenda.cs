using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaNumerosDuplamenteEncadeada
{
    internal class Agenda
    {

        //public Contato Anterior { get; set; }
        //public Contato Registro { get; set; }  // Registro = contato que vai ser inserido
        //public Contato Proximo { get; set; }
        public Contato Cabeca { get; set; }
        public Contato Cauda { get; set; }

    public Agenda()
        {
           // Anterior = null;  // agenda vazia
           // Registro = null;
           // Proximo = null;
            Cabeca = null;
            Cauda = null;
        }

        public void Push(Contato novoContato)
        {

            if (Vazio())
            {
                Cabeca = novoContato;
               // Registro = novoContato;
                Cauda = novoContato;
            }
            else
            {
                Cauda.Proximo = novoContato;
                Cauda = novoContato;
                OrdenaAgenda();
            }
            
                        
        }

        public void PrintAgenda()
        {
            Contato aux = Cabeca;
            do
            {
                Console.WriteLine(aux.ToString());
                aux = aux.Proximo;
            } while (aux != null);
        }

        public void OrdenaAgenda()
        {
            for (Contato referencia = Cabeca; referencia != null; referencia = referencia.Proximo) // i = 0; i!= null, i++
            {
                for (Contato comparacao = Cabeca.Proximo; comparacao != null; comparacao = comparacao.Proximo)
                {
                    if(referencia.Nome.CompareTo(comparacao.Nome) > 0)
                    {
                        Contato suporte = referencia;
                        referencia = comparacao;
                        comparacao = suporte;

                    }                               
                }
            }
        }

        public bool Vazio()
        {
            if ((Cabeca == null) && (Cauda == null))
                return true;
            else
                return false;
        }

        //public override string ToString()
       // {
           // return Cauda.ToString();
        //}
    }
}
