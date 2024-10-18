namespace CompraNavigationPage.Pages;

public partial class Page5 : ContentPage
{
	public Page5()
	{
		InitializeComponent();
	}
    public Page5(String producto, String unidades, String domicilio)
    {
        InitializeComponent();
        lbPedido.Text = "Tipo de Cafe: " + producto + "\nUnidades: " + unidades+"\nDirección: "+domicilio;
    }

    private async void btAnteriorP5_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}