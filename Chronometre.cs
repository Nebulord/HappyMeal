using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace HappyMeal
{
    public class Chronometre : INotifyPropertyChanged
    {
        private DispatcherTimer horloge;
        private int temps = 30; //en secondes

        public delegate void GameOverEventHandler(object sender, GameOverEventArgs e);
        public GameOverEventHandler FinChronometre;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Chronometre()
        {
            horloge = new DispatcherTimer();
            horloge.Interval = new TimeSpan(0, 0, 1);
            horloge.Tick += GestionChronometre;
            LancerChronometre();
        }

        public int Temps
        {
            get => temps;
            set
            {
                temps = value;
                OnPropertyChanged(nameof(AffichageTemps));
                if(Temps == 0)
                    FinChronometre?.Invoke(this, new GameOverEventArgs("Temps écoulé..."));
            }
        }

        public string AffichageTemps
        {
            get => temps + "s";
        }

        private void GestionChronometre(object sender, object e)
        {
            if (Temps > 0)
                Temps --;
            else
                ArreterChronometre();
        }

        public void LancerChronometre()
        {
            horloge.Start();
        }

        public void ArreterChronometre()
        {
            horloge.Stop();
        }
    }
}
