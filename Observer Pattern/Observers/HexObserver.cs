
namespace Observers
{
    public class HexObserver : Observer
    {
        public HexObserver(Subject subjectin)
        {
            this.subject = subjectin;
            this.subject.attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Convert To Hex String : " + this.subject.getState());
        }
    }
}
