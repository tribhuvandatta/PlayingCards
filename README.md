# PlayingCards and PlayingCardsTest
The PlayingCards consists of Card.cs and DeckOfCards.cs files which gives information about 
each card and operations performed on the deck respectively. 

Information about each card:

4 suits: hearts , spades , clubs , diamonds
Face values of: Ace , 2-10 , Jack , Queen , and King ).

Operations performed on the deck:

shuffle() - shuffle returns no value, but results in the cards in the deck being randomly permuted.
dealOneCard() - returns one card from the deck to the caller. 

The PlayingCardsTest project consists of CardsTest.cs. It tests the operations on the 
deck as mentioned above i.e., a call to shuffle() followed by 52 calls to dealOneCard() 
results in the caller being providedall 52 cards of the deck in a random order also
if the caller then makes a 53rd call dealOneCard(), no card is dealt.
