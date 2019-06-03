namespace SplitGridDomainModel
{
	/// <summary>
	/// TransactionItem class
	/// </summary>
	public class TransactionItem
    {
		public string Error { get; set; }
		public string ReceiptDate { get; set; }
		public string DateTime { get; set; }
		public int ReceiptNr { get; set; }
		public decimal PriceWithVat { get; set; }
		public decimal PriceWithoutVat { get; set; }
		public decimal Discount { get; set; }
		public decimal WholeSalePrice { get; set; }
		public string BrandName { get; set; }
		public string ArticleNr { get; set; }
		public string EAN { get; set; }
		public int Quantity { get; set; }
		public int InventoryStock { get; set; }
		public string Size { get; set; }
		public string Color { get; set; }
	}
}
