using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.TaxCalculations
{
    public class TaxCalculatorFactory
    {
        private Dictionary<string, ITaxCalculator> taxCalculators;
        public TaxCalculatorFactory()
        {
            taxCalculators = new Dictionary<string, ITaxCalculator>();
            RegisterInFactory("Local", new LocalTaxCalculator());
        }
        public void RegisterInFactory(string strategy, ITaxCalculator taxCalc)
        {
            taxCalculators.Add(strategy, taxCalc);
        }
        public ITaxCalculator GetTaxCalculator(string strategy)
        {
            ITaxCalculator taxCalc = taxCalculators[strategy];
            return taxCalc;
        }
        public int GetFactorySize()
        {
            return taxCalculators.Count;
        }
    }
}
