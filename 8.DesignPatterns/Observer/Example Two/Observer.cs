using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.DesignPatterns.Observer.Example_Two
{
    public class Observer : IObserver<Payload>
    {
        public string Message { get; set; }

        public void OnCompleted()
        {
        }

        public void OnError(Exception error)
        {
        }

        public void OnNext(Payload value)
        {
            Message = value.Message;
        }

        public IDisposable Register(Subject subject)
        {
            return subject.Subscribe(this);
        }
    }
}
