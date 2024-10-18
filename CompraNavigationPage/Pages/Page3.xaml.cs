namespace CompraNavigationPage.Pages;

public partial class Page3 : ContentPage
{
	public Page3()
	{
		InitializeComponent();
	}
    public Page3(String producto)
    {
        InitializeComponent();

    }

    private async void btAnteriorP3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void btSiguienteP3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page4());
    }
}