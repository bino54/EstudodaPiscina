using EstudoPiscina.Views;

namespace EstudoPiscina;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		//Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage)); Dá erro

        Routing.RegisterRoute(nameof(SelecionarPaginaLoginPage), typeof(SelecionarPaginaLoginPage));

        Routing.RegisterRoute(nameof(PaginaAlunoPage), typeof(PaginaAlunoPage));

        Routing.RegisterRoute(nameof(PaginaTurmaFichaPage), typeof(PaginaTurmaFichaPage));

        Routing.RegisterRoute(nameof(PaginaFichaPage), typeof(PaginaFichaPage));

        Routing.RegisterRoute(nameof(PaginaTurmaPage), typeof(PaginaTurmaPage));

        Routing.RegisterRoute(nameof(ListarTurmasPage), typeof(ListarTurmasPage));

        Routing.RegisterRoute(nameof(OpcoesPage1), typeof(OpcoesPage1));

        Routing.RegisterRoute(nameof(SelecionarPaginaPage), typeof(SelecionarPaginaPage));

        Routing.RegisterRoute(nameof(ListarAlunosPage), typeof(ListarAlunosPage));

        Routing.RegisterRoute(nameof(NotePage), typeof(NotePage));

        Routing.RegisterRoute(nameof(NotaFinalPage), typeof(NotaFinalPage));
    }
}
