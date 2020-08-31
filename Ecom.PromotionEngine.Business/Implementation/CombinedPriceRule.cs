using System;
using System.Collections.Generic;
using System.Linq;
using Ecom.PromotionEngine.Business.Interfaces;
using Ecom.PromotionEngine.Entity;

namespace Ecom.PromotionEngine.Business.Implementation
{
	/// <summary>
	/// Class represent rule to be applied when multiple products purchased together.
	/// </summary>
	public class CombinedPriceRule : IRuleEngine
	{

		/// <summary>
		/// SKUs that can be brought together with discount.
		/// </summary>
		private readonly List<char> _skus;


		/// <summary>
		/// Rule details
		/// </summary>
		/// <param name="discount">Discount price</param>
		/// <param name="sku"></param>
		public CombinedPriceRule(decimal? discount, ICollection<char> sku)
		{
			this.Rule = new Rule()
			{
				DiscountedPrice = discount ?? 5,
				Id = 1
			};
			this._skus = sku.ToList();
		}
	/// <summary>
	/// Rule
	/// </summary>
	public Rule Rule { get; set; }

	/// <summary>
	/// Calculates the selling price of the product based on rule
	/// </summary>
	/// <param name="products">Product details</param>
	/// <returns>Returns selling price for the shortlisted product</returns>
	public decimal CalculatePrice(ICollection<ShortlistedProduct> products)
	{
		decimal TotalPrice = 0;
		var orderSKU = products.Select(p => p.Product.Sku).ToList();
		var isRuleApplicable = _skus.All(orderSKU.Contains);
		if (isRuleApplicable)
		{
			// if rule c + D = 30 and the order is 2c + 4D the total calculation should be like 2(c+ D) + 2D.
			var minQuanity = products.Min(p => p.Quantity);
			decimal discountedPrice = 0, normalPrice = 0;
			foreach (var shortlistedProduct in products)
			{
				discountedPrice += minQuanity * shortlistedProduct.Product.Price;
				normalPrice += (shortlistedProduct.Quantity - minQuanity) * shortlistedProduct.Product.Price;
			}

			TotalPrice = (discountedPrice - minQuanity * Rule.DiscountedPrice) + normalPrice;
		}
		else
		{
			TotalPrice = products.ToList().Sum(p => p.Quantity * p.Product.Price);
		}

		return TotalPrice;
	}
}
}
