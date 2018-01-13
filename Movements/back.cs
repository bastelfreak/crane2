using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class back : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            element.Seilposition = element.Seilposition - 0.05f;
        }
    }
}
