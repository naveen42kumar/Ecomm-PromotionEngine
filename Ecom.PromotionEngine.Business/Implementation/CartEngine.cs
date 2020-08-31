using System.Collections.Generic;
using System.Linq;
using Ecom.PromotionEngine.Business.Exception;
using Ecom.PromotionEngine.Business.Interfaces;
using Ecom.PromotionEngine.Entity;

namespace Ecom.PromotionEngine.Business.Implementation
{
	/// <summary>
	/// Cart engine is useful to calculate the cart value.
	/// </summary>
	public class CartEngine : ICartPriceCalculator
	{
		/// <summary>
		/// All the applicable rule engines.
		/// </summary>
		private readonly ICollection<IRuleEngine> _ruleEngines;

		public CartEngine(ICollection<IRuleEngine> ruleEngines)
		{
			this._ruleEngines = ruleEngines;
		}

		/// <summary>
		/// Calculates the total value price of cart items
		/// </summary>
		/// <param name="order">Order object</param>
		/// <returns>Returns the total price</returns>
		public decimal CalculateTotalPrice(Order order)
		{
			decimal grandTotal = 0;
			if (order == null || order.Products == null)
			{
				throw new InvalidOrderException();
			}

			foreach (var ruleEngine in this._ruleEngines)
			{
				if (ruleEngine.Rule.Id == 1)
				{
					var products = order.Products.Where(p => p.Product.RuleId == ruleEngine.Rule.Id).ToList();
					if (products.Any())
					{
						grandTotal += ruleEngine.CalculatePrice(products);
					}
				}
				else
				{
					var products = order.Products.Where(p => p.Product.RuleId == ruleEngine.Rule.Id).ToList();
					products.ForEach(p =>
						{
							grandTotal += ruleEngine.CalculatePrice(new List<ShortlistedProduct>() { p });
						}
					);
				}

			}
			return grandTotal;
		}

	}
}
