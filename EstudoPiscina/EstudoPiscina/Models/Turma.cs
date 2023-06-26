using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.Models
{
    public class Turma
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateOnly DiadaInscricao { get; set; }
        public List<Avaliado> Alunos { get; set; }
        public List<FichaAvaliacao> Fichas { get; set; } = new();

        private static int nextId = 0;

        public Turma(string name)
        {
            this.Id = nextId++;
            this.Name = name;
            this.DiadaInscricao = DateOnly.FromDateTime(DateTime.Now);
        }

        public Turma(string name, List<Avaliado> a1)
        {
            this.Id = nextId++;
            this.Name = name;
            this.Alunos = a1;
            this.DiadaInscricao = DateOnly.FromDateTime(DateTime.Now);
        }


        public Turma(string name, DateOnly diadaInscricao)
        {
            this.Id = nextId++ ;
            this.Name = name;
            this.DiadaInscricao = diadaInscricao;
        }


        public Turma(string name, DateOnly diadaInscricao, List<Avaliado> alunos, FichaAvaliacao ficha)
        {
            this.Id = nextId++ ;
            this.Name = name;
            this.DiadaInscricao = diadaInscricao;
            this.Alunos = alunos;
            this.Fichas.Add(ficha);
        }

        public Turma(string name, List<Avaliado> alunos, FichaAvaliacao ficha)
        {
            this.Id = nextId++ ;
            this.Name = name;
            this.DiadaInscricao = DateOnly.FromDateTime(DateTime.Now);
            this.Alunos = alunos;
            this.Fichas.Add(ficha);
        }

        public Turma(Turma turma)
        {
            this.Id = turma.Id;
            this.Name = turma.Name;
            this.DiadaInscricao = turma.DiadaInscricao;
            this.Alunos = turma.Alunos;
            this.Fichas = turma.Fichas;
        }


        public override string ToString()
        {
            string combinedString = string.Join(",", Alunos);
            return String.Format("Name:{0}, Alunos: [{1} ]", Name, combinedString);
        }

    }
}
