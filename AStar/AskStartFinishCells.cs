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
    public partial class AskStartFinishCells : Form
    {
        public Point start;
        public Point finish;

        public AskStartFinishCells()
        {
            InitializeComponent();
            lblInfo.Text = String.Format("Width: {0}, Height: {1}", BoardGraphics.width, BoardGraphics.height);
            start = new Point(-1, -1);
            finish = new Point(-1, -1);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                // This will raise a FormatException error if the user does not enter a whole number in each textbox.
                int startX = int.Parse(inpStartX.Text);
                int startY = int.Parse(inpStartY.Text);
                int finishX = int.Parse(inpFinishX.Text);
                int finishY = int.Parse(inpFinishY.Text);

                // This checks that the user has entered cells within range
                if (startX < 0 || startX >= BoardGraphics.width || finishX < 0 || finishX >= BoardGraphics.width
                    || startY < 0 || startY >= BoardGraphics.height || finishY < 0 || finishY >= BoardGraphics.height)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Invalid coordinates given, please make sure they are within the board size", "Invalid Coordinates", buttons);
                }
                else
                {
                    // Success! Set the public values so that the calling form can see the results, then close this form.
                    this.start = new Point(startX, startY);
                    this.finish = new Point(finishX, finishY);
                    this.Close();
                }
            }
            catch (FormatException error)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Invalid coordinates given, please make sure they are valid numbers", "Invalid Coordinates", buttons);
            }
        }
    }
}
