using EstudoPiscina.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Avaliado", "Avaliado")]
    public partial class NotePageViewModel: ObservableObject
    {
        [ObservableProperty]
        Avaliado avaliado;

        [ObservableProperty]
        bool isRefreshing; 

        [RelayCommand]
        async Task EnviarAluno(Objetivo objetivo)
        {
            try
            {
                await Shell.Current.GoToAsync($"{nameof(NotaFinalPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Objetivo",objetivo}
                            });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }


        [RelayCommand]
        void Refresh()
        {
            return;
        }


    }
}
