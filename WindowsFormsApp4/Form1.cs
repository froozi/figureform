﻿using System;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Треугольник")
            {
                var graphics = pnlDraw.CreateGraphics();
                var pen = new Pen(Color.Red, 5);
                graphics.Draw
            }
            else if (comboBox1.SelectedItem.ToString() == "Круг")
            {
                var graphics = pnlDraw.CreateGraphics();
                var pen = new Pen(Color.Blue, 4);
                graphics.DrawEllipse(pen, 50, 50, 60, 60);
                graphics.DrawLine(new Pen(Color.Red, 10), new Point(1, 1), new Point(100, 100));
            }
            else if (comboBox1.SelectedItem.ToString() == "Прямоугольник")
            {
            
            }
            else if (comboBox1.SelectedItem.ToString() == "Отрезок")
            {

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics clear = pnlDraw.CreateGraphics();
            clear.Clear(Color.Silver);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
