using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class PaginaFichaPage : ContentPage
{
	public PaginaFichaPage()
	{
		InitializeComponent();
		BindingContext = new PaginaFichaViewModel();
	}
}