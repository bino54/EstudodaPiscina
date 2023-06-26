using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class ListarAlunosPage : ContentPage
{
	public ListarAlunosPage()
	{
		InitializeComponent();
		BindingContext = new ListarAlunosViewModel();
	}
}