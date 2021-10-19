using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace lab_4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Point[] points =
                {
                    new Point(360,  650),
                     new Point(630, 650),
                     new Point(640, 630),
                     new Point(610, 610),
                     new Point(540, 600),
                     new Point(600, 550),
                     new Point(655, 650),
                     new Point(700, 650),
                     new Point(710, 630),
                     new Point(700, 610),
                     new Point(680, 610),
                     new Point(660, 530),
                     new Point(700, 400),
                     new Point(700, 320),
                     new Point(680, 280),
                     new Point(680, 260),
                     new Point(730, 240),
                     new Point(750, 200),
                     new Point(730, 180),
                     new Point(730, 140),
                     new Point(675, 100),
                     new Point(660, 45),
                     new Point(620, 70),
                     new Point(570, 140),
                     new Point(540, 240),
                     new Point(370, 420),
                     new Point(350, 490),
                     new Point(360, 600),
                     new Point(330, 590),
                     new Point(330, 475),
                     new Point(360, 300),
                     new Point(360, 260),
                     new Point(300, 200),
                     new Point(275, 225),
                     new Point(320, 300),
                     new Point(270, 490),
                     new Point(290, 575),
                     new Point(360,  650)
                };

            g = CreateGraphics();
            g.Clear(Color.Black);
            g.DrawLines(new Pen(Color.White, 5), points);
        }
    }
}
