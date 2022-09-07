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
        struct Knap
        {
            public Rectangle rect;
            public Color colour;
            public Knap(Rectangle rect, Color colour)
            {
                this.rect = rect;
                this.colour = colour;
            }
        }
        Random random = new Random();
        List<List<Knap>> KnapMatrix = new List<List<Knap>>();
        Rectangle bille;

        int rectangleSize = 0;
        int billeX = 0;
        int billeY = 0;

        bool goingRight;

        int redCounter = 0;
        int greenCounter = 0;
        int blueCounter = 0;
        int yellowCounter = 0;
        int greyCounter = 0;

        Task delay = Task.Delay(1000);
        public WinForm()
        {
            InitializeComponent();
            bille = new Rectangle(billeX * rectangleSize, billeY * rectangleSize, rectangleSize, rectangleSize);
        }
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (KnapMatrix.Count > 0 && KnapMatrix[0].Count > 0)
            {
                redCounter = 0;
                greenCounter = 0;
                blueCounter = 0;
                yellowCounter = 0;
                greyCounter = 0;

                BilleSearch();
            }
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {

            billeX = 0;
            billeY = 0;

            redCounter = 0;
            greenCounter = 0;
            blueCounter = 0;
            yellowCounter = 0;
            greyCounter = 0;

            NumericUpDownColumns.Value = 0;
            NumericUpDownRows.Value = 0;
            randomPlacementPicker.Checked = false;

            KnapMatrix.Clear();
            boardCanvas.Refresh();
        }
        private void RandomPlacementPicker_CheckedChanged(object sender, EventArgs e)
        {
            if (randomPlacementPicker.Checked)
            {
                //Randomize bille grid placement
                billeX = random.Next(KnapMatrix.Count);
                billeY = random.Next(KnapMatrix[0].Count);
                boardCanvas.Refresh();
            }
            else
            {
                billeX = 0;
                billeY = 0;
                boardCanvas.Refresh();
            }
        }
        private async void BoardCanvas_Paint(object sender, PaintEventArgs e)
        {
            DrawBoard(e);
            DrawBille(e);
            labelRedValue.Text = redCounter.ToString();
            labelGreenValue.Text = greenCounter.ToString();
            labelBlueValue.Text = blueCounter.ToString();
            labelYellowValue.Text = yellowCounter.ToString();
            labelGreyValue.Text = greyCounter.ToString();
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
                    fillPen.Color = KnapMatrix[i][j].colour;
                    e.Graphics.FillRectangle(fillPen, KnapMatrix[i][j].rect);
                    e.Graphics.DrawRectangle(borderPen, KnapMatrix[i][j].rect);
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
            for (int i = 0; i < (int)NumericUpDownColumns.Value; i++)
            {
                KnapMatrix.Add(new List<Knap>());
                for (int j = 0; j < (int)NumericUpDownRows.Value; j++)
                {
                    Rectangle rect = new Rectangle(i * rectangleSize, j * rectangleSize, rectangleSize, rectangleSize);
                    Knap knap = new Knap(rect, GiveRandomColour());
                    KnapMatrix[i].Add(knap);
                }
            }
        }
        private void SetRectangleSize()
        {
            int h = 0, w = 0;
            if (MoreThanZeroRowsAndColumns())
            {
                h = boardCanvas.Height / (int)NumericUpDownRows.Value;
                w = boardCanvas.Width / (int)NumericUpDownColumns.Value;
            }
            rectangleSize = Math.Min(h, w);
        }
        private bool MoreThanZeroRowsAndColumns()
        {
            return (NumericUpDownRows.Value > 0 && NumericUpDownColumns.Value > 0);
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
        private void NumericUpDownColumns_ValueChanged(object sender, EventArgs e)
        {
            InitializeChosenButtons();
            boardCanvas.Refresh();
        }
        private void NumericUpDownRows_ValueChanged(object sender, EventArgs e)
        {
            InitializeChosenButtons();
            boardCanvas.Refresh();
        }
        private void MoveBille(string direction)
        {
            if (KnapMatrix.Count != 0 && KnapMatrix[0].Count != 0)
            {
                if (direction == "UP" && billeY != 0) { CheckColour(billeX, billeY); billeY--; }
                if (direction == "DOWN" && billeY != KnapMatrix[0].Count - 1) { CheckColour(billeX, billeY); billeY++; }
                if (direction == "LEFT" && billeX != 0) { CheckColour(billeX, billeY); billeX--; }
                if (direction == "RIGHT" && billeX != KnapMatrix.Count - 1) { CheckColour(billeX, billeY); billeX++; }
                boardCanvas.Refresh();
            }
        }
        private void BilleSearch() // den tæller dobbelt
        {
            BilleHome();
            goingRight = true;

            while (NotAtEnd())
            {
                for (int i = 0; i < KnapMatrix.Count; i++)
                {
                    if (goingRight) { MoveBille("RIGHT"); }
                    else { MoveBille("LEFT"); }
                }

                MoveBille("DOWN");
                goingRight ^= true;
            }
            //CheckColour(billeX, billeY);

        }
        private bool NotAtEnd()
        {

            if (billeY == KnapMatrix[0].Count - 1)
            {
                if (!goingRight && billeX == KnapMatrix.Count - 1)
                {
                    return false;
                }

                if (goingRight && billeX == 0)
                {
                    return false;
                }
            }

            return true;
        }
        private void BilleHome()
        {
            while (billeX != 0 && billeY != 0)
            {
                MoveBille("UP");
                MoveBille("LEFT");
            }
            redCounter = 0;
            greenCounter = 0;
            blueCounter = 0;
            yellowCounter = 0;
            greyCounter = 0;
        }
        private void CheckColour(int x, int y)
        {
            if (KnapMatrix[x][y].colour == Color.Red) { redCounter++; }
            if (KnapMatrix[x][y].colour == Color.Green) { greenCounter++; }
            if (KnapMatrix[x][y].colour == Color.Blue) { blueCounter++; }
            if (KnapMatrix[x][y].colour == Color.Yellow) { yellowCounter++; }
            if (KnapMatrix[x][y].colour == Color.Gray) { greyCounter++; }
        }
    }
}