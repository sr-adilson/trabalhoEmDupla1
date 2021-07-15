using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    struct Categoria
    {
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string DescricaoCategoria { get; set; }

        public void PedeCategoria()
        {
            Console.Write("ID: ");
            IdCategoria = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            NomeCategoria = Console.ReadLine();
            Console.Write("Descrição: ");
            DescricaoCategoria = Console.ReadLine();
        }

    }
}
