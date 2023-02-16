using _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.Utils;

namespace _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.TaxCalculations
{
    /// <summary>
    /// It Calculates Total Tax Cost According to Local Region Specification.
    /// </summary>
    internal class LocalTaxCalculator : ITaxCalculator
    {
        public double CalculateTax(double price, double localTax, bool imported)
        {
            double tax = price * localTax;
            if (imported)
                tax += price * 0.5;
            //rounds off to nearest 0.05;
            tax = TaxUtil.RoundOff(tax);
            return tax;
        }
    }
}
