using EstudoPiscina.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Usuario", "Usuario")]
    public partial class PaginaTurmaFichaModelView : ObservableObject
    {
        [ObservableProperty]
        Usuario usuario;

        [ObservableProperty]
        FichaAvaliacao ficha;

        [ObservableProperty]
        Turma turma;

        [ObservableProperty]
        private int x;

        [ObservableProperty]
        private int y;

        [ObservableProperty]
        private Turma selectedTurma;

        [ObservableProperty]
        private FichaAvaliacao selectedFicha;

        [ObservableProperty]
        private string typeSelected;

        [ObservableProperty]
        private string color1;

        [ObservableProperty]
        private string color2;


        public PaginaTurmaFichaModelView()
        {
            X = -1;
            Y = -1;
            Ficha = null;
            Turma = null;
        }


        [RelayCommand]
        void SelecionarFicha(FichaAvaliacao ficha)
        {
            Ficha = ficha;
            Y = 1;
            Color2 = "red";
        }

        [RelayCommand]
        void SelecionarTurma(Turma turma)
        {
            Turma = turma;
            X = 1;
            Color1 = "blue";
        }

        [RelayCommand]
        async void Atribuir()
        {
            if(X == -1 || Y == -1) { return; }
            Turma turmaA = null;
            foreach(var turma in Usuario.Turmas) {
                if(turma.Id == Turma.Id)
                {
                    turmaA = turma;
                    break;
                }
            }
            turmaA.Fichas.Add(Ficha);
            //Ficha = null;
            //Turma = null;
            X = -1;
            Y = -1;
            Ficha = null;
            Turma = null;
            Color1 = "white";
            Color2 = "white";
           

        }


    }
}
