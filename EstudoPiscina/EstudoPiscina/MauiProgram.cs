using EstudoPiscina.ViewModels;
using EstudoPiscina.Views;
using Microsoft.Extensions.Logging;

namespace EstudoPiscina;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<LoginViewModel>();

        builder.Services.AddTransient<SelecionarPaginaLoginPage>();
        builder.Services.AddTransient<SelecionarPaginaLoginViewModel>();

        builder.Services.AddTransient<PaginaAlunoPage>();
        builder.Services.AddTransient<PaginaAlunoViewModel>();

        builder.Services.AddTransient<PaginaTurmaFichaPage>();
        builder.Services.AddTransient<PaginaTurmaFichaModelView>();


        builder.Services.AddTransient<PaginaFichaPage>();
        builder.Services.AddTransient<PaginaFichaViewModel>();

        builder.Services.AddTransient<PaginaTurmaPage>();
        builder.Services.AddTransient<PaginaTurmaViewModel>();

        builder.Services.AddTransient<ListarTurmasPage>();
		builder.Services.AddTransient<ListarTurmasViewModel>();

        builder.Services.AddTransient<SelecionarPaginaPage>();
        builder.Services.AddTransient<SelecionarPaginaPageViewModel>();

        builder.Services.AddTransient<OpcoesPage1>();
        builder.Services.AddTransient<Opcoes1ViewModel>();

        builder.Services.AddTransient<ListarAlunosPage>();
        builder.Services.AddTransient<ListarAlunosViewModel>();

		builder.Services.AddTransient<NotePage>();
        builder.Services.AddTransient<NotePageViewModel>();

        builder.Services.AddTransient<NotaFinalPage>();
        builder.Services.AddTransient<NotaFinalViewModel>();



        return builder.Build();
	}
}
