using CsGL.OpenGL;

namespace DemoOpenGLBasicsCS.models
{
    public class CylinderPart
    {
        public GLUquadric element { get; set; }
        public double Length { get => length; }

        private double length;

        public CylinderPart(double length = 2) //Objekte werden erzeugt
        {
            element = GL.gluNewQuadric();
            this.length = length;
        }     
    }
}
