namespace GameLogic.Models
{
    using System;
    using Enumerations;

    public class Board
    {
        private const int SizeX = 9;
        private const int SizeY = 9;
        private ManaGem[,] gemField;

        public Board()
        {
            this.gemField = new ManaGem[SizeX, SizeY];
            var random = new Random();
            for (int i = 0; i < SizeX; i++)
            {
                for (int j = 0; j < SizeY; j++)
                {
                    Position position = new Position(i, j);
                    ManaGem gem = new ManaGem((ColorType)random.Next(0, 5), position);
                    if (i > 1 && j > 1)
                    {
                        while (gemField[i - 1, j].Color == gemField[i - 2, j].Color && gemField[i - 1, j].Color == gem.Color
                            || gemField[i, j - 1].Color == gemField[i, j - 2].Color && gemField[i, j - 1].Color == gem.Color)
                        {
                            gem = new ManaGem((ColorType)random.Next(0, 5), position);
                        }
                    }
                    else if (i > 1)
                    {
                        while (gemField[i - 1, j].Color == gemField[i - 2, j].Color && gemField[i - 1, j].Color == gem.Color)
                        {
                            gem = new ManaGem((ColorType)random.Next(0, 5), position);
                        }
                    }
                    else if (j > 1)
                    {
                        while (gemField[i, j - 1].Color == gemField[i, j - 2].Color && gemField[i, j - 1].Color == gem.Color)
                        {
                            gem = new ManaGem((ColorType)random.Next(0, 5), position);
                        }
                    }

                    this.gemField[i, j] = gem;
                }
            }
        }

        public ManaGem[,] GemField
        {
            get { return this.gemField; }
            private set { this.gemField = value; }
        }
    }
}
