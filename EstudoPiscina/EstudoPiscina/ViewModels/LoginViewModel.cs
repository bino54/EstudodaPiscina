using EstudoPiscina.Views;

namespace EstudoPiscina.ViewModels
{
    public partial class LoginViewModel: ObservableObject
    {

        [ObservableProperty]
        private Usuario user;

        [ObservableProperty]
        private string nif;

        [ObservableProperty]
        private string password;

        [RelayCommand]
        async void Login()
        {
            if (string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(Nif))
            {
                return;
            }
            int r;
            bool t = int.TryParse(Nif, out r);

            if (!t)
            {
                return;
            }

            if (r == User.Nif)
            {
                if(Password.Equals(User.Password))
                {
                    // Passa para a proxima pagina que é VisualTurmasPage()
                    // utiliza o Shell para viajar para outra pagina para levar o user
                    try
                    {
                        await Shell.Current.GoToAsync($"{nameof(SelecionarPaginaLoginPage)}", true,
                            new Dictionary<string, object>
                            {
                            {"Usuario",User }
                            });

                       // await Shell.Current.Navigation.PushModalAsync(ListarTurmasPage(User)));
                    }catch (Exception ex)
                    {
                        Password = ex.Message;
                     }
                }
                else
                {
                    //DisplayAlert("Erro", "Usuário ou senha inválidos", "OK");
                    await Shell.Current.DisplayAlert("Erro", "Senha inválida", "OK");
                }
            }else
            {
                await Shell.Current.DisplayAlert("Erro", "Usuário inválido", "OK");
            }

            Nif = "";
            Password = "";
            
        }

        public LoginViewModel()
        {
            User = LoadingInformation();
        }

        private Usuario LoadingInformation()
        {
            Objetivo ob1 = new Objetivo("Dominio da Respiração");
            List<Objetivo> l1 = new List<Objetivo> { ob1 };
            Categoria c1 = new Categoria("Respirar", l1);

            Objetivo ob2 = new Objetivo("Posição Hidrodinâmica Fundamental");
            List<Objetivo> l2 = new List<Objetivo> { ob2 };
            Categoria c2 = new Categoria("Alinhar", l2);

            Objetivo ob3 = new Objetivo("Executa batimento de pernas dorsal");
            Objetivo ob4 = new Objetivo("Entrada correta dos membros");
            Objetivo ob6 = new Objetivo("Execução de movimentos ");
            List<Objetivo> l3 = new List<Objetivo> { ob3, ob4, ob6 };
            Categoria c3 = new Categoria("Costas", l3);

            Objetivo ob11 = new Objetivo("Da parede, com deslize, com batimento dos pés com a cabeça");
            List<Objetivo> l5 = new List<Objetivo> { ob11 };
            Categoria c5 = new Categoria("Saltar", l5);

            Objetivo ob14 = new Objetivo("Da parede, com deslize, com batimento dos pés com as maos");
            Objetivo ob12 = new Objetivo("Arruma o seu materia");
            List<Objetivo> l6 = new List<Objetivo> { ob12,ob14 };
            Categoria c6 = new Categoria("Segurança", l6);

            Objetivo ob13 = new Objetivo("É participante na aula");
            List<Objetivo> l7 = new List<Objetivo> { ob13 };
            Categoria c7 = new Categoria("Socio", l7);


            List<Categoria> lc1 = new List<Categoria> { c1, c2, c3, c5, c6, c7 };
            FichaAvaliacao f1 = new FichaAvaliacao("Ficha 1",lc1);
            FichaAvaliacao f2 = new FichaAvaliacao("Ficha 2");
            FichaAvaliacao f3 = new FichaAvaliacao("Ficha 3");
            FichaAvaliacao f4 = new FichaAvaliacao("Ficha 4");

            List<FichaAvaliacao> ft = new List<FichaAvaliacao> { f1,f2, f3, f4 };

            Aluno a1 = new Aluno(1000, "Ricardo Rio", "aluno1.jpg", new DateOnly(1990, 10, 10));
            Aluno a2 = new Aluno(2000, "Manuel Fereira", "aluno2.jpg", new DateOnly(1995, 5, 15));
            Aluno a3 = new Aluno(3000, "Miguel Oliveira", "aluno3.jpg", new DateOnly(1992, 9, 19));
            Aluno a4 = new Aluno(4000, "Fernando Daniel", "aluno4.jpg", new DateOnly(1993, 7, 16));
            string turma_v1 = "Turma A";
            DateOnly data_turma_v1 = DateOnly.FromDateTime(DateTime.Now);
            DateOnly data_turma_v2 = DateOnly.FromDateTime(DateTime.Now);
            string turma_v2 = "Turma B";
            Avaliado av1 = new Avaliado(a1, lc1,turma_v1,data_turma_v1);
            Avaliado av2 = new Avaliado(a2, lc1,turma_v1,data_turma_v1);
            Avaliado av3 = new Avaliado(a3, lc1,turma_v1,data_turma_v1);
            Avaliado av4 = new Avaliado(a4, lc1, turma_v1, data_turma_v1);
            List<Aluno> b1 = new List<Aluno>() { a1, a2, a3, a4 };
            List<Avaliado> listav1 = new List<Avaliado>() { av1, av2, av3, av4 };
            Turma turmaA = new Turma(turma_v1, data_turma_v1, listav1, f1);
            Turma turmaB = new Turma(turma_v2, data_turma_v2);

            //Avaliacao avaliacao_turmaA = new Avaliacao(listav1 , turmaA,f1);
            List<Turma> turmas = new List<Turma> { turmaA, turmaB };
            Usuario u1 = new Usuario(1000, "senha", "Bernardo", turmas,b1,ft);
            return u1;
        }
    }
}