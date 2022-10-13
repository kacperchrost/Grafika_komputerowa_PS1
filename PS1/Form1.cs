using Microsoft.VisualBasic.Devices;

namespace PS1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point newLinePoint1, newLinePoint2;
        private readonly List<Point> linePoints1 = new();
        private readonly List<Point> linePoints2 = new();

        private Point newRectanglePoint, initialClick;
        private Point newRectangleParameters;
        private readonly List<Point> rectanglePoints = new();
        private readonly List<Point> rectangleParameters = new();

        private Point newEllipsePoint;
        private Point newEllipseParameters;
        private readonly List<Point> ellipsePoints = new();
        private readonly List<Point> ellipseParameters = new();

        private bool IsDrawing = false;

        private const int objectRadius = 3;


        private void clearButton_Click(object sender, EventArgs e)
        {
            Graphics g = myPictureBox.CreateGraphics();
            linePoints1.Clear();
            linePoints2.Clear();
            rectanglePoints.Clear();
            rectangleParameters.Clear();
            ellipseParameters.Clear();
            ellipsePoints.Clear();
            g.Clear(Color.White);
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void rectangleDraw_Click(object sender, EventArgs e)
        {
            newRectanglePoint = new Point((int)rectanglesX.Value, (int)rectanglesY.Value);
            newRectangleParameters = new Point((int)rectanglesWidth.Value, (int)rectanglesHeight.Value);

            rectanglePoints.Add(newRectanglePoint);
            rectangleParameters.Add(newRectangleParameters);
            myPictureBox.Invalidate();
        }

        private void ellipsesDrawButton_Click(object sender, EventArgs e)
        {
            newEllipsePoint = new Point((int)ellipsesX.Value, (int)ellipsesY.Value);
            newEllipseParameters = new Point((int)ellipsesRadius.Value, (int)ellipsesRadius.Value);

            ellipsePoints.Add(newEllipsePoint);
            ellipseParameters.Add(newEllipseParameters);

            myPictureBox.Invalidate();
        }

        private void drawLineButton_Click(object sender, EventArgs e)
        {
            newLinePoint1 = new Point((int)linesXStart.Value, (int)linesYStart.Value);
            newLinePoint2 = new Point((int)linesXEnd.Value, (int)linesYEnd.Value);

            linePoints1.Add(newLinePoint1);
            linePoints2.Add(newLinePoint2);

            myPictureBox.Invalidate();
        }

        private void MyPictureBox_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < linePoints1.Count; i++)
            {
                e.Graphics.DrawLine(Pens.Blue, linePoints1[i], linePoints2[i]);
            }

            for (int i = 0; i < rectanglePoints.Count; i++)
            {
                e.Graphics.DrawRectangle(Pens.Blue, rectanglePoints[i].X, rectanglePoints[i].Y, rectangleParameters[i].X, rectangleParameters[i].Y);

                Rectangle rectangle = new Rectangle(rectanglePoints[i].X - objectRadius, rectanglePoints[i].Y - objectRadius, 2 * objectRadius + 1, 2 * objectRadius + 1);

                Rectangle rectangle1 = new Rectangle(rectanglePoints[i].X - objectRadius + rectangleParameters[i].X, rectanglePoints[i].Y - objectRadius + rectangleParameters[i].Y, 2 * objectRadius + 1, 2 * objectRadius + 1);
            }

            for (int i = 0; i < ellipsePoints.Count; i++)
            {
                e.Graphics.DrawEllipse(Pens.Blue, ellipsePoints[i].X, ellipsePoints[i].Y, ellipseParameters[i].X, ellipseParameters[i].Y);

                Rectangle rectangle = new Rectangle(ellipsePoints[i].X - objectRadius * 2, ellipsePoints[i].Y - objectRadius, 2 * objectRadius + 1, 2 * objectRadius + 1);

                Rectangle rectangle1 = new Rectangle(ellipsePoints[i].X - objectRadius + ellipseParameters[i].X, ellipsePoints[i].Y - objectRadius + ellipseParameters[i].Y, 2 * objectRadius + 1, 2 * objectRadius + 1);
            }

            if (shapesControl.SelectedTab == shapesControl.TabPages["lines"])
                if (IsDrawing) e.Graphics.DrawLine(Pens.Red, newLinePoint1, newLinePoint2);

            if (shapesControl.SelectedTab == shapesControl.TabPages["rectangles"])
                if (IsDrawing) e.Graphics.DrawRectangle(Pens.Red, newRectanglePoint.X, newRectanglePoint.Y, newRectangleParameters.X, newRectangleParameters.Y);

            if (shapesControl.SelectedTab == shapesControl.TabPages["ellipses"])
                if (IsDrawing) e.Graphics.DrawEllipse(Pens.Red, newEllipsePoint.X, newEllipsePoint.Y, newEllipseParameters.X, newEllipseParameters.Y);

        }

        private void MyPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            myPictureBox.MouseMove -= MyPictureBox_MouseMove;
            myPictureBox.MouseMove += MyPictureBox_MouseMove_Drawing;
            myPictureBox.MouseUp += MyPictureBox_MouseUp_Drawing;

            IsDrawing = true;

            newLinePoint1 = new Point(e.X, e.Y);
            newLinePoint2 = new Point(e.X, e.Y);


            initialClick = new Point(e.X, e.Y);
            newEllipsePoint = new Point(e.X, e.Y);
        }

        private void MyPictureBox_MouseMove_Drawing(object sender, MouseEventArgs e)
        {
            if (shapesControl.SelectedTab == shapesControl.TabPages["lines"])
                newLinePoint2 = new Point(e.X, e.Y);
            else if (shapesControl.SelectedTab == shapesControl.TabPages["rectangles"])
            {
                newRectangleParameters = new Point(Math.Abs(e.X - initialClick.X), Math.Abs(e.Y - initialClick.Y));
                newRectanglePoint = new Point(Math.Min(e.X, initialClick.X), Math.Min(e.Y, initialClick.Y));
            }
            else if (shapesControl.SelectedTab == shapesControl.TabPages["ellipses"])
                newEllipseParameters = new Point(e.X - newEllipsePoint.X, e.Y - newEllipsePoint.Y);

            myPictureBox.Invalidate();
        }

        private void MyPictureBox_MouseUp_Drawing(object sender, MouseEventArgs e)
        {
            IsDrawing = false;

            myPictureBox.MouseMove -= MyPictureBox_MouseMove_Drawing;
            myPictureBox.MouseMove += MyPictureBox_MouseMove;
            myPictureBox.MouseUp -= MyPictureBox_MouseUp_Drawing;

            if (shapesControl.SelectedTab == shapesControl.TabPages["lines"])
            {
                linePoints1.Add(newLinePoint1);
                linePoints2.Add(newLinePoint2);
            }
            else if (shapesControl.SelectedTab == shapesControl.TabPages["rectangles"])
            {
                rectanglePoints.Add(newRectanglePoint);
                rectangleParameters.Add(newRectangleParameters);
            }
            else if (shapesControl.SelectedTab == shapesControl.TabPages["ellipses"])
            {
                ellipsePoints.Add(newEllipsePoint);
                ellipseParameters.Add(newEllipseParameters);
            }

            myPictureBox.Invalidate();
        }

        private void MyPictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor newCursor = Cursors.Cross;

            if (myPictureBox.Cursor != newCursor)
                myPictureBox.Cursor = newCursor;

        }
    }
}