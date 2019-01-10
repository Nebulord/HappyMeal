using System;
using Windows.Foundation;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;


namespace HappyMeal
{
    public sealed partial class MainPage : Page
    {
        MainViewModel vm;
        public MainPage()
        {
            vm = new MainViewModel();
            this.DataContext = vm;
            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(500, 500));
            Window.Current.SizeChanged += SetWindowSize;
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigated += OnRetour;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
            this.InitializeComponent();
            Jouer.Click += SetGame;
            Regles.Click += SetRules;
        }

        private void SetWindowSize(object sender, WindowSizeChangedEventArgs e)
        {
            ApplicationView.GetForCurrentView().TryResizeView(new Size(500, 500));
        }

        private void SetGame(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["Joueur"] = vm.Pseudo;
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(GamePage));
        }

        private void SetRules(object sender, RoutedEventArgs e)
        {
            Application.Current.Resources["Joueur"] = vm.Pseudo;
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(ReglesPage));
        }

        void OnRetour(Object sender, NavigationEventArgs e)
        {
            if (((Frame)sender).CanGoBack)
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            else
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
        }

        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }
    }
}
