namespace GameLogic.Models
{
    using System.Collections.Generic;
    using Enumerations;
    using Interfaces;

    public abstract class Planeswalker : IColored
    {
        public Planeswalker(ColorType color, Deck deck)
        {
            this.Color = color;
            this.Deck = deck;
        }

        public ColorType Color { get; private set; }

        public Deck Deck { get; private set; }
    }
}