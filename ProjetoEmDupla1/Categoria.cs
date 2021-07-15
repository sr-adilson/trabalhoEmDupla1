using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEmDupla1
{
    public class Categoria
    {
        //public int idCategoria = 0;
        //public string nomeCategoria = String.Empty;
        //public string descricaoCategoria = String.Empty;
        public int IdCategoria { get; set; }
        public string NomeCategoria { get; set; }
        public string DescricaoCategoria { get; set; }
        //id, nome, descricao

        public Categoria(int id, string nome, string desc)
        {
            IdCategoria = id;
            NomeCategoria = nome;
            DescricaoCategoria = desc;
        }

        public override string ToString()
        {
            return $"ID: {IdCategoria}\t Nome: {NomeCategoria}\t Descrição: {DescricaoCategoria}";
        }
    }
}
