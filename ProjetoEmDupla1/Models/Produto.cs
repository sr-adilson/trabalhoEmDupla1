using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1.Models
{
    class Produto : BaseModel
    {
        public decimal Valor { get; set; }

        public Categoria Categorias { get; set; }

        public Produto(int id, string nome, decimal valor, Categoria categoria)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            this.Categorias = categoria;
        }
    }
}
