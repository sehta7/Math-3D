using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math3D
{
    class Cube
    {
        public Side front;
        public Side back;
        public Side left;
        public Side right;
        public Side top;
        public Side bottom;

        public void InitializeCube(int width, int height, int depth)
        {
            //front
            Vector3D[] front = new Vector3D[4];
            front[0] = new Vector3D(width, height, 0);
            front[1] = new Vector3D(0, height, 0);
            front[2] = new Vector3D(width, 0, 0);
            front[3] = new Vector3D(0, 0, 0);
            this.front = new Side(front);

            //back
            Vector3D[] back = new Vector3D[4];
            back[0] = new Vector3D(width, height, depth);
            back[1] = new Vector3D(0, height, depth);
            back[2] = new Vector3D(width, 0, depth);
            back[3] = new Vector3D(0, 0, depth);
            this.back = new Side(back);

            //left
            Vector3D[] left = new Vector3D[4];
            left[0] = new Vector3D(0, height, depth);
            left[1] = new Vector3D(0, 0, depth);
            left[2] = new Vector3D(0, height, 0);
            left[3] = new Vector3D(0, 0, 0);
            this.left = new Side(left);

            //right
            Vector3D[] right = new Vector3D[4];
            right[0] = new Vector3D(width, height, 0);
            right[1] = new Vector3D(width, 0, 0);
            right[2] = new Vector3D(width, height, depth);
            right[3] = new Vector3D(width, 0, depth);
            this.right = new Side(right);

            //top
            Vector3D[] top = new Vector3D[4];
            top[0] = new Vector3D(width, height, depth);
            top[1] = new Vector3D(0, height, depth);
            top[2] = new Vector3D(width, height, 0);
            top[3] = new Vector3D(0, height, 0);
            this.top = new Side(top);

            //bottom
            Vector3D[] bottom = new Vector3D[4];
            bottom[0] = new Vector3D(width, 0, depth);
            bottom[1] = new Vector3D(0, 0, depth);
            bottom[2] = new Vector3D(width, 0, 0);
            bottom[3] = new Vector3D(0, 0, 0);
            this.bottom = new Side(bottom);
        }
    }
}
