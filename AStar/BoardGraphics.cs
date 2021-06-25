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
using System.Windows.Input;

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
            Blocked,
            Explored,
            FinalRoute
        }

        private readonly int cellSize;
        private Bitmap[] cellStateBmps;
        private PictureBox[] cellPictures;
        private Point start;
        private Point finish;
        private bool spacePressed = false;
        private bool[,] board;

        public BoardGraphics()
        {
            InitializeComponent();
            board = new bool[width,height];
            cellPictures = new PictureBox[width * height];
            cellStateBmps = new Bitmap[Enum.GetNames(typeof(CellState)).Length];
            cellStateBmps[(int)CellState.Empty] = Resources.box;
            cellStateBmps[(int)CellState.StartFinish] = Resources.box_pink;
            cellStateBmps[(int)CellState.Blocked] = Resources.box_grey;
            cellStateBmps[(int)CellState.Explored] = Resources.box_lightblue;
            cellStateBmps[(int)CellState.FinalRoute] = Resources.box_green;
            cellSize = Math.Min(Resources.box.Width, Resources.box.Height);
            ResizeForm();
        }

        ~BoardGraphics()
        {
            foreach (var image in cellStateBmps)
                image.Dispose();
            foreach (var picture in cellPictures)
                picture.Dispose();
        }

        private void BoardGraphics_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < width * height; i++)
            {
                CreateCell(i);
            }

            SetStartFinishCells();
        }

        private void BoardGraphics_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
                spacePressed = true;
            if (e.KeyCode == Keys.Enter)
                FindPath();
        }

        private void BoardGraphics_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void CellPicture_MouseEnter(object sender, EventArgs e)
        {
            if (spacePressed)
            {
                string[] positionStrings = ((PictureBox)sender).Name.Split('_');
                int col = int.Parse(positionStrings[0]);
                int row = int.Parse(positionStrings[1]);
                SetCellState(col, row, CellState.Blocked);
                board[col,row] = true;
            }
        }

        private void FindPath()
        {
            AStar pathfinder = new AStar(this);
            pathfinder.SetBoard(board);
            pathfinder.FindPath(start, finish);
        }

        private void ResizeForm()
        {
            int pixelWidth = cellSize * width + 25;
            int pixelHeight = cellSize * height + 50;
            this.Size = new Size(pixelWidth, pixelHeight);
        }

        private void SetStartFinishCells()
        {
            // Ask the user to select a start and finish point on the board
            /*
            AskStartFinishCells askStartEndCells = new AskStartFinishCells();
            askStartEndCells.ShowDialog();
            start = askStartEndCells.start;
            finish = askStartEndCells.finish;
            */
            start = new Point(1, 1);
            finish = new Point(23, 23);

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
                Name = String.Format("{0}_{1}", col, row),
                Size = new Size(cellSize, cellSize),
                Location = new Point(col * cellSize, row * cellSize),
                Image = cellStateBmps[(int)CellState.Empty],
            };
            cellPictures[index].MouseEnter += new EventHandler(CellPicture_MouseEnter);
            this.Controls.Add(cellPictures[index]);
        }

        private void SetCellState(int col, int row, CellState state)
        {
            cellPictures[row * width + col].Image = cellStateBmps[(int)state];
        }
    }
}
