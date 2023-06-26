using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class SelecionarPaginaPage : ContentPage
{
	public SelecionarPaginaPage()
	{
		InitializeComponent();
		BindingContext = new SelecionarPaginaPageViewModel();
	}
}