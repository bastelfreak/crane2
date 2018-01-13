using CsGL.OpenGL;
using DemoOpenGLBasicsCS.models;
using System;

namespace DemoOpenGLBasicsCS.interfaces
{
    public abstract class ICrane
    {
        private CylinderPart turm;
        private CylinderPart ausleger;
        private CylinderPart seil;
        private float drehwinkel = 0.0f;
        private float seillaenge = 1.5f;
        private float seilposition = 0.5f;
        protected float colorred;
        protected float colorgreen;
        protected float colorblue;

        protected uint style = 100012; //Übergabe für das GLU.GLU_FILL, damit dies einheitlich ist

        public float Drehwinkel { get { return drehwinkel; } set { drehwinkel = value; } }
        public float Seillaenge
        {
            get { return seillaenge; }
            set
            {
                if (value > turm.length - 0.3f)
                {
                    seillaenge = (float)turm.length - 0.3F;
                }
                else if (value < 0.4f)
                {
                    seillaenge = 0.4F;
                }
                else
                {
                    seillaenge = value;
                }
            }
        }

        public float Seilposition
        {
            get { return seilposition; }

            set {
                if (value > ausleger.length)
                    seilposition = (float)ausleger.length;
                else if (value < 0.5f)
                    seilposition = 0.5f;
                else
                    seilposition = value;
            }
        }

        public IMovement movement { get; set; }

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
            GL.glTranslated(0.0, 0.0, -6.0);
            matrix.startvektor = new System.Windows.Media.Media3D.Vector3D(0.0, 0.0, -6.0);
            GL.glRotated(-90, 1, 0, 0);
            GL.glRotated(drehwinkel, 0, 0, 1);
            matrix.matrixstart = System.Windows.Media.Media3D.Matrix3D.Multiply(new System.Windows.Media.Media3D.Matrix3D(1, 0, 0, 0, 0, Math.Cos(-90), -(Math.Sin(-90)), 0, 0, Math.Sin(-90), Math.Cos(-90), 0, 0, 0, 0, 1),
                                                                                new System.Windows.Media.Media3D.Matrix3D(Math.Cos(drehwinkel), -(Math.Sin(drehwinkel)), 0, 0, Math.Sin(drehwinkel), Math.Cos(drehwinkel), 0, 0, 0, 0, 1, 0, 0, 0, 0, 1));

            turm = new CylinderPart(3);
            GLU.gluCylinder(turm.element, 0.2, 0.2, turm.length, 4, 10);
            GLU.gluQuadricDrawStyle(turm.element, style);
            matrix.Matrixturm = new System.Windows.Media.Media3D.Vector3D(0.0, 0.0, turm.length);

            ausleger = new CylinderPart(2);
            GL.glTranslated(0.0, 0.0, turm.length -0.2f);
            GL.glRotated(90, 0, 1, 0);
            GL.glRotated(90, 0, 0, 1);
            GLU.gluCylinder(ausleger.element, 0.2, 0.2, ausleger.length, 3, 10);
            GLU.gluQuadricDrawStyle(ausleger.element, style);
            matrix.Matrixausleger = new System.Windows.Media.Media3D.Vector3D(0.0, 0.0, turm.length -0.2f);
            matrix.turmzuausleger = System.Windows.Media.Media3D.Matrix3D.Multiply(new System.Windows.Media.Media3D.Matrix3D(Math.Cos(90),0,Math.Sin(90),0,0,1,0,0,-(Math.Sin(90)),0,Math.Cos(90),0,0,0,0,1),
                                                                                   new System.Windows.Media.Media3D.Matrix3D(Math.Cos(90), -(Math.Sin(90)), 0, 0, Math.Sin(90), Math.Cos(90), 0, 0, 0, 0, 1, 0, 0, 0, 0, 1));

            seil = new CylinderPart(seillaenge);
            GL.glTranslated(0.0, 0.0, Seilposition);
            GL.glRotated(90, 0, 1, 0);
            GL.glRotated(90, 1, 0, 0);
            GLU.gluCylinder(seil.element, 0.01, 0.01, seil.length, 20, 10);
            GLU.gluQuadricDrawStyle(seil.element, style);
            matrix.Matrixseil = new System.Windows.Media.Media3D.Vector3D(0.0, 0.0, Seilposition);
            matrix.auslegerzuseil = System.Windows.Media.Media3D.Matrix3D.Multiply(new System.Windows.Media.Media3D.Matrix3D(Math.Cos(90), 0, Math.Sin(90), 0, 0, 1, 0, 0, -(Math.Sin(90)), 0, Math.Cos(90), 0, 0, 0, 0, 1),
                                                                                    new System.Windows.Media.Media3D.Matrix3D(1, 0, 0, 0, 0, Math.Cos(90), -(Math.Sin(90)), 0, 0, Math.Sin(90), Math.Cos(90), 0, 0, 0, 0, 1));
            matrix.SeilVector = new System.Windows.Media.Media3D.Vector3D(0.0, 0.0, Seillaenge);

            GL.glTranslated(0.0, 0.0, Seillaenge);
            GLUT.glutWireSphere(0.1, 100, 150);
        }     
    }
}
