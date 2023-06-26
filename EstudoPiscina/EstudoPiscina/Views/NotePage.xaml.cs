using EstudoPiscina.ViewModels;

namespace EstudoPiscina.Views;

public partial class NotePage : ContentPage
{
	public NotePage()
	{
		InitializeComponent();
		BindingContext = new NotePageViewModel();
	}
}