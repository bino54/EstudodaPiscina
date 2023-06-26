using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class NotaFinalPage : ContentPage
{
	public NotaFinalPage()
	{
		InitializeComponent();
		BindingContext = new NotaFinalViewModel();
	}
}