using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace DemoOpenGLBasicsCS
{
    public static class matrix
    {
        public static Vector3D startvektor;
        public static Matrix3D matrixstart;

        public static Vector3D Matrixturm;
        public static Matrix3D turmzuausleger;

        public static Vector3D Matrixausleger;
        public static Matrix3D auslegerzuseil;

        public static Vector3D Matrixseil;
        public static Vector3D SeilVector;

        public static string x, y, z;

        public static void zielpunkt()
        {
            Vector3D tempvector = Vector3D.Multiply(startvektor, matrixstart);
            Vector3D tempvector2 = Vector3D.Add(tempvector, Matrixturm);
            Vector3D tempvector3 = Vector3D.Multiply(tempvector2, turmzuausleger);
            Vector3D tempvector4 = Vector3D.Add(tempvector3, Matrixausleger);
            Vector3D tempvector5 = Vector3D.Multiply(tempvector4, auslegerzuseil);
            Vector3D tempvector6 = Vector3D.Add(tempvector5, Matrixseil);
            Vector3D resultvector = Vector3D.Add(tempvector6, SeilVector);

            x = "x: " + (double)resultvector.X;
            y = "y: " + (double)resultvector.Y;
            z = "z: " + (double)resultvector.Z;
        }
    }
}
