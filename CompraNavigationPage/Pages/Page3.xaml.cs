namespace CompraNavigationPage.Pages;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}

    private async void btAnteriorP3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private void btSiguienteP3_Clicked(object sender, EventArgs e)
    {

    }
}