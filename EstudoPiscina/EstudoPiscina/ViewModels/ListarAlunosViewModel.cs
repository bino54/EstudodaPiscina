using EstudoPiscina.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoPiscina.ViewModels
{
    [QueryProperty("Turma", "Turma")]
    public partial class ListarAlunosViewModel: ObservableObject
    {

        [ObservableProperty]
        Turma turma;


        [RelayCommand]
        async Task EnviarAluno(Avaliado aluno)
        {
            try
            {
                await Shell.Current.GoToAsync($"{nameof(NotePage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Avaliado",aluno}
                            });
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
    }
}
