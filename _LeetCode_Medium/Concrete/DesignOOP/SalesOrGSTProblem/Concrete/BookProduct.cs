using _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.Abstract;
using _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.TaxCalculations;

namespace _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.Concrete
{
    public class BookProduct : Product
    {
        public BookProduct() 
            : base()
        {
        }

        public BookProduct(string name, double price, bool imported, int quantity) 
            : base(name, price, imported, quantity)
        {
        }

        public override ProductFactory GetFactory()
        {
            return new BookProductFactory();
        }

        public override double GetTaxValue(string country)
        {
            if (country == "Local")
                return LocalTaxValues.BOOK_TAX;
            else
                return 0;
        }
    }
}
