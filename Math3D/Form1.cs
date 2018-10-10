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
        Camera camera;

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

            camera = new Camera();
            camera.position.x = Int32.Parse(textBox1.Text) / 2;
            camera.position.y = Int32.Parse(textBox2.Text) / 2;
            camera.position.z = ((Int32.Parse(textBox1.Text) / 2) * zoom) / (Int32.Parse(textBox1.Text) / 2);

            cube = new Cube();
            cube.InitializeCube(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
            cube.count2D(camera, zoom, new PointF(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2));
        }
    }
}
