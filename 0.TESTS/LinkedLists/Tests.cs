using _2.Printer.Concrete;
using _7.LinkedLists.Concrete.Documentation.Articles;

namespace _0.Tests.LinkedLists
{
    public class Tests
    {
        private readonly DisplayTypeInstantiator _display;
        private readonly MediumKojinLinkedLists _mediumKojinLinkedLists;

        public Tests(DisplayTypeInstantiator display)
        {
            _display = display;
            _mediumKojinLinkedLists = new MediumKojinLinkedLists();
        }
        public void RunMethods_Test()
        {
            _mediumKojinLinkedLists.CreateLinkedList();
            _mediumKojinLinkedLists.TraverseLinkedList();
        }
    }
}