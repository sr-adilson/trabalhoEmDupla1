using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    class Menu
    {
        List<Categoria> listaC = new List<Categoria>();
        List<Produto> listaP = new List<Produto>();
        public void MontaMenu()
        {
            //bool sair = false;
            //do
	        //{
                //Console.Clear();
                Cabecalho();
                Opcoes();
                Rodape();
                Escolha();
	        //} while (/*sair == false*/true);
        }

        private void Cabecalho()
        {
            Console.WriteLine(@"\\\\\\\\\\\\\\\\\\ HAVAN LABS //////////////////");
            Console.WriteLine("====================== G5 ======================");
        }

        private void Opcoes()
        {
            Console.WriteLine("\t0 - Sair\n\t1 - Cadastro de Produto\n\t2 - Cadastro de Categoria\n\t3 - Exibir Produtos Cadastrados\n\t4 - Exibir Categorias Cadastradas");
        }

        private void Rodape()
        {
            Console.WriteLine("================================================");
            Console.Write("Escolha uma opção: ");
        }

        private void Escolha()
        {
            int opcao = 0;
            opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 0:
                    //sair = true;
                    Console.WriteLine("Tchau!");
                    break;
                case 1:
                    Console.Clear();
                    Produto produto = new Produto();
                    CabecalhoProduto();
                    produto.PedeProduto();
                    listaP.Add(produto);
                    break;
                case 2:
                    char repetir = 's';
                    do
                    {
                        Console.Clear();
                        CabecalhoCategoria();
                        Console.Write("ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Nome: ");
                        string nome = Console.ReadLine();
                        Console.Write("Descrição: ");
                        string desc = Console.ReadLine();
                        Categoria model = new Categoria(id, nome, desc);
                        listaC.Add(model);
                        Console.Write("De novo? (s/n)");
                        repetir = Convert.ToChar(Console.ReadLine());
                    } while (repetir.Equals('s'));
                    MontaMenu();
                    break;
                case 3:
                    ExibirProduto();
                    // Exibir dados cadastrados em Produto
                    break;
                case 4:
                    ExibirCategoria();
                    //Console.ReadLine();
                    // Exibir dados cadastrados em Categoria
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        private void CabecalhoProduto()
        {
            Console.WriteLine("=============== CADASTRO PRODUTO ===============");
        }

        private void CabecalhoCategoria()
        {
            Console.WriteLine("============== CADASTRO CATEGORIA ==============");
        }

        public void ExibirProduto()
        {
            foreach (Produto p in listaP)
            {
                Console.WriteLine("ID: " + p.IdProduto + "   Nome: " + p.NomeProduto + "   Valor: " + p.ValorProduto);
            }
        }

        public void ExibirCategoria()
        {
            foreach (Categoria c in listaC)
            {
                Console.WriteLine("ID: " + c.IdCategoria + "   Nome: " + c.NomeCategoria + "   Descrição: " + c.DescricaoCategoria);
            }
        }

        /*public void ExibirCategoria()
        {
            foreach (Categoria c in listaC)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("...");
        }*/

        public void PedeCategoria()
        {
            Console.Write("ID: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Descrição: ");
            string desc = Console.ReadLine();
            listaC.Add(new Categoria(id, nome, desc));
        }
    }
}
