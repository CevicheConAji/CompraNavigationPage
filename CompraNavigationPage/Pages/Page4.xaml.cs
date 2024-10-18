namespace CompraNavigationPage.Pages;

public partial class Page4 : ContentPage
{
	public Page4()
	{
		InitializeComponent();
	}

    private async void btAnteriorP4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}