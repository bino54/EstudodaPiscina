using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.Models
{
    internal class Sistema
    {
        public Usuario MyUsuario { get; set; }
        public Avaliado Aluno { get; set; }

        public List<Aluno> Alunos { get; set; }

        public List<Turma> Turmas { get; set; }

        public FichaAvaliacao FichaAvaliacao { get; set; }

        public int Id_aluno { get; set; }

        public int Id_Turma { get; set; }

        public Sistema(Usuario myUsuario, Avaliado aluno, List<Aluno> alunos, List<Turma> turmas, FichaAvaliacao fichaAvaliacao)
        {
            MyUsuario = myUsuario;
            Aluno = aluno;
            Alunos = alunos;
            Turmas = turmas;
            FichaAvaliacao = fichaAvaliacao;
            Id_aluno = 0;
            Id_Turma = 0;
        }
    }
}
