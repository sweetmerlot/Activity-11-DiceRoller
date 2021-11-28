using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity11_Dice
{
    class Dice
    {
        //declare variables, getters, and setters
        private int sides;
        private int faceUp;
        private static Random rand = new Random();
        public int GetSetSides
        {
            get { return sides; }
            set { sides = value; } 
        }
        public int GetSetFaceUp 
        {
            get {return faceUp; }
            set {faceUp = value; }
        }

        public Dice(int faces) {
            sides = faces;
            faceUp = 1;
        }

        public int RollDice()
        {
            this.faceUp = rand.Next(1, this.sides);
            return faceUp;
        }
        

    }
}
