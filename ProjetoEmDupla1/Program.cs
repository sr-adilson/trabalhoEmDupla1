using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuProd menuprod = new MenuProd();
            menuprod.cadastro();
            Console.ReadLine();
        }
    }
}
