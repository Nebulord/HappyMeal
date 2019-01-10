using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Imaging;

namespace HappyMeal
{
    public class Resultat : INotifyPropertyChanged
    {
        private string note;
        private BitmapImage glucideResult;
        private BitmapImage lipideResult;
        private BitmapImage proteineResult;

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Resultat()
        {
            GlucideResult = new BitmapImage();
            LipideResult = new BitmapImage();
            ProteineResult = new BitmapImage();
        }

        public Resultat(List<Aliment> aliments)
        {
            GlucideResult = new BitmapImage();
            LipideResult = new BitmapImage();
            ProteineResult = new BitmapImage();

            //Calcul de la note
            int Score = 0;
            float SommeDesApports = 0;
            float ApportGlucide = 0;
            float ApportLipide = 0;
            float ApportProteine = 0;
            foreach (Aliment a in aliments)
            {
                SommeDesApports += a.Glucide;
                SommeDesApports += a.Lipide;
                SommeDesApports += a.Proteine;
                ApportGlucide += a.Glucide;
                ApportLipide += a.Lipide;
                ApportProteine += a.Proteine;
            }

            ApportGlucide = (ApportGlucide / SommeDesApports) * 100f;
            ApportLipide = (ApportLipide / SommeDesApports) * 100f;
            ApportProteine = (ApportProteine / SommeDesApports) * 100f;

            Uri lienG;
            if (ApportGlucide < 40)
                lienG = new Uri("ms-appx:///Assets/Peu.png");
            else if (ApportGlucide > 55)
                lienG = new Uri("ms-appx:///Assets/Trop.png");
            else
            {
                lienG = new Uri("ms-appx:///Assets/Parfait.png");
                Score += 3;
            }
            GlucideResult = new BitmapImage(lienG);

            Uri lienL;
            if (ApportLipide < 25)
                lienL = new Uri("ms-appx:///Assets/Peu.png");
            else if(ApportLipide > 40)
                lienL = new Uri("ms-appx:///Assets/Trop.png");
            else
            {
                lienL = new Uri("ms-appx:///Assets/Parfait.png");
                Score += 3;
            }
            LipideResult = new BitmapImage(lienL);

            Uri lienP;
            if (ApportProteine < 15)
                lienP = new Uri("ms-appx:///Assets/Peu.png");
            else if(ApportProteine > 30)
                lienP = new Uri("ms-appx:///Assets/Trop.png");
            else
            {
                lienP = new Uri("ms-appx:///Assets/Parfait.png");
                Score += 3;
            }
            ProteineResult = new BitmapImage(lienP);


            if (aliments.Count == 0)
                Note = "Ton Panier est vide...";
            else if (aliments.Count < 2)
                Note = "Ton Panier n'est pas assez rempli...";
            else if (aliments.Count >= 2 && aliments.Count < 4)
                Score += 1;
            else if (aliments.Count == 4)
                Score += 2;
            else
                Score += 3;

            if (Score >= 10)
            {
                Score = 10;
                Note = "Waow ! Quel repas équilibré !";
            }

            Note = Score + "/10";
        }

        public string Note
        {
            get => note;
            set
            {
                note = value;
                OnPropertyChanged(nameof(Note));
            }
        }

        public BitmapImage GlucideResult
        {
            get => glucideResult;
            set
            {
                glucideResult = value;
                OnPropertyChanged(nameof(GlucideResult));
            }
        }

        public BitmapImage LipideResult
        {
            get => lipideResult;
            set
            {
                lipideResult = value;
                OnPropertyChanged(nameof(LipideResult));
            }
        }

        public BitmapImage ProteineResult
        {
            get => proteineResult;
            set
            {
                proteineResult = value;
                OnPropertyChanged(nameof(ProteineResult));
            }
        }
    }
}
