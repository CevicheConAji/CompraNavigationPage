namespace CompraNavigationPage.Pages;


public partial class Page2 : ContentPage
{
    String cadena = "";
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

    private void pickerProductos_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        int selectedIndex = picker.SelectedIndex;
        if (selectedIndex != -1)
        {
            cadena = (string)picker.ItemsSource[selectedIndex];
        }
    }
}
