using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace HappyMeal
{
    public class MainViewModel : BaseViewModel
    {
        string pseudo;
        Visibility readyToPlay;

        public MainViewModel()
        {
            ReadyToPlay = Visibility.Collapsed;
            Pseudo = Application.Current.Resources.ContainsKey("Joueur") ? (string)Application.Current.Resources["Joueur"] : "";
        }

        public string Pseudo
        {
            get => pseudo;
            set
            {
                pseudo = value;
                RaisePropertyChanged("Pseudo");
                if (pseudo != "")
                    ReadyToPlay = Visibility.Visible;
                else
                    ReadyToPlay = Visibility.Collapsed;
            } 
        }

        public Visibility ReadyToPlay
        {
            get => readyToPlay;
            set
            {
                readyToPlay = value;
                RaisePropertyChanged("ReadyToPlay");
            }
        }
    }
}
