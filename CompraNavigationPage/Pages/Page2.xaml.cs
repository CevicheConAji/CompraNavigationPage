namespace CompraNavigationPage.Pages;

public partial class Page2 : ContentPage
{
	public Page2()
	{
		InitializeComponent();
	}

    private async void btSiguienteP2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page3());
    }

    private async void btAnteriorP2_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }
}