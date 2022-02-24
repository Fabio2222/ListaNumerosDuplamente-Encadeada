using System;

namespace ListaNumerosDuplamenteEncadeada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            Agenda agenda = new Agenda();
            //Contato c1;
            // Telefone t1;
            do
            {
                Console.WriteLine("Informe seu nome: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Informe seu e-mail: ");
                string email = Console.ReadLine();
                Console.WriteLine("Informe seu tipo: ");
                string tipo = Console.ReadLine();
                Console.WriteLine("Informe seu ddd: ");
                int ddd = int.Parse(Console.ReadLine());
                Console.WriteLine("Informe seu número: ");
                int numero = int.Parse(Console.ReadLine());

                agenda.Push(new Contato(nome, email, new Telefone(tipo, ddd, numero)));  // inserir contatos
                //Console.WriteLine(agenda.ToString());
                op = int.Parse(Console.ReadLine());
            } while (op != 123);

            agenda.OrdenaAgenda();

            // t1 = new Telefone(tipo, ddd, numero);
            // c1 = new Contato(nome, email, t1);

            //agenda.Inserir(c1);

            agenda.PrintAgenda();
        }
    }
}
