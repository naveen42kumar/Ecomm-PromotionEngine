using System;
using System.Collections.Generic;
using System.Linq;
using Ecom.PromotionEngine.Business.Exception;
using Ecom.PromotionEngine.Business.Interfaces;
using Ecom.PromotionEngine.Entity;

namespace Ecom.PromotionEngine.Business.Implementation
{
	/// <summary>
	/// Class represents the rule to be set based on quantity of a product
	/// </summary>
	public class SingleProductRule : IRuleEngine
	{
		/// <summary>
		/// Quantity to consider for applying rule.
		/// </summary>
		private readonly int _quantity;


		/// <summary>
		/// Rule details
		/// </summary>
		/// <param name="discount">Discount price</param>
		/// <param name="quantity"></param>
		/// <param name="ruleId"></param>
		public SingleProductRule(decimal? discount, int quantity, int ruleId)
		{
			this.Rule = new Rule()
			{
				DiscountedPrice = discount ?? 30,
				Id = ruleId
			};
			this._quantity = quantity;
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
			if (products?.Count == 1)
			{
				var cartProduct = products.FirstOrDefault();
				if (cartProduct.Quantity >= this._quantity)
				{
					return (cartProduct.Quantity / this._quantity) *  (this._quantity * cartProduct.Product.Price - this.Rule.DiscountedPrice) +
					       (cartProduct.Quantity % this._quantity) * cartProduct.Product.Price;

				}
				else
				{
					return cartProduct.Quantity * cartProduct.Product.Price;
				}
			}
			else
			{
				throw new InvalidInputException();
			}
		}
	}
}
