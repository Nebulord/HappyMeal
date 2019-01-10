using System;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;

namespace HappyMeal
{
    public sealed partial class GamePage : Page
    {
        GameViewModel vm;
        int indexDragged;

        public GamePage()
        {
            vm = new GameViewModel();
            this.DataContext = vm;
            this.InitializeComponent();
            Uri lien = new Uri("ms-appx:///Assets/Musique/Let's Play!.mp3");
            Musique.Source = lien;
            Food1.DragStarting += (UIElement e, DragStartingEventArgs args) => { indexDragged = 0; };
            Food2.DragStarting += (UIElement e, DragStartingEventArgs args) => { indexDragged = 1; };
            Food3.DragStarting += (UIElement e, DragStartingEventArgs args) => { indexDragged = 2; };
            Food4.DragStarting += (UIElement e, DragStartingEventArgs args) => { indexDragged = 3; };
            Food5.DragStarting += (UIElement e, DragStartingEventArgs args) => { indexDragged = 4; };
            Food6.DragStarting += (UIElement e, DragStartingEventArgs args) => { indexDragged = 5; };
            Food7.DragStarting += (UIElement e, DragStartingEventArgs args) => { indexDragged = 6; };
            Food8.DragStarting += (UIElement e, DragStartingEventArgs args) => { indexDragged = 7; };
            vm.Chronometre.FinChronometre += OnGameOverDetected;
            vm.Panier.PanierCraque += OnGameOverDetected;
            Rejouer.Click += RestartGame;
        }

        private void OnItemDragged(UIElement sender, DragStartingEventArgs e)
        {
            Uri lien = new Uri("ms-appx:///Assets/Sons/ClicAliment.wav");
            Son.Source = lien;
            Son.Play();
            e.Data.RequestedOperation = DataPackageOperation.Move;
            e.Data.Properties.Add("Aliment", sender);
            e.Data.Properties.Add("Index", sender.AccessKey);
        }

        private void OnItemDraggedOver(object sender, DragEventArgs e)
        {
            Image aliment = e.DataView.Properties["Aliment"] as Image;
            aliment.Source = null;
            e.AcceptedOperation = DataPackageOperation.Move;
            //On retire les notifications de DragAndDrop
            e.DragUIOverride.IsCaptionVisible = false;
            e.DragUIOverride.IsGlyphVisible = false;
        }

        //Item dropped out of the cage
        private void OnItemDropped(object sender, DragEventArgs e)
        {
            if(!vm.Panier.Aliments.Contains(vm.Aliments[indexDragged]))
            {
                Uri lien = new Uri("ms-appx:///Assets/Sons/AlimentLache.wav");
                Son.Source = lien;
                Son.Play();
                Image aliment = e.DataView.Properties["Aliment"] as Image;
                BitmapImage bitmapImage = new BitmapImage();
                Uri uri = new Uri("ms-appx:///" + vm.Aliments[indexDragged].ImageSource);
                bitmapImage.UriSource = uri;
                aliment.Source = bitmapImage;
            }
        }

        //Item dropped into the cage
        private void OnItemDroppedInTheCage(object sender, DragEventArgs e)
        {
            Uri lien = new Uri("ms-appx:///Assets/Sons/DansLePanier.wav");
            Son.Source = lien;
            Son.Play();
            vm.ModifierPanier(indexDragged);
        }

        //End of the game
        private void OnGameStopped(object sender, TappedRoutedEventArgs e)
        {
            if(!vm.Panier.EstVide())
            {
                Musique.Stop();
                Uri lien = new Uri("ms-appx:///Assets/Sons/Sifflet.wav");
                Son.Source = lien;
                Son.Play();
                Rejouer.Content = Application.Current.Resources["Joueur"] + ", on rejoue ?";
                vm.FinDePartie();
            }
            else
            {
                GameOverEventArgs gameOver = new GameOverEventArgs("Le panier est vide...");
                OnGameOverDetected(this, gameOver);
                vm.ActiverGameOver(this, gameOver);
            }
           
        }

        //GameOver sound effect
        private void OnGameOverDetected(object sender, GameOverEventArgs e)
        {
            Musique.Stop();
            Uri lien = new Uri("ms-appx:///Assets/Sons/GameOver.wav");
            Son.Source = lien;
            Son.Play();
            Rejouer.Content = Application.Current.Resources["Joueur"] + ", on rejoue ?";
        }

        private void RestartGame(object sender, RoutedEventArgs e)
        {
            //On supprime de la navigation la partie précédentes
            while (Frame.BackStackDepth > 0)
            {
                if (Frame.CanGoBack)
                {
                    Frame.GoBack();
                }
            }
            Frame.CacheSize = 0;
            Frame rootFrame = Window.Current.Content as Frame;
            rootFrame.Navigate(typeof(GamePage));
        }
    }
}
