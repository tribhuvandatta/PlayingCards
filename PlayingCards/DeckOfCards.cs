using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingCards
{
    public class DeckOfCards
    {
        private Card[] deck; //cards in a deck
        private int currentCard;//index of next card to be dealt (0-51)
        private static readonly int Number_Of_Cards = 52; //constant number of cards in a deck
        //random number generator
        private static readonly Random randomNumbers = new Random();

        public Card[] Deck //Deck property 
        {
            get
            {
                return deck;
            }

            set
            {
                deck = value;
            }
        }

        public int CurrentCard //current card property
        {
            get
            {
                return currentCard;
            }

            set
            {
                currentCard = value;
            }
        }

        public DeckOfCards()//constructor fills deck of cards
        {
            string[] faces = { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
            string[] suits = { "Hearts", "Diamond", "Clubs", "Spades" };
            Deck = new Card[Number_Of_Cards]; //create array of card objects
            CurrentCard = 0; //set currentCard so first card dealt is deck[0]
            //populate deck with card objects
            for (int count = 0; count < Deck.Length; count++)
            {
                Deck[count] = new Card(faces[count % 13], suits[count / 13]);
            }//end DeckofCards constructor
        }
        //shuffle deck of cards with one-pass algorithm
        public void Shuffle()
        {
            //after shuffling the card dealing should start again at deck[0]
            CurrentCard = 0;
            //for each card, pick another card(0-51) and swap them
            for (int first = 0; first < Deck.Length; first++)
            {
                //select a random number between 0 and 51
                int second = randomNumbers.Next(Number_Of_Cards);
                
                //swap current card with randomly selected card
                Card temp = Deck[first];
                Deck[first] = Deck[second];
                Deck[second] = temp;
            }//end for
        }//end method shuffle

        //deal one card
        public Card dealCard()
        {
            //determine whether cards remain to be dealt
            if (CurrentCard < Deck.Length)
                return Deck[CurrentCard++]; //return current card in array
            else
                throw new Exception("the card cannot be dealt"); //throw an exception to indicate that all cards were dealt
        }//end method dealCard
    }//end Class of DeckofCards
}//end namespace
