namespace GameLogic.Models.Planeswalkers
{
    using Enumerations;
    using Interfaces;

    public class Nissa : Planeswalker, IColored
    {
        public Nissa() : base(ColorType.Green, new Deck())
        {
        }
    }
}
