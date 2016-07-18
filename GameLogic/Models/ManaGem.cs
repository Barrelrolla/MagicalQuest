namespace GameLogic.Models
{
    using System.Drawing;
    using Enumerations;
    using Interfaces;

    public class ManaGem : IColored
    {
        public ManaGem(ColorType color, Position position)
        {
            this.Color = color;
            this.Position = position;
        }

        public ColorType Color { get; private set; }

        public Position Position { get; private set; }
    }
}
