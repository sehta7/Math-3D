using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    class Drawing
    {
        public static Bitmap drawingCube(Cube cube, Graphics graphics, Bitmap bitmap)
        {
            Pen pen = new Pen(Color.Black);

            //front
            graphics.DrawLines(pen, cube.front.tops2d);
            graphics.DrawLine(pen, cube.front.tops2d[3], cube.front.tops2d[0]);

            //back
            graphics.DrawLines(pen, cube.back.tops2d);
            graphics.DrawLine(pen, cube.back.tops2d[3], cube.back.tops2d[0]);

            //left
            graphics.DrawLines(pen, cube.left.tops2d);
            graphics.DrawLine(pen, cube.left.tops2d[3], cube.left.tops2d[0]);

            //right
            graphics.DrawLines(pen, cube.right.tops2d);
            graphics.DrawLine(pen, cube.right.tops2d[3], cube.right.tops2d[0]);

            //top
            graphics.DrawLines(pen, cube.top.tops2d);
            graphics.DrawLine(pen, cube.top.tops2d[3], cube.top.tops2d[0]);

            //bottom
            graphics.DrawLines(pen, cube.bottom.tops2d);
            graphics.DrawLine(pen, cube.bottom.tops2d[3], cube.bottom.tops2d[0]);

            return bitmap;
        }
    }
}
