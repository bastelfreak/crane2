using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace DemoOpenGLBasicsCS
{
    public class Matrix
    {
        private Vector3D initialVector;


        private Vector3D finalVector;

        public Vector3D InitialVector { get => initialVector; set => initialVector = value; }
        public Vector3D FinalVector { get => finalVector;}

        public double X { get => finalVector.X; }
        public double Y { get => finalVector.Y; }
        public double Z { get => finalVector.Z; }


        public Matrix (Vector3D initialVector)
        {
            // this is the initial vector where our ball is hanging around
            this.initialVector = initialVector;
            // those coordinates represent the calculated position of the ball
            // this is equal to the initial vector at the beginning
            // allows us to display it in the GUI.cs
            finalVector = initialVector;
        }

        // we maybe need that in the future again?
        private double Degree2Radiant(double degree)
        {
            return degree * Math.PI / 180;
        }

        public Vector3D RotateY(double radiant)
        {
            // radiant is 0 in the initial rendering (before anyone pressed a button)
            if (radiant != 0)
            {
                Matrix3D rotate_y_matrix = new Matrix3D(
                        Math.Cos(radiant), 0, Math.Sin(radiant), 0,
                        0, 1, 0, 0,
                        -(Math.Sin(radiant)), 0, Math.Cos(radiant), 0,
                        0, 0, 0, 1);
                finalVector = Vector3D.Multiply(finalVector, rotate_z_matrix);
            }
            return finalVector;
        }

        public Vector3D TranslateXZ(double translate)
        {
            // translate is 0 in the initial rendering (before anyone pressed a button)
            if (translate != 0)
            {
                Matrix3D trans_matrix = new Matrix3D(
                    translate, 0, 0, 0,
                    0, 1, 0, 0,
                    0, 0, translate, 0,
                    0, 0, 0, 1);
                finalVector = Vector3D.Multiply(finalVector, trans_matrix);
            }
            return finalVector;
        }

        public Vector3D TranslateY(double translate)
        {
            // translate is 0 in the initial rendering (before anyone pressed a button)
            if (translate != 0)
            {
                Matrix3D trans_matrix = new Matrix3D(
                1, 0, 0, 0,
                0, translate, 0, 0,
                0, 0, 1, 0,
                0, 0, 0, 1);
                finalVector = Vector3D.Multiply(finalVector, trans_matrix);
            }
            return finalVector;
        }
    }
}
