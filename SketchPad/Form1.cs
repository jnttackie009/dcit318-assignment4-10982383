using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SketchPad
{
    public partial class Form1 : Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool drawing = false;
        private Pen drawPen = new Pen(Color.Black, 2);
        private Bitmap drawingBitmap;
        private Graphics drawingGraphics;

        public Form1()
        {
            InitializeComponent();
            InitializeDrawing();
        }

        private void InitializeDrawing()
        {
          
            Canvas.BackColor = Color.White; 
            Canvas.BorderStyle = BorderStyle.FixedSingle; 
            drawingGraphics = Canvas.CreateGraphics(); 

            Canvas.Paint += DrawingPanel_Paint;
            Canvas.MouseDown += DrawingPanel_MouseDown;
            Canvas.MouseMove += DrawingPanel_MouseMove;
            Canvas.MouseUp += DrawingPanel_MouseUp;
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.Location;
            drawing = true;
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                endPoint = e.Location;
                drawingGraphics.DrawLine(drawPen, startPoint, endPoint);
                startPoint = endPoint; 
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
           
            drawingGraphics.Clear(Canvas.BackColor); 
        }
        
    }
}
