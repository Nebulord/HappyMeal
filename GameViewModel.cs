using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace HappyMeal
{
    public class GameViewModel : BaseViewModel
    {
        private Chronometre chronometre;
        private List<Aliment> aliments;
        private Panier panier;
        private Visibility endOfGame;
        private string endOfGameText;
        private bool afficherResultats;
        private Resultat resultat;

        public GameViewModel()
        {
            Chronometre = new Chronometre();
            Panier = new Panier();
            Aliments = ListeAlimentsDisponibles.GénérerAliments();
            EndOfGame = Visibility.Collapsed;
            Chronometre.FinChronometre += ActiverGameOver;
            Panier.PanierCraque += ActiverGameOver;
            AfficherResultats = false;
        }

        public Chronometre Chronometre
        {
            get => chronometre;
            set => chronometre = value;
        }

        public List<Aliment> Aliments
        {
            get => aliments;
            set => aliments = value;
        }

        public Panier Panier
        {
            get => panier;
            set => panier = value;
        }

        public Visibility EndOfGame
        {
            get => endOfGame;
            set
            {
                endOfGame = value;
                RaisePropertyChanged("EndOfGame");
            }
        }

        public string EndOfGameText
        {
            get => endOfGameText;
            set
            {
                endOfGameText = value;
                RaisePropertyChanged("EndOfGameText");
            }
        }

        public Resultat Resultat
        {
            get => resultat;
            set
            {
                resultat = value;
                RaisePropertyChanged("Resultat");
            }
        }

        public bool AfficherResultats
        {
            get => afficherResultats;
            set
            {
                afficherResultats = value;
                RaisePropertyChanged("AfficherResultats");
            }
        }

        public void ModifierPanier(int index)
        {
            Panier.Aliments.Add(Aliments[index]);
            Panier.Poids += Aliments[index].Poids;
        }

        public void ActiverGameOver(object sender, GameOverEventArgs e)
        {
            Chronometre.ArreterChronometre();
            EndOfGame = Visibility.Visible;
            EndOfGameText = "Game Over !";
            Resultat = new Resultat();
            Resultat.Note = e.Motif;
        }

        public void FinDePartie()
        {
            AfficherResultats = true;
            Chronometre.ArreterChronometre();
            EndOfGame = Visibility.Visible;
            EndOfGameText = "Résultats finaux :";
            Resultat = new Resultat(Panier.Aliments);
        }
    }
}
