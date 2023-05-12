using TestApp.ViewModels;
namespace TestApp.Views;

public partial class FirstPage : ContentPage
{
	public FirstPage(FirstPageViewModel firstPageViewModel)
	{
		InitializeComponent();
		BindingContext = firstPageViewModel;
	}
}
