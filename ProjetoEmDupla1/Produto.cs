using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    struct Produto
    {
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal ValorProduto { get; set; }
        public void PedeProduto()
        {
            Console.Write("ID: ");
            IdProduto = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            NomeProduto = Console.ReadLine();
            Console.Write("Valor: ");
            ValorProduto = Convert.ToDecimal(Console.ReadLine());
        }
    }
}
