﻿
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Weather.API;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Weather
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly WeatherViewModel _viewModel;

        public MainPage()
        {
            InitializeComponent();

            _viewModel = new WeatherViewModel(new WeatherApiClient());
            DataContext = _viewModel;
            Loaded += MainPage_Loaded;
        }

        private async void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            await _viewModel.Initialize();
        }


    }
}
