using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class Right : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            // rotating with the clock is negative
            // https://www.mathebibel.de/drehmatrix
            element.Drehwinkel = element.Drehwinkel - 5;
        }
    }
}
