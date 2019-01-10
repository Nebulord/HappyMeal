using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Input;
using Windows.UI.Xaml.Controls;

namespace HappyMeal
{
    public abstract class Aliment
    {
        private string nom;
        private int poids;
        private float glucide; //en gramme
        private float lipide; //en gramme
        private float proteine; //en gramme

        public Aliment(string n, int p, float glu, float li, float pro)
        {
            Nom = n;
            Poids = p;
            Glucide = glu;
            Lipide = li;
            Proteine = pro;
        }

        public string Nom
        {
            get => nom;
            set => nom = value;
        }

        public int Poids
        {
            get => poids;
            set => poids = value;
        }

        public string ImageSource
        {
            get => "Assets/Food/" + Nom + ".png";
        }

        public float Glucide
        {
            get => glucide;
            set => glucide = value;
        }

        public float Lipide
        {
            get => lipide;
            set => lipide = value;
        }

        public float Proteine
        {
            get => proteine;
            set => proteine = value;
        }
    }
}
