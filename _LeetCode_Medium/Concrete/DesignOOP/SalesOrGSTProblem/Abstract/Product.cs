namespace _LeetCode_Medium.Concrete.DesignOOP.SalesOrGSTProblem.Abstract
{
    public abstract class Product
    {
        protected string Name { get; set; }
        private double _price;
        public double Price 
        {
            set { _price = value; }
            get { return _price; }
        }

        public bool Imported { get; set; }
        public int Quantity { get; set; }
        public double TaxedCost { get; set; }

        public Product(string name, double price, bool imported, int quantity)
        {
            Name = name;
            Price = price;
            Imported = imported;
            Quantity = quantity;
        }

        public Product()
        {
            Name = string.Empty;
            Price = 0d;
            Imported = false;
            Quantity = 0;
            TaxedCost = 0d;
        }

        public override string? ToString()
        {
            return (Quantity + " " + ImportedToString(Imported) + " " + Name + " : " + TaxedCost);
        }

        public String ImportedToString(bool imported)
        {
            if (!imported)
                return string.Empty;
            else
                return "imported";
        }
        public abstract ProductFactory GetFactory();
        public abstract double GetTaxValue(String country);
    }
}
