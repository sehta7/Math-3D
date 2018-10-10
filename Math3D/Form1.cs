using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Math3D
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Bitmap bitmap;
        Cube cube;

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            graphics = Graphics.FromImage(bitmap);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float zoom = (float)Screen.PrimaryScreen.Bounds.Width / 1.5f;

            cube = new Cube();
            cube.InitializeCube(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
            Camera camera = new Camera(cube.center.x, cube.center.z, ((cube.center.x * zoom) / cube.center.x));

            cube.count2D(camera, zoom, new PointF(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2));
        }
    }
}
