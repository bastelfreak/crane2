using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class left : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            element.Drehwinkel = element.Drehwinkel + 5;
        }
    }
}
