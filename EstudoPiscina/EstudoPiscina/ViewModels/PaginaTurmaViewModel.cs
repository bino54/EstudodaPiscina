using EstudoPiscina.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Usuario", "Usuario")]
    public partial class PaginaTurmaViewModel: ObservableObject
    {
        [ObservableProperty]
        Usuario usuario;

        [ObservableProperty]
        string text;


        [ObservableProperty]
        string fundo;

        [ObservableProperty]
        List<Aluno> alunos;

        public PaginaTurmaViewModel()
        {
            Alunos = new List<Aluno>();
        }

        [RelayCommand]
        void ReceberAluno(int nif)
        {
            Aluno a1 = null;
            foreach (var aluno in Usuario.Alunos)
            {
                if(aluno.Nif == nif)
                {
                    a1 = aluno;
                }
            }
            if (a1 == null) { return; }
            int r = 0;
            foreach(var aluno in Alunos)
            {
                if(a1.Nif == aluno.Nif)
                {
                    r++;
                    Fundo = "Foi removido";
                }
            }
            if(r == 0)
            {
                Alunos.Add(a1);
                Fundo = "Foi adicionado";
            }
            else if(r >0)
            {
                Alunos.Remove(a1);
            }

        }

        [RelayCommand]
        async void EnviarTurma()
        {
            if ((string.IsNullOrWhiteSpace(Text))){
                await Shell.Current.DisplayAlert("Error", "Quando do nome turma obrigatorio", "Ok");
                return;

            }
            List<Avaliado> Avaliados = new List<Avaliado>();
            Avaliado av1 = null;
            foreach(var aluno in Alunos)
            {
                av1 = new Avaliado(Text, aluno);
                Avaliados.Add(av1);
            }
            Turma xb = new Turma(Text, Avaliados);
            Usuario.Turmas.Add(xb);

            await Shell.Current.GoToAsync($"{nameof(SelecionarPaginaLoginPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Usuario",Usuario }
                            });

        }
    }
}
