using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1.Models
{
    class Categoria : BaseModel
    {
        public string Descricao { get; set; }

        public Categoria(int id, string nome, string descricao)
        {

            Id = id;
            Nome = nome;
            Descricao = descricao;
        }

    }
}
