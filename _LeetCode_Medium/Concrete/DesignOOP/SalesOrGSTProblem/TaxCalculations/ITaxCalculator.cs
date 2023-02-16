namespace _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.TaxCalculations
{
    /// <summary>
    /// It Computes Total Tax Cost of a Product.
    /// </summary>
    public interface ITaxCalculator
    {
        /// <summary>
        /// Calculates Tax for a Product where Tax Cost is the Sum of Sales 
        /// Tax and Imported Duty of a Product.
        /// </summary>
        /// <param name="price">The Price of the Product.</param>
        /// <param name="tax">The Tax Rate of the Product.</param>
        /// <param name="imported">Product is whether Imported or not.</param>
        /// <returns></returns>
        double CalculateTax(double price, double tax, bool imported);
    }
}
