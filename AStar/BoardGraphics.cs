using AStar.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AStar
{
    public partial class BoardGraphics : Form
    {
        public static readonly int width = 25;
        public static readonly int height = 25;
        public enum CellState
        {
            Empty,
            StartFinish,
            Explored,
            FinalRoute
        }

        private const int cellSize = 16;
        private Bitmap[] cellStateBmps;
        private PictureBox[] cellPictures;
        private Point start;
        private Point finish;

        public BoardGraphics()
        {
            InitializeComponent();
            cellPictures = new PictureBox[width * height];
            cellStateBmps = new Bitmap[Enum.GetNames(typeof(CellState)).Length];
            cellStateBmps[(int)CellState.Empty] = Resources.box;
            cellStateBmps[(int)CellState.Explored] = Resources.box_grey;
            cellStateBmps[(int)CellState.StartFinish] = Resources.box_pink;
            cellStateBmps[(int)CellState.FinalRoute] = Resources.box_lightblue;

            ResizeBoard();
        }

        ~BoardGraphics()
        {
            foreach (var image in cellStateBmps)
                image.Dispose();
            foreach (var picture in cellPictures)
                picture.Dispose();
        }

        private void ResizeBoard()
        {
            int pixelWidth = cellSize * width + 25;
            int pixelHeight = cellSize * height + 50;
            this.Size = new Size(pixelWidth, pixelHeight);
        }

        private void BoardGraphics_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < width * height; i++)
            {
                CreateCell(i);
            }

            SetStartFinishCells();
        }

        private void SetStartFinishCells()
        {
            // Ask the user to select a start and finish point on the board
            AskStartFinishCells askStartEndCells = new AskStartFinishCells();
            askStartEndCells.ShowDialog();
            start = askStartEndCells.start;
            finish = askStartEndCells.finish;

            // If no valid selection is made, stop execution here
            if (start.X == -1 || finish.X == -1)
            {
                this.Close();
                return;
            }

            // Highlight the start and finish cells on the board
            SetCellState(start.X, start.Y, CellState.StartFinish);
            SetCellState(finish.X, finish.Y, CellState.StartFinish);
        }

        private void CreateCell(int index)
        {
            int col = index % width;
            int row = index / width;

            cellPictures[index] = new PictureBox
            {
                Name = String.Format("picCell{0}_{1}", col, row),
                Size = new Size(cellSize, cellSize),
                Location = new Point(col * cellSize, row * cellSize),
                Image = cellStateBmps[(int)CellState.Empty],
            };
            this.Controls.Add(cellPictures[index]);
        }

        private void SetCellState(int col, int row, CellState state)
        {
            cellPictures[row * width + col].Image = cellStateBmps[(int)state];
        }
    }
}
