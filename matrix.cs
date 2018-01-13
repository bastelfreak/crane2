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
        private Matrix3D matrixstart;

        private Vector3D matrixturm;
        private Matrix3D turmzuausleger;

        private Vector3D matrixausleger;
        private Matrix3D auslegerzuseil;

        private Vector3D matrixseil;
        private Vector3D seilVector;
        private Matrix3D rotate_x_matrix;
        private Matrix3D rotate_y_matrix;
        private Matrix3D rotate_z_matrix;

        private Vector3D finalVector;

        public Vector3D Matrixausleger { get => matrixausleger; set => matrixausleger = value; }
        public Matrix3D Auslegerzuseil { get => auslegerzuseil; set => auslegerzuseil = value; }
        public Vector3D Matrixseil { get => matrixseil; set => matrixseil = value; }
        public Vector3D SeilVector { get => seilVector; set => seilVector = value; }
        public Matrix3D Turmzuausleger { get => turmzuausleger; set => turmzuausleger = value; }
        public Vector3D Matrixturm { get => matrixturm; set => matrixturm = value; }
        public Matrix3D Matrixstart { get => matrixstart; set => matrixstart = value; }
        public Vector3D InitialVector { get => initialVector; set => initialVector = value; }
        public Vector3D FinalVector { get => finalVector;}

        public double X { get => finalVector.X; }
        public double Y { get => finalVector.Y; }
        public double Z { get => finalVector.Z; }
        public Matrix3D Rotate_x_matrix { get => rotate_x_matrix;}
        public Matrix3D Rotate_z_matrix { get => rotate_z_matrix;}
        public Matrix3D Rotate_y_matrix { get => rotate_y_matrix;}

        public Matrix (Vector3D initialVector)
        {
            // this is the initial vector where our ball is hanging around
            this.initialVector = initialVector;
            // those coordinates represent the calculated position of the ball
            // this is equal to the initial vector at the beginning
            // allows us to display it in the GUI.cs
            finalVector = initialVector;
            double radiant = Degree2Radiant(90);
            rotate_x_matrix = new Matrix3D(
                    1, 0, 0, 0,
                    0, Math.Cos(radiant), -(Math.Sin(radiant)), 0,
                    0, Math.Sin(radiant), Math.Cos(radiant), 0,
                    0, 0, 0, 1);
            rotate_y_matrix = new Matrix3D(
                    Math.Cos(radiant), 0, Math.Sin(radiant), 0,
                    0, 1, 0, 0,
                    -(Math.Sin(radiant)), 0, Math.Cos(radiant), 0,
                    0, 0, 0, 1);
            rotate_z_matrix = new Matrix3D(
                    Math.Cos(radiant), -(Math.Sin(radiant)), 0, 0,
                    Math.Sin(radiant), Math.Cos(radiant), 0, 0,
                    0, 0, 1, 0,
                    0, 0, 0, 1);
        }
        /*public void zielpunkt()
        {
            
            Vector3D tempvector = Vector3D.Multiply(initialVector, Matrixstart);
            Vector3D tempvector2 = Vector3D.Add(tempvector, Matrixturm);
            Vector3D tempvector3 = Vector3D.Multiply(tempvector2, Turmzuausleger);
            Vector3D tempvector4 = Vector3D.Add(tempvector3, Matrixausleger);
            Vector3D tempvector5 = Vector3D.Multiply(tempvector4, Auslegerzuseil);
            Vector3D tempvector6 = Vector3D.Add(tempvector5, Matrixseil);
            finalVector = Vector3D.Add(tempvector6, SeilVector);
        }*/

        private double Degree2Radiant(double degree)
        {
            return degree * Math.PI / 180;
        }

        public Vector3D RotateY(double radiant)
        {
            // radiant is 0 in the initial rendering (before anyone pressed a button)
            if (radiant != 0)
            {
                rotate_y_matrix = new Matrix3D(
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
                Vector3D stretched = Vector3D.Multiply(new Vector3D(finalVector.X, 0, finalVector.Z), translate);
                finalVector = Vector3D.Add(stretched, new Vector3D(0, finalVector.Y, 0));
            }
            return finalVector;
        }

        public Vector3D TranslateY(double translate)
        {
            // translate is 0 in the initial rendering (before anyone pressed a button)
            if (translate != 0)
            {
                Vector3D stretched = Vector3D.Multiply(new Vector3D(0, finalVector.Y, 0), translate);
                finalVector = Vector3D.Add(stretched, new Vector3D(finalVector.X, 0, finalVector.Z));
            }
            return finalVector;
        }
    }
}
