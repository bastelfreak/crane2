using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class Up : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            element.Seillaenge = element.Seillaenge - 0.2f;
        }
    }
}
