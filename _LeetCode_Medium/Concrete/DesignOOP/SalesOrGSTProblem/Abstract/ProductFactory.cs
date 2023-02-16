namespace _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.Abstract
{
    public abstract class ProductFactory
    {
        public abstract Product CeateProduct(String name, double price, bool imported, int quantity);
    }
}
