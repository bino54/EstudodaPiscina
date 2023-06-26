using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class SelecionarPaginaLoginPage : ContentPage
{
	public SelecionarPaginaLoginPage()
	{
		InitializeComponent();
		BindingContext = new SelecionarPaginaLoginViewModel();
	}
}