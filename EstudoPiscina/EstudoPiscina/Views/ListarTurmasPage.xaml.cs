using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class ListarTurmasPage : ContentPage
{
    public ListarTurmasPage()
	{
		InitializeComponent();
		BindingContext = new ListarTurmasViewModel();
	}

}