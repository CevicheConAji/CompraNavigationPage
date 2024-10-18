namespace CompraNavigationPage.Pages;

public partial class Page4 : ContentPage
{
    String cadena = "";
    String producto = "";
    String unidades = "";

    public Page4()
    {
        InitializeComponent();
    }

    public Page4(String producto, String unidades)
    {
        InitializeComponent();
        this.producto = producto;
        this.unidades = unidades;
    }


    private async void btAnteriorP4_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void btSiguienteP4_Clicked(object sender, EventArgs e)

    {
        cadena = domicilio.Text;
        await Navigation.PushAsync(new Page5(producto, unidades, cadena));
    }
}
