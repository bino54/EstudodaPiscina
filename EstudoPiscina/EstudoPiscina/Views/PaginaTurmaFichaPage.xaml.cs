using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class PaginaTurmaFichaPage : ContentPage
{
	public PaginaTurmaFichaPage()
	{
		InitializeComponent();
		BindingContext = new PaginaTurmaFichaModelView();
	}
}