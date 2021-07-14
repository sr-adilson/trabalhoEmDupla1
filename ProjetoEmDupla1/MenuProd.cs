using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    public class MenuProd
    {       
        public int id { get; set; }
        public string item { get; set; }
        public decimal valor { get; set; }
        public void cadastro()
        {
            Console.Write("Digite ID: ");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o Item: ");
            this.item = Console.ReadLine();
            Console.Write("Digite o valor: ");
            this.valor = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nID: \t" + id + "\nItem: \t" + item + "\nValor: \t" + valor);
            Console.ReadLine();
            
        }
    }
}
