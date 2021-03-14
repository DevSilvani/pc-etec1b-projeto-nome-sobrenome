using System;

namespace pc_etec1b_projeto_nome_sobrenome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "", sobrenome = "";
            Console.Write("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira seu sobrenome: ");
            sobrenome = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Nome completo: "+nome+" "+sobrenome);
            Console.WriteLine("Nome Catálogo: "+sobrenome+", "+nome);
            Console.ReadKey();
            


        }
    }
}
