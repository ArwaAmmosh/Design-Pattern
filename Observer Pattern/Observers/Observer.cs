namespace Observers
{
    public abstract class Observer
    {
        public Subject subject;
        public abstract  void Update();
    }
}
