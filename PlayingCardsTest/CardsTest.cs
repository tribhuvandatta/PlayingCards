using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayingCards;

namespace PlayingCardsTest
{
    public class CardsTest //Card shuffling and dealing
    {
        //excute application
        static void Main(string[] args)
        {
            try //exception handling
            {
                DeckOfCards myDeckOfCards = new DeckOfCards();
                myDeckOfCards.Shuffle(); //place cards in random order

                //print all 52 cards in the order in which they are dealt
                for (int i = 1; i <= 52; i++)
                {
                    Console.Write("{0,-25}", myDeckOfCards.dealCard()); //deal and display a card
                    if (i % 3 == 0) //output a new line after every third card
                    {
                        Console.WriteLine();
                    }
                } //end for
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
