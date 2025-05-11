namespace Observers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            Observer observer1=new HexObserver(subject);
            Observer observer2 = new OctalObserver(subject);
            Console.WriteLine("First State Change : 15");
            subject.setState(15);
            Console.WriteLine("First State Change : 30");
            subject.dettach(observer1);
            subject.setState(30);

        }
    }
}
