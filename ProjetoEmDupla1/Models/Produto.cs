using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1.Models
{
    class Produto : BaseModel
    {
        public decimal Valor { get; set; }

        public Categoria Categorias { get; set; }

        public void PedeProduto()
        {
            Console.Write("ID: ");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Valor: ");
            Valor = Convert.ToDecimal(Console.ReadLine());
            Categorias.PedeCategoria();
        }
    }
}
