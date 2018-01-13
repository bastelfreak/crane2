using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class right : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            element.Drehwinkel = element.Drehwinkel - 5;
        }
    }
}
