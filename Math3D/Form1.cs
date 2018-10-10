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
        float zoom;

        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            graphics = Graphics.FromImage(bitmap);
            zoom = (float)Screen.PrimaryScreen.Bounds.Width / 1.5f;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            float zoom = (float)Screen.PrimaryScreen.Bounds.Width / 1.5f;

            Cube cubeInit = new Cube();
            cubeInit.InitializeCube(100, 100, 100);
            Camera camera = new Camera(cubeInit.center.x, cubeInit.center.z, ((cubeInit.center.x * zoom) / cubeInit.center.x));

            cubeInit.count2D(camera, zoom, new PointF(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2));

            pictureBox1.Image = Drawing.drawingCube(cubeInit, graphics, bitmap);
            pictureBox1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            graphics = Graphics.FromImage(bitmap);

            cube = new Cube();
            cube.InitializeCube(Int32.Parse(textBox1.Text), Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text));
            Camera camera = new Camera(cube.center.x, cube.center.z, ((cube.center.x * zoom) / cube.center.x));

            cube.count2D(camera, zoom, new PointF(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2));

            bitmap = Drawing.drawingCube(cube, graphics, bitmap);
            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            graphics = Graphics.FromImage(bitmap);

            cube = new Cube();
            cube.InitializeCube(100, 100, 100);
            cube.xRotation(25);

            Camera camera = new Camera(cube.center.x, cube.center.z, ((cube.center.x * zoom) / cube.center.x));

            cube.count2D(camera, zoom, new PointF(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2));

            bitmap = Drawing.drawingCube(cube, graphics, bitmap);
            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            graphics = Graphics.FromImage(bitmap);

            cube = new Cube();
            cube.InitializeCube(100, 100, 100);
            cube.yRotation(25);

            Camera camera = new Camera(cube.center.x, cube.center.z, ((cube.center.x * zoom) / cube.center.x));

            cube.count2D(camera, zoom, new PointF(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2));

            bitmap = Drawing.drawingCube(cube, graphics, bitmap);
            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            bitmap = new Bitmap(pictureBox1.Size.Width, pictureBox1.Size.Height);
            graphics = Graphics.FromImage(bitmap);

            cube = new Cube();
            cube.InitializeCube(100, 100, 100);
            cube.zRotation(25);

            Camera camera = new Camera(cube.center.x, cube.center.z, ((cube.center.x * zoom) / cube.center.x));

            cube.count2D(camera, zoom, new PointF(pictureBox1.Size.Width / 2, pictureBox1.Size.Height / 2));

            bitmap = Drawing.drawingCube(cube, graphics, bitmap);
            pictureBox1.Image = bitmap;
            pictureBox1.Refresh();
        }
    }
}
