using EstudoPiscina.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Usuario", "Usuario")]
    public partial class SelecionarPaginaLoginViewModel : ObservableObject
    {
        [ObservableProperty]
        Usuario usuario;


        [RelayCommand]
        async void EnviarTurma()
        {
            await Shell.Current.GoToAsync($"{nameof(PaginaTurmaPage)}", true,
                             new Dictionary<string, object>
                             {
                            {"Usuario",Usuario}
                             });
        }

        [RelayCommand]
        async void EnviarAluno() {
            await Shell.Current.GoToAsync($"{nameof(PaginaAlunoPage)}", true,
                             new Dictionary<string, object>
                             {
                            {"Usuario",Usuario}
                             });
        }

        [RelayCommand]
        async void SelecionarTurmas()
        {
            await Shell.Current.GoToAsync($"{nameof(ListarTurmasPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Usuario",Usuario}
                            });
        }

        [RelayCommand]
        async void EnviarFicha()
        {
            await Shell.Current.GoToAsync($"{nameof(PaginaFichaPage)}", true,
                             new Dictionary<string, object>
                             {
                            {"Usuario",Usuario}
                             });
        }


        [RelayCommand]
        async void EnviarFichaTurma()
        {
            await Shell.Current.GoToAsync($"{nameof(PaginaTurmaFichaPage)}", true,
                             new Dictionary<string, object>
                             {
                            {"Usuario",Usuario}
                             });
        }




    }
}
