﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerGraphics.Tools
{
    class Vector3
    {
        public float x;
        public float y;
        public float z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        float Distance(Vector3 vector3)
        {
            return 1.0f;
        }
        static Vector3 Zero()
        {
            return new Vector3(0, 0, 0);
        }
    }
}
