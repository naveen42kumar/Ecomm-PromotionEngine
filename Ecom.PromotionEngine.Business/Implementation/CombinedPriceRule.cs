using System;
using System.Collections.Generic;
using Ecom.PromotionEngine.Business.Interfaces;
using Ecom.PromotionEngine.Entity;

namespace Ecom.PromotionEngine.Business.Implementation
{
	/// <summary>
	/// Class represent rule to be applied when multiple products purchased together.
	/// </summary>
	public class CombinedPriceRule : Rule, IRuleEngine
	{
		/// <summary>
		/// Discount price to be applied
		/// </summary>
		public decimal DiscountedPrice { get; set; }

		/// <summary>
		/// Rule details
		/// </summary>
		/// <param name="discount">Discount price</param>
		public CombinedPriceRule(decimal? discount)
		{
			this.DiscountedPrice = discount ?? 5;
			this.Id = 1;
		}

		/// <summary>
		/// Calculates the selling price of the product based on rule
		/// </summary>
		/// <param name="products">Product details</param>
		/// <returns>Returns selling price for the shortlisted product</returns>
		public decimal CalculatePrice(ICollection<ShortlistedProduct> products)
		{
			throw new NotImplementedException();
		}
	}
}
