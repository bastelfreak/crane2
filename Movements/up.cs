using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class up : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            element.Seillaenge = element.Seillaenge - 0.2f;
        }
    }
}
