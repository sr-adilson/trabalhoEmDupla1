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

        Cadastro cadastro = new Cadastro();

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
            Console.WriteLine("\t0 - Sair\n\t1 - Cadastro de Produto\n\t2 - Cadastro de Categoria(não usual)\n\t3 - Exibir Produtos Cadastrados\n\t4 - Exibir Categorias Cadastradas");
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

                        ExibirCategoria();

                        Console.Write("\nDigite o id da categoria: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            listaP.Add(cadastro.CadastroProduto(BuscaCategoria(id)));
                            Console.Write("\nDe novo? (s/n)");
                            repetir = Convert.ToChar(Console.ReadLine().Trim());
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message + "\nCadastre uma nova categoria!!.");
                            listaC.Add(cadastro.CadastroCategoria());
                        }

                    } while (repetir.Equals('s'));
                    MontaMenu();
                    break;
                case 2:

                    Console.WriteLine("Não vai!!");
                    //repetir = 's';
                    //do
                    //{
                    //    Console.Clear();
                    //    CabecalhoCategoria();
                    //    listaC.Add(cadastro.CadastroCategoria());
                    //    Console.Write("\nDe novo? (s/n)");
                    //    repetir = Convert.ToChar(Console.ReadLine());
                    //} while (repetir.Equals('s'));
                    //MontaMenu();
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
                Console.WriteLine("ID: " + p.Id + "   Nome: " + p.Nome + "   Valor: " + p.Valor + " Categoria: " + p.Categorias.Id+"- "+p.Categorias.Nome);
            }
        }

        public void ExibirCategoria()
        {
            foreach (Categoria c in listaC)
            {
                Console.WriteLine("ID: " + c.Id + "   Nome: " + c.Nome + "   Descrição: " + c.Descricao);
            }
        }

        public Categoria BuscaCategoria(int id)
        {
            foreach (Categoria categoria in listaC)
            {
                if (categoria.Id.Equals(id))
                {
                    return categoria;
                }
            }

            throw new Exception("Id não encontrado ");
        }

    }
}
