using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.Models
{
    public class Aluno
    {
        public int Nif { get; set; }
        public string Name { get; set; }
        public string Imagem { get; set; }
        public DateOnly DataNascimento { get; set; }

        public int Idade { get; set; }

        public Aluno(int nif, string name, string imagem, DateOnly dataNascimento)
        {
            this.Nif = nif;
            this.Name = name;
            this.Imagem = imagem;
            this.DataNascimento = dataNascimento;
            this.Idade = calculodaidade(this.DataNascimento);
        }

        public Aluno(int nif,string name, DateOnly dataNascimento)
        {
            this.Nif = nif;
            this.Name = name;
            this.DataNascimento= dataNascimento;
            this.Idade = calculodaidade(this.DataNascimento);
        }

        public override string ToString()
        {
            return String.Format("{0} - {1}", Nif, Name);
        }

        public int calculodaidade(DateOnly datanascimento)
        {
            DateOnly datahoje = DateOnly.FromDateTime(DateTime.Now);
            int idade = datahoje.Year - datanascimento.Year;
            if (datanascimento.Month > datahoje.Month)
            {
                idade--;
            }
            if (datanascimento.Month == datahoje.Month)
            {
                if (datanascimento.Day > datahoje.Day)
                {
                    idade--;
                }
            }
            return idade;
        }
    }
}
