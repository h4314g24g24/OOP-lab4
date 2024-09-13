using System;

using System.Drawing;

using System.Windows.Forms;

namespace OOp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(txtX.Text);
                double y = Convert.ToDouble(txtY.Text);

                
                Point point = new Point(x, y);

                string quarter = CoordinateSystem.DetermineQuarter(point);

             
                lblResult.Text = quarter;

               
                DrawPointOnGraph(point);
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Будь ласка, введіть коректні координати. Помилка: " + ex.Message);
            }

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {

        }
        private void DrawPointOnGraph(Point point)
        {
           
            Graphics g = pictureBoxGraph.CreateGraphics();
            g.Clear(Color.White); 

            
            Pen axisPen = new Pen(Color.Black, 2);
            int centerX = pictureBoxGraph.Width / 2;
            int centerY = pictureBoxGraph.Height / 2;

            g.DrawLine(axisPen, centerX, 0, centerX, pictureBoxGraph.Height); 
            g.DrawLine(axisPen, 0, centerY, pictureBoxGraph.Width, centerY); 

            
            SolidBrush brush = new SolidBrush(Color.Black); 
            if (point.X < 0 && point.Y > 0) brush.Color = Color.Black; 
            else if (point.X < 0 && point.Y < 0) brush.Color = Color.Black; 
            else if (point.X > 0 && point.Y < 0) brush.Color = Color.Black; 

            int xGraph = centerX + (int)(point.X * 10); 
            int yGraph = centerY - (int)(point.Y * 10); 
            g.FillEllipse(brush, xGraph, yGraph, 10, 10); 
        }
    }
}
