using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace HappyMeal
{
    public class AlimentSain : Aliment
    {
        public AlimentSain(string n, int p, float glu, float li, float pro) : base(n, p, glu, li, pro)
        {
        }
    }
}
