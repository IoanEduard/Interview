using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0.Tests.LinkedLists;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls.LinkedLists
{
    public class LinkedListsTestRunner
    {
        private readonly Tests _tests;

        public LinkedListsTestRunner()
        {
            _tests = new Tests(new DisplayTypeInstantiator());
        }

        public void RunTests()
        {
            _tests.RunMethods_Test();
        }
    }
}