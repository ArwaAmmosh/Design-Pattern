
using Observer_Pattern.Observer;
namespace Observer_Pattern.Subject
{
    public interface ISubject
    {
        void RegisterObserver (IObserver observer);
        void UnregisterObserver(IObserver observer);
        void NotifyObservers(int count);


    }
}
