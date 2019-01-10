using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyMeal
{
    public abstract partial class ListeAlimentsDisponibles
    {
        private static List<Aliment> GénérerAlimentsSains()
        {
            List<Aliment> aliments = new List<Aliment>();
            aliments.Add(new AlimentSain("Aubergine", 4, 4.4f, 0.6f, 1.7f));
            aliments.Add(new AlimentSain("Banane", 4, 16.9f, 0.5f, 1.0f));
            aliments.Add(new AlimentSain("Carotte", 4, 4.4f, 0.6f, 1.7f));
            aliments.Add(new AlimentSain("Champignon", 4, 0.2f, 1.5f, 3.1f));
            aliments.Add(new AlimentSain("Fraise", 3, 16.9f, 0.5f, 1.0f));
            aliments.Add(new AlimentSain("Oeuf", 4, 0.8f, 14.7f, 13.0f));
            aliments.Add(new AlimentSain("Pastèque", 5, 16.9f, 0.5f, 1.0f));
            aliments.Add(new AlimentSain("Pomme de Terre", 4, 26.0f, 6.0f, 3.4f));
            aliments.Add(new AlimentSain("Pomme", 4, 16.9f, 0.5f, 1.0f));
            aliments.Add(new AlimentSain("Poulet", 6, 0.1f, 9.7f, 26.7f));
            aliments.Add(new AlimentSain("Riz", 4, 43.1f, 1.3f, 5.6f));
            aliments.Add(new AlimentSain("Soupe", 5, 4.5f, 1.0f, 1.7f));
            aliments.Add(new AlimentSain("Tomate", 4, 4.4f, 0.6f, 1.7f));
            aliments.Add(new AlimentSain("Poisson", 5, 0.4f, 4.3f, 20.8f));
            aliments.Add(new AlimentSain("Viande", 5, 0.0f, 9.8f, 23.3f));
            aliments.Add(new AlimentSain("Fromage", 4, 2.3f, 21.0f, 12.5f));
            aliments.Add(new AlimentSain("Lait", 4, 16.2f, 4.8f, 8.4f));

            return aliments;
        }

        private static List<Aliment> GénérerAlimentsMalsains()
        {
            List<Aliment> aliments = new List<Aliment>();
            aliments.Add(new AlimentMalsain("Bonbons", 3, 81.7f, 4.7f, 2.7f));
            aliments.Add(new AlimentMalsain("Frites", 4, 26.0f, 6.0f, 3.4f));
            aliments.Add(new AlimentMalsain("Gâteau", 6, 44.2f, 15.0f, 5.4f));
            aliments.Add(new AlimentMalsain("Glace", 5, 24.7f, 7.7f, 3.7f));
            aliments.Add(new AlimentMalsain("Hamburger", 5, 29.5f, 12.2f, 11.7f));
            aliments.Add(new AlimentMalsain("Pizza", 6, 22.5f, 11.1f, 8.1f));

            return aliments;
        }

        public static List<Aliment> GénérerAliments()
        {
            Random aleatoire = new Random();
            List<Aliment> aliments = new List<Aliment>();
            List<Aliment> sains = GénérerAlimentsSains();
            List<Aliment> malsains = GénérerAlimentsMalsains();
            for(int i = 0; i < 6; i++)
            {
                int index;
                do
                {
                    index = aleatoire.Next(sains.Count);
                } while (aliments.Contains(sains[index]));
                aliments.Add(sains[index]);
            }

            for(int i = 0; i < 2; i++)
            {
                int index;
                do
                {
                    index = aleatoire.Next(malsains.Count);
                } while (aliments.Contains(malsains[index]));
                aliments.Add(malsains[index]);
            }
            return aliments;
        }
    }
}
