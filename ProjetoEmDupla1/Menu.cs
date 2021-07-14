using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    class Menu
    {
        List<Categoria> lista = new List<Categoria>();
        public void MontaMenu()
        {
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
            Console.WriteLine("\t0 - Sair\n\t1 - Cadastro de Produto\n\t2 - Cadastro de Categoria");
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
                    break;
                case 1:
                    
                    break;
                case 2:
                    Categoria categoria = new Categoria();
                    categoria.PedeCategoria();
                    lista.Add(categoria);
                    Exibir();
                    break;
                default:
                    Console.WriteLine("Opção Inválida!");
                    break;
            }
        }

        public void Exibir()
        {
            foreach (Categoria c in lista)
            {
                Console.WriteLine("ID: " + c.idCategoria + "   Nome: " + c.nomeCategoria + "   Descrição: " + c.descricaoCategoria);
            }
        }
    }
}
