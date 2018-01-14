using DemoOpenGLBasicsCS.interfaces;

namespace DemoOpenGLBasicsCS.models
{
    public class Crane : ICrane
    {
        public Crane(float colorred, float colorgreen, float colorblue)
        {
            this.colorred = colorred;
            this.colorgreen = colorgreen;
            this.colorblue = colorblue;
        }

        public override void zeichnung()
        {
            base.zeichnung();
        }

    }
}
