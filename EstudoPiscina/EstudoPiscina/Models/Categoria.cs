using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public List<Objetivo> Objetivos { get; set; }

        public Categoria(string Descricao, List<Objetivo> Objetivos)
        {
            this.Descricao = Descricao;
            this.Objetivos = new List<Objetivo>(Objetivos);
        }

        public override string ToString()
        {
            string s = "";
            foreach(var item  in Objetivos)
            {
                s += item.ToString() + ", ";
            }
            return String.Format("Descrição:{0}, Objetivos:[{1}],\n", Descricao, s);
        }
    }
}
