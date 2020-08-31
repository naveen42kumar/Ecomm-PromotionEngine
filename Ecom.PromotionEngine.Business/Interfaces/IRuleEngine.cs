using System;
using System.Collections.Generic;
using System.Text;
using Ecom.PromotionEngine.Entity;

namespace Ecom.PromotionEngine.Business.Interfaces
{
	/// <summary>
	/// Interface to be implemented by actual rule engines
	/// </summary>
	public interface IRuleEngine
	{
		/// <summary>
		/// Discount price to be applied
		/// </summary>
		public decimal DiscountedPrice { get; set; }

		/// <summary>
		/// Calculates the selling price of the product based on rule
		/// </summary>
		/// <param name="products">Product details</param>
		/// <returns>Returns selling price for the shortlisted product</returns>
		decimal CalculatePrice(ICollection<ShortlistedProduct> products);
	}
}
