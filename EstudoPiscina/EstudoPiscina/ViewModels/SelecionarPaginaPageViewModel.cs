using EstudoPiscina.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Turma", "Turma")]
    public partial class SelecionarPaginaPageViewModel: ObservableObject
    {
        [ObservableProperty]
        Turma turma;

        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task EnviarTurma()
        {
            await Shell.Current.GoToAsync($"{nameof(ListarAlunosPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Turma",Turma}
                            });

        }

        [RelayCommand]
        async void GoBack()
        {
            try
            {
                /**
                await Shell.Current.GoToAsync($"{nameof(ListarTurmasPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Usuario",Usuario}
                            });
                **
                await Shell.Current.Navigation.PopModalAsync();
                */
                await Shell.Current.GoToAsync("..");
            }
            catch (Exception ex)
            {
                Text = ex.Message;
            }
        }
    }
}
