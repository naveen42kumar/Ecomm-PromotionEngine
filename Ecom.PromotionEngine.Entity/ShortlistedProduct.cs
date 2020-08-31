using System.ComponentModel.DataAnnotations;

namespace Ecom.PromotionEngine.Entity
{
	/// <summary>
	/// Class holds the information related to the shortlisted product details.
	/// </summary>
	public class ShortlistedProduct
	{
		/// <summary>
		/// Short listed product
		/// </summary>
		public Product Product { get; set; }

		/// <summary>
		/// Shortlisted product quantity
		/// </summary>
		[Range(1, int.MaxValue)]
		public int Quantity { get; set; }

	}
}
