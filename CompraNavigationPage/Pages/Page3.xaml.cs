using static Microsoft.Maui.ApplicationModel.Permissions;

namespace CompraNavigationPage.Pages;

public partial class Page3 : ContentPage
{
    String cadena = "";
    private String producto; // Add this line

    public Page3()
    {
        InitializeComponent();
    }
    public Page3(String producto)
    {
        InitializeComponent();
        this.producto = producto; // Add this line
    }

    private async void btAnteriorP3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void btSiguienteP3_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Page4(producto, cadena));
    }

    private void pickerUnidades_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex != -1)
        {
            cadena = (string)picker.ItemsSource[selectedIndex];
        }
    }
}
