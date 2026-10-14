using TipCalculator.Maui.ViewModels;

namespace TipCalculator.Maui.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
		BindingContext = new MainViewModel();
	}
}