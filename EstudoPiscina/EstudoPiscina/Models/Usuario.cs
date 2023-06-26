using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.Models
{
    public class Usuario
    {

        public int Nif { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public List<Turma> Turmas { get; set; }

        public List<Aluno> Alunos { get; set; }

        public List<FichaAvaliacao> Fichas { get; set; }




        public Usuario(int nif, string password, string name)
        {
            this.Nif = nif;
            this.Password = password;
            this.Name = name;
            this.Turmas = new List<Turma>();
            this.Alunos = new List<Aluno>();
            this.Fichas = new List<FichaAvaliacao>();
        }

        public Usuario(int nif, string password, string name, List<Turma> turmas)
        {
            this.Turmas = turmas;
            this.Nif = nif;
            this.Password = password;
            this.Name = name;
            this.Alunos = new List<Aluno>();
            this.Turmas = new List<Turma>();
            this.Fichas = new List<FichaAvaliacao>();
        }

        public Usuario(int nif, string password, string name, List<Turma> turmas, List<Aluno> alunos)
        {
            this.Turmas = turmas;
            this.Nif = nif;
            this.Password = password;
            this.Name = name;
            this.Alunos = alunos;
            this.Fichas = new List<FichaAvaliacao>();
        }

        public Usuario(int nif, string password, string name, List<Turma> turmas, List<Aluno> alunos,List<FichaAvaliacao> fichas)
        {
            this.Turmas = turmas;
            this.Nif = nif;
            this.Password = password;
            this.Name = name;
            this.Alunos = alunos;
            this.Fichas = fichas;
        }
    }
}
