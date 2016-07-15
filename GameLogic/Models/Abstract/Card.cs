namespace GameLogic.Models
{
    using Enumerations;
    using Interfaces;

    public abstract class Card : IColored
    {
        public ColorType Color { get; private set; }
    }
}