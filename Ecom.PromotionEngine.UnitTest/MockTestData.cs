using System;
using System.Collections.Generic;
using System.Text;
using Ecom.PromotionEngine.Business.Implementation;
using Ecom.PromotionEngine.Business.Interfaces;
using Ecom.PromotionEngine.Entity;

namespace Ecom.PromotionEngine.UnitTest
{
	/// <summary>
	/// Class to prepare mock data.
	/// </summary>
	public static class MockTestData
	{
		public static CartEngine InitializeCartEngine()
		{
			List<IRuleEngine> ruleEngines = initializeRuleEngine();
			return new CartEngine(ruleEngines);
		}

		private static List<IRuleEngine> initializeRuleEngine()
		{
			return new List<IRuleEngine>()
			{
				new SingleProductRule(20,3, 2),
				new SingleProductRule(15,2, 3),
				new CombinedPriceRule(5, new List<char>(){'C','D'})
			};
		}

		/// <summary>
		/// Product list initializer.
		/// </summary>
		/// <returns></returns>
		public static List<ShortlistedProduct> InitializeProductsScenarioA()
		{
			return new List<ShortlistedProduct>()
			{
				new ShortlistedProduct()
				{
					Quantity = 1,
					Product = new Product()
					{
						Price = 50,
						Sku = 'A',
						RuleId = 2,
						Id = 1,
						Name = "ProductA"
					}
				},
				new ShortlistedProduct()
				{
					Quantity = 1,
					Product = new Product()
					{
						Price = 30,
						Sku = 'B',
						RuleId = 3,
						Id = 2,
						Name = "ProductB"
					}
				},
				new ShortlistedProduct()
				{
					Quantity = 1,
					Product = new Product()
					{
						Price = 20,
						Sku = 'C',
						RuleId = 1,
						Id = 3,
						Name = "ProductC"
					}
				}
			};
		}

		public static List<ShortlistedProduct> InitializeProductsScenarioB()
		{
			return new List<ShortlistedProduct>()
			{
				new ShortlistedProduct()
				{
					Quantity = 5,
					Product = new Product()
					{
						Price = 50,
						Sku = 'A',
						RuleId = 2,
						Id = 1,
						Name = "ProductA"
					}
				},
				new ShortlistedProduct()
				{
					Quantity = 5,
					Product = new Product()
					{
						Price = 30,
						Sku = 'B',
						RuleId = 3,
						Id = 2,
						Name = "ProductB"
					}
				},
				new ShortlistedProduct()
				{
					Quantity = 1,
					Product = new Product()
					{
						Price = 20,
						Sku = 'C',
						RuleId = 1,
						Id = 3,
						Name = "ProductC"
					}
				}
			};
		}


		public static List<ShortlistedProduct> InitializeProductsScenarioC()
		{
			return new List<ShortlistedProduct>()
			{
				new ShortlistedProduct()
				{
					Quantity = 3,
					Product = new Product()
					{
						Price = 50,
						Sku = 'A',
						RuleId = 2,
						Id = 1,
						Name = "ProductA"
					}
				},
				new ShortlistedProduct()
				{
					Quantity = 5,
					Product = new Product()
					{
						Price = 30,
						Sku = 'B',
						RuleId = 3,
						Id = 2,
						Name = "ProductB"
					}
				},
				new ShortlistedProduct()
				{
					Quantity = 1,
					Product = new Product()
					{
						Price = 20,
						Sku = 'C',
						RuleId = 1,
						Id = 3,
						Name = "ProductC"
					}
				},
				new ShortlistedProduct()
				{
					Quantity = 1,
					Product = new Product()
					{
						Price = 15,
						Sku = 'D',
						RuleId = 1,
						Id = 3,
						Name = "ProductD"
					}
				}
			};
		}
	}
}
