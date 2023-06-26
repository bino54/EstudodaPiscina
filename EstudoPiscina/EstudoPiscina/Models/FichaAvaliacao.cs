using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.Models
{
    public class FichaAvaliacao
    {
        public int Id { get; set; }
        public List<Categoria> Categorias { get; set; }
        public string Descricao { get; set; }

        private static int nextId = 0;


        public FichaAvaliacao(string nome,List<Categoria> categorias)
        {
            this.Id = nextId++;
            this.Descricao = nome;
            this.Categorias = new List<Categoria>(categorias);
        }

        public FichaAvaliacao(string nome)
        {
            this.Id = nextId++;
            this.Descricao = nome;
            this.Categorias = new List<Categoria>();
        }



        public override string ToString()
        {
            string combinedString = string.Join("\n", Categorias);
            return String.Format("Categorias:{0}", combinedString);
        }
    }
}
