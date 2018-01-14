using CsGL.OpenGL;
using DemoOpenGLBasicsCS.models;
using System;
using System.Windows.Media.Media3D;

namespace DemoOpenGLBasicsCS.interfaces
{
    public abstract class ICrane
    {
        private CylinderPart tower;
        private CylinderPart boom;
        private CylinderPart seil;
        private double drehwinkel;
        private float seillaenge;
        private float seilposition;
        private double movementfactorXZ;
        private double movementfactorY;
        private double towerlength;
        private double boomlength;
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
            boomlength = 2;
            Vector3D InitialVector = new Vector3D
            {
                X = seilposition,
                Y = towerlength - seillaenge,
                Z = 0
            };
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
                if (value > tower.Length - 0.3f)
                {
                    seillaenge = (float)tower.Length - 0.3F;
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
                        movementfactorY = 100 / (tower.Length - value) * ((tower.Length - value) + 0.2f) / 100;
                    } else
                    {
                        movementfactorY = 100 / (tower.Length - value) * ((tower.Length - value) - 0.2f) / 100;
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
                if (value > boom.Length)
                {
                    seilposition = (float)boom.Length;
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
        public double Towerlength { get => towerlength;}

        public virtual void setMovement(IMovement movement)
        {
            this.movement = movement;
        }

        public virtual void move()
        {
            movement.move(this);
        }

        public virtual void zeichnung()
        { //Kran wird definiert und anschließend gezeichnet
            GL.glColor3f(colorred, colorgreen, colorblue);
            GL.glTranslated(0.0, 0.0, 0.0);
            GL.glRotated(-90, 1, 0, 0);
            GL.glRotated(drehwinkel, 0, 0, 1);

            matrix.RotateY(drehwinkel);

            tower = new CylinderPart(towerlength);
            GLU.gluCylinder(tower.Element, 0.2, 0.2, tower.Length, 4, 10);
            GLU.gluQuadricDrawStyle(tower.Element, style);

            boom = new CylinderPart(boomlength);
            GL.glTranslated(0.0, 0.0, tower.Length - 0.2f);
            GL.glRotated(90, 0, 1, 0);
            GL.glRotated(90, 0, 0, 1);
            GLU.gluCylinder(boom.Element, 0.2, 0.2, boom.Length, 3, 10);
            GLU.gluQuadricDrawStyle(boom.Element, style);
            matrix.TranslateXZ(movementfactorXZ);

            seil = new CylinderPart(seillaenge);
            GL.glTranslated(0.0, 0.0, Seilposition);
            GL.glRotated(90, 0, 1, 0);
            GL.glRotated(90, 1, 0, 0);
            GLU.gluCylinder(seil.Element, 0.01, 0.01, seil.Length, 20, 10);
            GLU.gluQuadricDrawStyle(seil.Element, style);
            matrix.TranslateY(movementfactorY);

            GL.glTranslated(0.0, 0.0, Seillaenge);
            GLUT.glutWireSphere(0.1, 100, 150);
        }
    }
}