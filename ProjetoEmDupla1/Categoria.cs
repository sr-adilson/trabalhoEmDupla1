using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    public class Categoria
    {
        //public int idCategoria = 0;
        //public string nomeCategoria = String.Empty;
        //public string descricaoCategoria = String.Empty;
        public int idCategoria { get; set; }
        public string nomeCategoria { get; set; }
        public string descricaoCategoria { get; set; }
         //id, nome, descricao
        public void PedeCategoria()
        {
            Console.Write("Id Categoria: ");
            this.idCategoria = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome Categoria: ");
            this.nomeCategoria = Console.ReadLine();
            Console.Write("Descrição Categoria: ");
            this.descricaoCategoria = Console.ReadLine();
        }
    }
}
