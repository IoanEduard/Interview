using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _0.Tests._LeetCode_Medium.Tests.Struggle;
using _2.Printer.Concrete;

namespace _1.Main.StaticCalls._LeetCode_Medium
{
    public class MediumProblemsTestRunner
    {
        private readonly TestsLeetCodeMediumStruggle _tests;

        public MediumProblemsTestRunner()
        {
            _tests = new TestsLeetCodeMediumStruggle(new DisplayTypeInstantiator());
        }
        public void RunTests()
        {
            // _tests.MaxScore_Test();
            // _tests.MaxScore1_Test();
            // _tests.WaysToBuyPensPencils_Test();    
            // _tests.ProductExceptSelfBruteForce_Test();    
            // _tests.ProductExceptSelf_Test();    
            // _tests.ProductExceptSelf2_Test();    
            // _tests.RotateFail_Test();    
            // _tests.Rotate_Test();   
            // _tests.NumberOfClosedIslands_Test(); 
        }
    }
}