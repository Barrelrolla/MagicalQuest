namespace GameLogic.Models
{
    using System.Collections.Generic;

    public class Deck
    {
        private const int cardCount = 10;
        private List<Card> deck;

        public Deck()
        {
            this.deck = new List<Card>();
        }
    }
}