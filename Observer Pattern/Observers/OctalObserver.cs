
namespace Observers
{
    public class OctalObserver : Observer
    {
        public OctalObserver(Subject subjectin)
        {
            this.subject=subjectin;
            this.subject.attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Convert To Octal String : " + this.subject.getState());
        }
    }
}
