using CsGL.OpenGL;
using DemoOpenGLBasicsCS.models;
using System;
using System.Windows.Media.Media3D;

namespace DemoOpenGLBasicsCS.interfaces
{
    public abstract class ICrane
    {
        private CylinderPart turm;
        private CylinderPart ausleger;
        private CylinderPart seil;
        private double drehwinkel;
        private float seillaenge;
        private float seilposition;
        private double movementfactorXZ;
        private double movementfactorY;
        private double towerlength;
        protected float colorred;
        protected float colorgreen;
        protected float colorblue;
        private Matrix matrix;

        public ICrane()
        {
            drehwinkel = 0.0;
            seillaenge = 1.5f;
            seilposition = 0.5f;
            towerlength = 3;
            Vector3D InitialVector = new Vector3D();
            InitialVector.X = seilposition;
            InitialVector.Y = towerlength - seillaenge;
            InitialVector.Z = 0;
            matrix = new Matrix(InitialVector);
            movementfactorY = 1;
            movementfactorXZ = 1;
        }
        protected uint style = 100012; //Übergabe für das GLU.GLU_FILL, damit dies einheitlich ist

        public double Drehwinkel { get { return drehwinkel; } set { drehwinkel = value; } }
        public float Seillaenge
        {
            get { return seillaenge; }
            set
            {
                if (value > turm.Length - 0.3f)
                {
                    seillaenge = (float)turm.Length - 0.3F;
                    movementfactorY = 1;
                }
                else if (value < 0.4f)
                {
                    seillaenge = 0.4F;
                    movementfactorY = 1;
                }
                else
                {
                    if (value > seillaenge)
                    {
                        movementfactorY = 100 / (turm.Length - value) * ((turm.Length - value) + 0.2f) / 100;
                    } else
                    {
                        movementfactorY = 100 / (turm.Length - value) * ((turm.Length - value) - 0.2f) / 100;
                    }
                    if (movementfactorY <= 0.0f)
                    {
                        movementfactorY = 1;
                    }
                    seillaenge = value;
                }
            }
        }

        public float Seilposition
        {
            get { return seilposition; }

            set
            {
                if (value > ausleger.Length)
                {
                    seilposition = (float)ausleger.Length;
                    // set it to 1, so the vector doesn't move
                    movementfactorXZ = 1;
                }
                else if (value < 0.5f)
                {
                    seilposition = 0.5f;
                    movementfactorXZ = 1;
                }
                else
                {
                    // > 0 < 1 will move the ball to the middle
                    // > 1 will move the ball away from the middle
                    // < 0 we all die?
                    // yeah we just died and need to add a condition that filters for 0...
                    if (value > seilposition) {
                        movementfactorXZ = 100 / value * (value + 0.05f) / 100;
                    }
                    else
                    {
                        movementfactorXZ = 100 / value * (value - 0.05f) / 100;
                    }
                    seilposition = value;
                }
            }
        }

        public IMovement movement { get; set; }
        public double X { get => matrix.X; }
        public double Y { get => matrix.Y; }
        public double Z { get => matrix.Z; }
        public double MovementfactorXZ { get => movementfactorXZ;}
        public double MovementfactorY { get => movementfactorY;}

        public virtual void setMovement(IMovement movement)
        {
            this.movement = movement;
        }

        public virtual void move()
        {
            movement.move(this);
        }

        private double Degree2Radiant(double degree)
        {
            return degree * Math.PI / 180;
        }

        public virtual void zeichnung()
        { //Kran wird definiert und anschließend gezeichnet
            GL.glColor3f(colorred, colorgreen, colorblue);
            GL.glTranslated(0.0, 0.0, 0.0);
            GL.glRotated(-90, 1, 0, 0);
            GL.glRotated(drehwinkel, 0, 0, 1);

            matrix.RotateY(drehwinkel);

            turm = new CylinderPart(towerlength);
            //GL.glRotated(-90, 1, 0, 0);
            GLU.gluCylinder(turm.element, 0.2, 0.2, turm.Length, 4, 10);
            GLU.gluQuadricDrawStyle(turm.element, style);

            ausleger = new CylinderPart(2);
            GL.glTranslated(0.0, 0.0, turm.Length - 0.2f);
            GL.glRotated(90, 0, 1, 0);
            GL.glRotated(90, 0, 0, 1);
            GLU.gluCylinder(ausleger.element, 0.2, 0.2, ausleger.Length, 3, 10);
            GLU.gluQuadricDrawStyle(ausleger.element, style);

            //matrix.TranslateXZ(Movementfactor);

            seil = new CylinderPart(seillaenge);
            GL.glTranslated(0.0, 0.0, Seilposition);
            GL.glRotated(90, 0, 1, 0);
            GL.glRotated(90, 1, 0, 0);
            GLU.gluCylinder(seil.element, 0.01, 0.01, seil.Length, 20, 10);
            GLU.gluQuadricDrawStyle(seil.element, style);
            matrix.TranslateY(movementfactorY);

            GL.glTranslated(0.0, 0.0, Seillaenge);
            GLUT.glutWireSphere(0.1, 100, 150);
            //matrix.zielpunkt();
        }
    }
}