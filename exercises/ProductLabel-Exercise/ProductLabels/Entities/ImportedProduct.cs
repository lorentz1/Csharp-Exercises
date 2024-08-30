namespace ProductLabels.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }
        public ImportedProduct() { }
        public ImportedProduct(string name, double price, double customsFee)
            : base (name, price)
        {
            CustomsFee = customsFee;
        }
        public override string priceTag()
        {
            return $"{Name} $ {Price + CustomsFee} (Customs fee: $ {CustomsFee})";
        }
    }
}
