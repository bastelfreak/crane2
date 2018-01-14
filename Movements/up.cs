using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class Up : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            element.Ropelength = element.Ropelength - 0.2;
        }
    }
}
