using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string[] ssplit;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { ssplit = textBox1.Text.Split(' '); } 
            catch { }
            if (comboBox1.SelectedItem.ToString() == "Треугольник")
            {
                Pen pen = new Pen(Color.Black, trackBar1.Value);
                Graphics g = pnlDraw.CreateGraphics();
                PointF point1 = new PointF(Convert.ToInt32(ssplit[0]), Convert.ToInt32(ssplit[1]));
                PointF point2 = new PointF(Convert.ToInt32(ssplit[2]), Convert.ToInt32(ssplit[3]));
                PointF point3 = new PointF(Convert.ToInt32(ssplit[4]), Convert.ToInt32(ssplit[5]));
                PointF[] polygon = {point1, point2, point3};
                g.DrawPolygon(pen, polygon);
            }
            else if (comboBox1.SelectedItem.ToString() == "Круг")
            {
                var graphics = pnlDraw.CreateGraphics();
                var pen = new Pen(Color.Blue, trackBar1.Value);
                graphics.DrawEllipse(pen, Convert.ToInt32(ssplit[0]), Convert.ToInt32(ssplit[1]), Convert.ToInt32(ssplit[2]), Convert.ToInt32(ssplit[3]));
            }
            else if (comboBox1.SelectedItem.ToString() == "Прямоугольник")
            {
                var graphics = pnlDraw.CreateGraphics();
                var pen = new Pen(Color.Blue, trackBar1.Value);
                graphics.DrawRectangle(pen, Convert.ToInt32(ssplit[0]), Convert.ToInt32(ssplit[1]), Convert.ToInt32(ssplit[2]), Convert.ToInt32(ssplit[3]));
                
            }
            else if (comboBox1.SelectedItem.ToString() == "Отрезок")
            {
                var graphics = pnlDraw.CreateGraphics();
                var pen = new Pen(Color.Blue, trackBar1.Value);
                graphics.DrawLine(new Pen(Color.Red, 10), Convert.ToInt32(ssplit[0]), Convert.ToInt32(ssplit[1]), Convert.ToInt32(ssplit[2]), Convert.ToInt32(ssplit[3]));
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics clear = pnlDraw.CreateGraphics();
            clear.Clear(Color.Silver);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
