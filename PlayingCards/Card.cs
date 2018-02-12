using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    //Card class represents a playing card
    public class Card
    {
        private string face; //face of card(Ace,two,three......)
        private string suit;//suit of card(hearts,diamonds,....)
        
        //constructor that initializes card's face and suit
        public Card(string cardFace, string cardSuit)
        {
            Face = cardFace; //face card initialization 
            Suit = cardSuit; //suit card initialization
        }//end of the constructor
        
        //Face property
        public string Face
        {
            get
            {
                return face;
            }

            set
            {
                face = value;
            }
        }
        //Suit property
        public string Suit
        {
            get
            {
                return suit;
            }

            set
            {
                suit = value;
            }
        }
        //return string representation of card
        public override string ToString()
        {

            return string.Format("{0} of {1}", Face, Suit);
        } // end method ToString
    }//end class Card
}//end namespace 
