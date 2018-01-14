using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class Back : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            element.Ropeposition = element.Ropeposition - 0.05f;
        }
    }
}
