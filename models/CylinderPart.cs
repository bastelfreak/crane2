using CsGL.OpenGL;

namespace DemoOpenGLBasicsCS.models
{
    public class CylinderPart
    {
        private GLUquadric element;
        private double length;
        public GLUquadric Element { get => element; set => element = value; }
        public double Length { get => length; }

        public CylinderPart(double length = 2) //Objekte werden erzeugt
        {
            element = GL.gluNewQuadric();
            this.length = length;
        }     
    }
}
