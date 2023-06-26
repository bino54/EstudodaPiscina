using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.Models
{
    public class Objetivo
    {
        private int valorNota;
        public string Name { get; set; }
        public int ValorNota {
            get { return valorNota; }
            set { 
                valorNota = value; 
                Classificacao = RetornaClassificacao(valorNota); 
            }
        }
        public string Classificacao { get; set;}

        public Objetivo(string name, int valorNota)
        {
            Name = name;
            ValorNota = valorNota;
            Classificacao = RetornaClassificacao(valorNota);
        }

        public Objetivo(string name)
        {
            Name = name;
            ValorNota = -1;
            Classificacao = RetornaClassificacao(ValorNota);
        }

        public string RetornaClassificacao(int valorNota)
        {
            string s;
            if(valorNota == 0)
            {
                s = "não avaliado";
            }else if(valorNota == 1)
            {
                s = "Suficiente";
            }else if(valorNota == 2)
            {
                s = "Bom";
            }else if(valorNota == 3)
            {
                s = "Muito Bom";
            }
            else
            {
                s = "não classificado";
            }
            return s;
        }


        public override string ToString()
        {
            return String.Format("Objetivo:{0}, Valor da Nota:{1};", Name, ValorNota);
        }
    }
}
