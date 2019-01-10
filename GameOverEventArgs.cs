using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyMeal
{
    public class GameOverEventArgs : EventArgs
    {
        private string motif;

        public GameOverEventArgs(string m)
        {
            Motif = m;
        }

        public string Motif
        {
            get => motif;
            set => motif = value;
        }
    }
}
