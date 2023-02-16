using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.DesignPatterns.Observer.Example_One
{
    public interface IEventListener
    {
        void Update(string filename);
    }
}
