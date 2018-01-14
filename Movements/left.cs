using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.movements
{
    public class Left : interfaces.IMovement
    {
        public void move(ICrane element)
        {
            // rotating against the clock is positive
            // https://www.mathebibel.de/drehmatrix
            element.Rotationangle = element.Rotationangle + 5;
        }
    }
}
