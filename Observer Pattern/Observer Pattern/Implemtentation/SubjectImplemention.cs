using Observer_Pattern.Observer;
using Observer_Pattern.Subject;
using System.Collections.Generic;
namespace Observer_Pattern.Implemtentation
{
    public class SubjectImplemention : ISubject
    {
        private List<IObserver> observers;
        private int count;
        public SubjectImplemention()
        {
            observers = new List<IObserver>();
            count = 0;
        }
        public void Increament()
        {
            count++;
            NotifyObservers(count);
        }
        public void Decreament()
        {
            if (count > 0)
            {
                count--;
                NotifyObservers(count);
            }
        }
        public void NotifyObservers(int count)
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(count);
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            observers.Remove(observer);
        }
    }
}
