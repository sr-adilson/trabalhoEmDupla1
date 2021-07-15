using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1.Models
{
    class Categoria : BaseModel
    {
        public string Descricao { get; set; }

        public void PedeCategoria()
        {
            Console.Write("ID Categoria: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome Categoria: ");
            Nome = Console.ReadLine();
            Console.Write("Descrição Categoria: ");
            Descricao = Console.ReadLine();
        }

    }
}
