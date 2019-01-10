using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyMeal
{
    public class Panier : INotifyPropertyChanged
    {
        private static int poidsMax;
        private int poids;
        private List<Aliment> aliments;

        public delegate void GameOverEventHandler(object sender, GameOverEventArgs e);
        public GameOverEventHandler PanierCraque;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Panier()
        {
            Poids = 0;
            PoidsMax = 20;
            Aliments = new List<Aliment>();
        }

        public int Poids
        {
            get => poids;
            set
            {
                poids = value;
                OnPropertyChanged(nameof(Poids));
                if (Poids > PoidsMax)
                    PanierCraque?.Invoke(this, new GameOverEventArgs("Le panier a craqué..."));
            }
        }

        public List<Aliment> Aliments
        {
            get => aliments;
            set => aliments = value;
        }

        public static int PoidsMax
        {
            get => poidsMax;
            set => poidsMax = value;
        }

        public bool EstVide()
        {
            return !Aliments.Any();
        }
    }
}
