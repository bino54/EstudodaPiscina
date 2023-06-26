using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Usuario", "Usuario")]
    public partial class PaginaAlunoViewModel: ObservableObject
    {
        [ObservableProperty]
        Usuario usuario;


        [ObservableProperty]
        private string nif;

        [ObservableProperty]
        private string nome;

        [ObservableProperty]
        private string diaNascimento;

        [ObservableProperty]
        private string mesNascimento;

        [ObservableProperty]
        private string anoNascimento;



        [ObservableProperty]
        private string nomeTurma;


        [RelayCommand]
        async void CriarAluno()
        {
            if (string.IsNullOrWhiteSpace(Nome) || string.IsNullOrWhiteSpace(Nif) || string.IsNullOrWhiteSpace(DiaNascimento) || string.IsNullOrWhiteSpace(MesNascimento) || string.IsNullOrWhiteSpace(AnoNascimento))
            {
                await Shell.Current.DisplayAlert("Erro", "Campos sao todos obrigatorios", "Ok");
                return;
            }

            int dia;int mes; int ano; int nif;
            bool t = int.TryParse(Nif, out nif);
            bool u = int.TryParse(DiaNascimento, out dia);
            bool y = int.TryParse(MesNascimento,out mes);
            bool x = int.TryParse(AnoNascimento,out ano);

            if(!t || !u || !y || !x) {
                await Shell.Current.DisplayAlert("Erro", "Erro num dos campos inseridos", "Ok");
                return;
            }

            if(dia <= 0 && dia > 31)
            {
                return;
            }else if(mes  <= 0 && mes > 12)
            {
                return;
            }

            var theDate = new DateOnly(ano, mes, dia);

            Aluno a4 = new Aluno(nif,Nome, theDate);

            Usuario.Alunos.Add(a4);

            Nif = "";
            Nome = "";
            DiaNascimento = "";
            MesNascimento = "";
            AnoNascimento = "";


        }



    }
}
