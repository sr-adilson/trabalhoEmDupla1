using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEmDupla1.Models;

namespace ProjetoEmDupla1.Views
{
    class Cadastro



    {
        public Produto CadastroProduto(Categoria categoria)
        {

            Console.Write("\nDigite um id para o produto: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite um nome para o produto: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite um valor para o produto: ");
            decimal valor = Convert.ToDecimal(Console.ReadLine());

            Produto produto = new Produto(id, nome, valor, categoria);

            return produto;          
         }


        public Categoria CadastroCategoria()
        {

            Console.Write("\nDigite um id para a categoria: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nDigite um nome para a categoria: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite uma descrição para a categoria: ");
            string descricao = Console.ReadLine();

            Categoria categoria = new Categoria(id, nome, descricao);

            return categoria;
        }


    }
}
