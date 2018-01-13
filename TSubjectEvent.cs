using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoOpenGLBasicsCS
{
    public class TSubject
    {
        public delegate void updateDelegate();
        
        public event updateDelegate updateList;

        protected void notify()
        {
            if (updateList != null)
                updateList();
        }
    }
}
