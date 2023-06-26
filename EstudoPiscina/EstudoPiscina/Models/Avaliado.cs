using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.Models
{
    public class Avaliado: Aluno
    {
        public List<Categoria> Ficha { get; set; }
        public string NomeTurma { get; set; }
        public DateOnly DataInscricao { get; set; }
        public string Status { get; set; }


        public Avaliado(int nif, string name, string imagem, DateOnly datanascimento, List<Categoria> ficha, string nomeTurma, DateOnly dataInscricao) : base(nif, name, imagem, datanascimento)
        {
            Ficha = ficha;
            NomeTurma = nomeTurma;
            DataInscricao = dataInscricao;
            Status = "Em avaliação";
        }

        public Avaliado(Aluno a1, List<Categoria> ficha,string nomeTurma,DateOnly dataInscricao) : base(a1.Nif, a1.Name, a1.Imagem, a1.DataNascimento)
        {
            Ficha = ficha;
            NomeTurma = nomeTurma;
            DataInscricao =(DateOnly)dataInscricao;
            Status = "Em avaliação";
        }

        public Avaliado(string nomeTurma,Aluno a1) : base(a1.Nif, a1.Name, a1.Imagem, a1.DataNascimento)
        {
            NomeTurma = nomeTurma;
            DataInscricao = DateOnly.FromDateTime(DateTime.Now);
            Status = "Em avaliação";
        }

        public Avaliado(Avaliado a1) : base(a1.Nif, a1.Name, a1.Imagem, a1.DataNascimento)
        {
            Ficha = a1.Ficha;
            NomeTurma= a1.NomeTurma;
            DataInscricao = a1.DataInscricao;
            Status = a1.Status.ToString();
        }

        //public List<Categoria> devolverCategorias()
        //{
        //    List<Categoria> lista = new List<Categoria>();

        //    foreach(Categoria c1 in Ficha.Categorias)
        //    {
        //        lista.Add(c1);
        //    }
        //    return lista;
        //}

        public Categoria devolverCategoria(Categoria cat1)
        {
            Categoria resultado = null;
            foreach (Categoria c1 in Ficha)
            {
                if (c1.Descricao.Equals(cat1.Descricao))
                {
                    resultado = c1;
                }
            }
            return resultado;
        }

       

    }
}
