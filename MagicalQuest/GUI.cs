using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLogic.Models;
using GameLogic.Enumerations;

namespace MagicalQuest
{
    public partial class GUI : Form
    {
        public GUI()
        {
            InitializeComponent();
        }

        private void GUI_Paint(object sender, PaintEventArgs e)
        {
            var gemSize = 30;
            var board = new Board();
            var size = Math.Sqrt(board.GemField.Length);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    switch (board.GemField[i, j].Color)
                    {
                        case ColorType.Green:
                            e.Graphics.FillRectangle(Brushes.Green, board.GemField[i, j].Position.X + i * gemSize, board.GemField[i, j].Position.Y + j * gemSize, gemSize, gemSize);
                            break;
                        case ColorType.Red:
                            e.Graphics.FillRectangle(Brushes.Red, board.GemField[i, j].Position.X + i * gemSize, board.GemField[i, j].Position.Y + j * gemSize, gemSize, gemSize);
                            break;
                        case ColorType.Blue:
                            e.Graphics.FillRectangle(Brushes.Blue, board.GemField[i, j].Position.X + i * gemSize, board.GemField[i, j].Position.Y + j * gemSize, gemSize, gemSize);
                            break;
                        case ColorType.White:
                            e.Graphics.FillRectangle(Brushes.White, board.GemField[i, j].Position.X + i * gemSize, board.GemField[i, j].Position.Y + j * gemSize, gemSize, gemSize);
                            break;
                        case ColorType.Black:
                            e.Graphics.FillRectangle(Brushes.Black, board.GemField[i, j].Position.X + i * gemSize, board.GemField[i, j].Position.Y + j * gemSize, gemSize, gemSize);
                            break;
                        default:
                            throw new InvalidOperationException("There should never be a different color than the predefined!");
                    }
                }
            }
        }
    }
}
