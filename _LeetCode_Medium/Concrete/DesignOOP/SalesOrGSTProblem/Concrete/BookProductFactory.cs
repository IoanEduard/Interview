using _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.Abstract;

namespace _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.Concrete
{
    public class BookProductFactory : ProductFactory
    {
        public override Product CeateProduct(string name, double price, bool imported, int quantity)
        {
            return new BookProduct(name, price, imported, quantity);
        }
    }
}
