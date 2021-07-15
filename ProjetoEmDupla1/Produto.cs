using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    public class Produto
    {
        //public int idCategoria = 0;
        //public string nomeCategoria = String.Empty;
        //public string descricaoCategoria = String.Empty;
        public int IdProduto { get; set; }
        public string NomeProduto { get; set; }
        public decimal ValorProduto { get; set; }
        //id, nome, descricao
        public void PedeProduto()
        {
            char repetir = 's';
            do
            { 
                Console.Write("ID: ");
                IdProduto = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nome: ");
                NomeProduto = Console.ReadLine();
                Console.Write("Valor: ");
                ValorProduto = Convert.ToDecimal(Console.ReadLine());
                Console.Write("De novo? (s/n)");
                repetir = Convert.ToChar(Console.ReadLine());
                Console.Clear();
            } while (repetir.Equals('s'));

            Menu menu = new Menu();
            menu.MontaMenu();
        }

    }
}
