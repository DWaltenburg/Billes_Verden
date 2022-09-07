using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Billes_Verden
{
    public partial class WinForm : Form
    {
        Random random = new Random();
        List<List<Rectangle>> KnapMatrix = new List<List<Rectangle>>();
        Rectangle bille;

        int rectangleSize = 0;
        int billeX = 0;
        int billeY = 0;

        public WinForm()
        {
            bille = new Rectangle(billeX * rectangleSize, billeY * rectangleSize, rectangleSize, rectangleSize);
            InitializeComponent();
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            InitializeChosenButtons();
            boardCanvas.Refresh();
            BilleSearch();
            //execute bille search
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Hide bille


            //reset board
            KnapMatrix.Clear();
            boardCanvas.Refresh();

            //reset input values
            numericUpDownColumns.Value = 0;
            numericUpDownRows.Value = 0;
            randomPlacementPicker.Checked = false;
        }
        private void RandomPlacementPicker_CheckedChanged(object sender, EventArgs e)
        {
            if (randomPlacementPicker.Checked)
            {
                //Randomize bille grid placement
                //grid index * rectangeSize
                //to be centered on the button it might be best to then add (half the rectangle size minus half the bille size)?
            }
        }
        private void BoardCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawBoard(e);
            DrawBille(e);
        }

        private void DrawBoard(PaintEventArgs e)
        {
            SolidBrush fillPen = new SolidBrush(Color.Black);

            Pen borderPen = new Pen(Color.Black, 2)
            {
                Alignment = System.Drawing.Drawing2D.PenAlignment.Inset
            };
            for (int i = 0; i < KnapMatrix.Count; i++)
            {
                for (int j = 0; j < KnapMatrix[0].Count; j++)
                {
                    fillPen.Color = GiveRandomColour();
                    e.Graphics.FillRectangle(fillPen, KnapMatrix[i][j]);
                    e.Graphics.DrawRectangle(borderPen, KnapMatrix[i][j]);
                }
            }
            fillPen.Dispose();
            borderPen.Dispose();
        }
        private void DrawBille(PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            bille.Location = new Point(billeX * rectangleSize, billeY * rectangleSize);
            bille.Size = new Size(rectangleSize, rectangleSize);
            e.Graphics.DrawEllipse(pen, bille);
            pen.Dispose();
        }
        private void InitializeChosenButtons()
        {
            KnapMatrix.Clear();
            SetRectangleSize();
            for (int i = 0; i < (int)numericUpDownColumns.Value; i++)
            {
                KnapMatrix.Add(new List<Rectangle>());
                for (int j = 0; j < (int)numericUpDownRows.Value; j++)
                {
                    Rectangle rect = new Rectangle(i * rectangleSize, j * rectangleSize, rectangleSize, rectangleSize);
                    KnapMatrix[i].Add(rect);
                }
            }
        }
        private void SetRectangleSize()
        {
            int h = 0, w = 0;
            if (MoreThanZeroRowsAndColumns())
            {
                h = boardCanvas.Height / (int)numericUpDownRows.Value;
                w = boardCanvas.Width / (int)numericUpDownColumns.Value;
            }
            rectangleSize = Math.Min(h, w);
        }
        private bool MoreThanZeroRowsAndColumns()
        {
            return (numericUpDownRows.Value > 0 && numericUpDownColumns.Value > 0);
        }
        private Color GiveRandomColour()
        {
            int num = random.Next(5);
            if (num == 0) { return Color.Red; }
            if (num == 1) { return Color.Green; }
            if (num == 2) { return Color.Blue; }
            if (num == 3) { return Color.Yellow; }
            if (num == 4) { return Color.Gray; }
            return Color.Black;
        }
        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
        private void MoveBille(string direction)
        {
            if (direction == "UP" && billeX != 0) { billeX--; }
            if (direction == "DOWN" && billeX != KnapMatrix.Count - 1) { billeX++; }
            if (direction == "LEFT" && billeY != 0) { billeY--; }
            if (direction == "RIGHT" && billeY != KnapMatrix[0].Count - 1) { billeY++; }
        }
        private void BilleSearch()
        {
            //Now program the search algorithms

            //MoveBille("UP");
            MoveBille("RIGHT");
            MoveBille("DOWN");
            //MoveBille("LEFT");


        }
    }
}