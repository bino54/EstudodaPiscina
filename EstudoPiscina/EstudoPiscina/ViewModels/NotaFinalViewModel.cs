using EstudoPiscina.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.ViewModels
{

    [QueryProperty("Objetivo", "Objetivo")]
    public partial class NotaFinalViewModel: ObservableObject
    {
        [ObservableProperty]
        String text;

        [ObservableProperty]
        Objetivo objetivo;

        [ObservableProperty]
        private string notaValor;


        [RelayCommand]
        async void AlterarNota()
        {
            int r;
            bool t = int.TryParse(NotaValor,out r);
            if (!t)
            {
                return;
            }
            if(r>=0 && r<=3)
            {
                Objetivo.ValorNota = r;
                NotaValor = "";
                await Shell.Current.GoToAsync($"{nameof(NotaFinalPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Objetivo",objetivo}
                            });
            }
            else
            {
                await Shell.Current.DisplayAlert("Erro", "Nota invalida", "OK");
            }
            NotaValor = "";

        }

        [RelayCommand]
        async void Voltar()
        {
            try
            {
                await Shell.Current.GoToAsync("../..");
            }catch (Exception ex)
            {
                Text = ex.Message;
            }
        }
    }
}
