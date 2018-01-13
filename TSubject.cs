using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DemoOpenGLBasicsCS
{
    public class TSubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void attach(IObserver observer)
        {
            observers.Add(observer);
            observer.update();
        }

        public void detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        protected void notify()
        {
            foreach (IObserver observer in observers)
                observer.update();
        }
    }
}
