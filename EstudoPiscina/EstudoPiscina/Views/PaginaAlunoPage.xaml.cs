using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class PaginaAlunoPage : ContentPage
{
	public PaginaAlunoPage()
	{
		InitializeComponent();
		BindingContext = new PaginaAlunoViewModel();
	}
}