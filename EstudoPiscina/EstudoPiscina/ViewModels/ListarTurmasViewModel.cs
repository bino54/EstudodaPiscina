using EstudoPiscina.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Usuario", "Usuario")]
    public partial class ListarTurmasViewModel : ObservableObject
    {
        [ObservableProperty]
        Usuario usuario;

        [RelayCommand]
        async void EnviarTurma(Turma turma)
        {
            
            await Shell.Current.GoToAsync($"{nameof(SelecionarPaginaPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Turma",turma}
                            }); 
            /*
            await Shell.Current.GoToAsync($"{nameof(ListarAlunosPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Usuario",Usuario}
                            });
            */
        }


    }
}
