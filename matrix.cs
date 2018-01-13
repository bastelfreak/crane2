using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace DemoOpenGLBasicsCS
{
    public class matrix
    {
        private Vector3D startvektor;
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

        private double z;
        private double x;
        private double y;

        public Vector3D Matrixausleger { get => matrixausleger; set => matrixausleger = value; }
        public Matrix3D Auslegerzuseil { get => auslegerzuseil; set => auslegerzuseil = value; }
        public Vector3D Matrixseil { get => matrixseil; set => matrixseil = value; }
        public Vector3D SeilVector { get => seilVector; set => seilVector = value; }
        public Matrix3D Turmzuausleger { get => turmzuausleger; set => turmzuausleger = value; }
        public Vector3D Matrixturm { get => matrixturm; set => matrixturm = value; }
        public Matrix3D Matrixstart { get => matrixstart; set => matrixstart = value; }
        public double X { get => x; }
        public double Y { get => y; }
        public double Z { get => z; }
        public Matrix3D Rotate_x_matrix { get => rotate_x_matrix;}
        public Matrix3D Rotate_z_matrix { get => rotate_z_matrix;}
        public Matrix3D Rotate_y_matrix { get => rotate_y_matrix;}

        public matrix ()
        {
            startvektor = new Vector3D(0.0, 0.0, 0.0);
            rotate_x_matrix = new Matrix3D(
                    1, 0, 0, 0,
                    0, Math.Cos(Degree2Radiant(90)), -(Math.Sin(Degree2Radiant(90))), 0,
                    0, Math.Sin(Degree2Radiant(90)), Math.Cos(Degree2Radiant(90)), 0,
                    0, 0, 0, 1);
            rotate_y_matrix = new Matrix3D(
                    Math.Cos(Degree2Radiant(90)), 0, Math.Sin(Degree2Radiant(90)), 0,
                    0, 1, 0, 0,
                    -(Math.Sin(Degree2Radiant(90))), 0, Math.Cos(Degree2Radiant(90)), 0,
                    0, 0, 0, 1);
            rotate_z_matrix = new Matrix3D(
                    Math.Cos(Degree2Radiant(90)), -(Math.Sin(Degree2Radiant(90))), 0, 0,
                    Math.Sin(Degree2Radiant(90)), Math.Cos(Degree2Radiant(90)), 0, 0,
                    0, 0, 1, 0,
                    0, 0, 0, 1);
        }
        public void zielpunkt()
        {
            Vector3D tempvector = Vector3D.Multiply(startvektor, Matrixstart);
            Vector3D tempvector2 = Vector3D.Add(tempvector, Matrixturm);
            Vector3D tempvector3 = Vector3D.Multiply(tempvector2, Turmzuausleger);
            Vector3D tempvector4 = Vector3D.Add(tempvector3, Matrixausleger);
            Vector3D tempvector5 = Vector3D.Multiply(tempvector4, Auslegerzuseil);
            Vector3D tempvector6 = Vector3D.Add(tempvector5, Matrixseil);
            Vector3D resultvector = Vector3D.Add(tempvector6, SeilVector);

            x = Math.Round(resultvector.X, 2);
            y = Math.Round(resultvector.Y, 2);
            z = Math.Round(resultvector.Z, 2);
        }

        private double Degree2Radiant(double degree)
        {
            return degree * Math.PI / 180;
        }
    }
}
