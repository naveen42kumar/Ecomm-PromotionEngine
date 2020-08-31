namespace Ecom.PromotionEngine.Entity
{
	/// <summary>
	/// Class holds the product related items
	/// </summary>
	public class Product
	{
		/// <summary>
		/// Product unique identifier
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Name of the product
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// SKU of the product
		/// </summary>
		public char Sku { get; set; }

		/// <summary>
		/// Product information like manufacturer , expiry date etc.
		/// </summary>
		public string ProductInfo { get; set; }

		/// <summary>
		/// Price of the product
		/// </summary>
		public decimal Price { get; set; }
	}
}
