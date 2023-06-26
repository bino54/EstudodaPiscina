using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class PaginaTurmaPage : ContentPage
{
	public PaginaTurmaPage()
	{
		InitializeComponent();
		BindingContext = new PaginaTurmaViewModel();
	}
}