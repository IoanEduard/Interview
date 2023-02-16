namespace _8.DesignPatterns.Observer.Example_Three
{
    public class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ConcreteSubject _subject;

        public ConcreteSubject Subject
        {
            get { return _subject; }
            set { _subject = value; }
        }

        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            _subject = subject;
            this.name = name;
        }
        public override void Update()
        {
            observerState = _subject.SubjectState;
            Console.WriteLine("Observer {0}'s new state is {1}",
                name, observerState);
        }

    }
}
