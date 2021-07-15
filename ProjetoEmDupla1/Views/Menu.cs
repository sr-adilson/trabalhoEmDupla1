using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoEmDupla1.Models;


namespace ProjetoEmDupla1.Views
{
    class Menu
    {
        List<Categoria> listaC = new List<Categoria>();
        List<Produto> listaP = new List<Produto>();
        public void MontaMenu()
        {
            Console.Clear();
            Cabecalho();
            Opcoes();
            Rodape();
            Escolha();
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
                    Console.WriteLine("Pressione ENTER para sair...");
                    break;
                case 1:
                    char repetir = 's';
                    do
                    {
                        Console.Clear();
                        Produto produto = new Produto();
                        CabecalhoProduto();
                        produto.PedeProduto();
                        listaP.Add(produto);
                        Console.Write("\nDe novo? (s/n)");
                        repetir = Convert.ToChar(Console.ReadLine().Trim());
                    } while (repetir.Equals('s'));
                    MontaMenu();
                    break;
                case 2:
                    repetir = 's';
                    do
                    {
                        Console.Clear();
                        Categoria categoria = new Categoria();
                        CabecalhoCategoria();
                        categoria.PedeCategoria();
                        listaC.Add(categoria);
                        Console.Write("\nDe novo? (s/n)");
                        repetir = Convert.ToChar(Console.ReadLine());
                    } while (repetir.Equals('s'));
                    MontaMenu();
                    break;
                case 3:
                    Console.Clear();
                    CabecalhoProdutoCadastrado();
                    ExibirProduto();
                    Console.ReadLine();
                    MontaMenu();
                    break;
                case 4:
                    Console.Clear();
                    CabecalhoCategoriaCadastrado();
                    ExibirCategoria();
                    Console.ReadLine();
                    MontaMenu();
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

        private void CabecalhoProdutoCadastrado()
        {
            Console.WriteLine("============= PRODUTOS CADASTRADOS =============");
        }

        private void CabecalhoCategoriaCadastrado()
        {
            Console.WriteLine("============ CATEGORIAS CADASTRADOS ============");
        }

        public void ExibirProduto()
        {
            foreach (Produto p in listaP)
            {
                Console.WriteLine("ID: " + p.Id + "   Nome: " + p.Nome + "   Valor: " + p.Valor);
            }
        }

        public void ExibirCategoria()
        {
            foreach (Categoria c in listaC)
            {
                Console.WriteLine("ID: " + c.Id + "   Nome: " + c.Nome + "   Descrição: " + c.Descricao);
            }
        }
    }
}
