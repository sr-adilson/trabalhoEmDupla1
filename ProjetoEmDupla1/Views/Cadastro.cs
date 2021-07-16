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
            int id = 0;
            while (true)
            {
                try
                {
                    Console.Write("\nDigite um id para o produto: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Valor do id invalido, tente novamente!!");
                }
            }

            Console.Write("\nDigite um nome para o produto: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite um valor para o produto: ");

            decimal valor = 0;


            while (true)
            {
                try
                {
                  valor = Convert.ToDecimal(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Valor invalido, tente novamente!!");
                }
            }
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
