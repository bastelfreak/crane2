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
        private CylinderPart rope;
        private double rotationangle;
        private double ropelength;
        private double ropeposition;
        private double movementfactorXZ;
        private double movementfactorY;
        private double towerheight;
        private double boomlength;
        protected float colorred;
        protected float colorgreen;
        protected float colorblue;
        private Matrix matrix;

        public ICrane()
        {
            rotationangle = 0.0;
            ropelength = 1.5;
            ropeposition = 0.5;
            towerheight = 3;
            boomlength = 2;
            Vector3D InitialVector = new Vector3D
            {
                X = ropeposition,
                Y = towerheight - ropelength,
                Z = 0
            };
            matrix = new Matrix(InitialVector);
            movementfactorY = 1;
            movementfactorXZ = 1;
            tower = new CylinderPart(towerheight);
            boom = new CylinderPart(boomlength);
            rope = new CylinderPart(ropelength);
        }
        protected uint style = 100012; //Übergabe für das GLU.GLU_FILL, damit dies einheitlich ist

        public double Rotationangle
        {
            get { return rotationangle; }
            set
            {
                // we need to ensure that we're never >360
                // would mean we rotated too much to the left
                if (value >= 360)
                {
                    rotationangle = value - 360;

                }
                // we need to ensure that we're never < 360
                // would mean we rotated too much to the right
                else if (value <= -360){
                    rotationangle = value + 360;
                }
                else
                {
                    rotationangle = value;
                }
                // recalculate the rotation on the vertical axis, because the rotation angle changed
                matrix.RotateY(Degree2Radiant(rotationangle));
            }
        }
        public double Ropelength
        {
            get { return ropelength; }
            set
            {
                if (value > tower.Length - 0.3)
                {
                    ropelength = tower.Length - 0.3;
                    movementfactorY = 1;
                }
                else if (value < 0.4)
                {
                    ropelength = 0.4;
                    movementfactorY = 1;
                }
                else
                {
                    if (value > ropelength)
                    {
                        // we need to substract if the rope gets longer
                        // we're interested in the length from the bottom to the ropeend, not the rope length
                        movementfactorY = 100 / (tower.Length - value) * ((tower.Length - value) - 0.2) / 100;
                    } else
                    {
                        movementfactorY = 100 / (tower.Length - value) * ((tower.Length - value) + 0.2) / 100;
                    }
                    if (movementfactorY <= 0.0)
                    {
                        movementfactorY = 1;
                    }
                    ropelength = value;
                }
                matrix.TranslateY(tower.Length - ropelength);
            }
        }

        public double Ropeposition
        {
            get { return ropeposition; }

            set
            {
                if (value > boom.Length)
                {
                    ropeposition = boom.Length;
                    // set it to 1, so the vector doesn't move
                    movementfactorXZ = 1;
                }
                else if (value < 0.5)
                {
                    ropeposition = 0.5;
                    movementfactorXZ = 1;
                }
                else
                {
                    // > 0 < 1 will move the ball to the middle
                    // > 1 will move the ball away from the middle
                    // < 0 we all die?
                    // yeah we just died and need to add a condition that filters for 0...
                    if (value > ropeposition) {
                        movementfactorXZ = 100 / value * (value + 0.05) / 100;
                    }
                    else
                    {
                        movementfactorXZ = 100 / value * (value - 0.05) / 100;
                    }
                    ropeposition = value;
                }
                matrix.TranslateXZ(movementfactorXZ);
            }
        }

       public IMovement movement { get; set; }
        public double X { get => matrix.X; }
        public double Y { get => matrix.Y; }
        public double Z { get => matrix.Z; }
        public double Radiant { get => Degree2Radiant(rotationangle); }
        public double MovementfactorXZ { get => movementfactorXZ;}
        public double MovementfactorY { get => movementfactorY;}
        public double Towerheight { get => tower.Length;}
        public double Boomlength { get => boom.Length; }

        public virtual void setMovement(IMovement movement)
        {
            this.movement = movement;
        }

        public virtual void move()
        {
            movement.move(this);
        }

        public double Radiant2Degree(double radiant)
        {
            // we always need to return something, otherweise we don't show anything in the UI
            // calculation fails if one of the factors is 0
            if (radiant != 0)
            {
                radiant = (360 / 2 * Math.PI) * radiant;
            }
            return radiant;
        }

        private double Degree2Radiant(double degree)
        {
            // we always need to return something, otherweise we don't show anything in the UI
            // calculation fails if one of the factors is 0
            if (degree != 0)
            {
                degree = degree * (2 * Math.PI / 360);
            }
            return degree;
        }

        public virtual void Draw()
        { //at this point the crane will be drawing
            GL.glColor3f(colorred, colorgreen, colorblue);
            GL.glTranslated(0.0, 0.0, 0.0);
            GL.glRotated(-90, 1, 0, 0);
            GL.glRotated(rotationangle, 0, 0, 1);

            tower = new CylinderPart(towerheight);
            GLU.gluCylinder(tower.Element, 0.2, 0.2, tower.Length, 4, 10);
            GLU.gluQuadricDrawStyle(tower.Element, style);

            boom = new CylinderPart(boomlength);
            GL.glTranslated(0.0, 0.0, tower.Length - 0.2f);
            GL.glRotated(90, 0, 1, 0);
            GL.glRotated(90, 0, 0, 1);
            GLU.gluCylinder(boom.Element, 0.2, 0.2, boom.Length, 3, 10);
            GLU.gluQuadricDrawStyle(boom.Element, style);

            rope = new CylinderPart(ropelength);
            GL.glTranslated(0.0, 0.0, Ropeposition);
            GL.glRotated(90, 0, 1, 0);
            GL.glRotated(90, 1, 0, 0);
            GLU.gluCylinder(rope.Element, 0.01, 0.01, rope.Length, 20, 10);
            GLU.gluQuadricDrawStyle(rope.Element, style);

            GL.glTranslated(0.0, 0.0, Ropelength);
            GLUT.glutWireSphere(0.1, 100, 150);
        }
    }
}