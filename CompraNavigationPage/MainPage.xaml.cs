﻿namespace CompraNavigationPage
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void btEmpezarCompra_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pages.Page2());
        }
    }

}