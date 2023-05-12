using TestApp.ViewModels;

namespace TestApp.Views;

public partial class SecondPage : ContentPage
{
	public SecondPage(SecondPageViewModel secondPageViewModel)
	{
		InitializeComponent();
		BindingContext = secondPageViewModel;
	}
}
