using Ecom.PromotionEngine.Business.Exception;
using Ecom.PromotionEngine.Business.Interfaces;
using Ecom.PromotionEngine.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ecom.PromotionEngine.UnitTest
{
	[TestClass]
	public class CartPriceCalculationTest
	{
		private ICartPriceCalculator _cartEngine;
		[TestInitialize]
		public void Init()
		{
			_cartEngine = MockTestData.InitializeCartEngine();
		}

		[TestMethod]
		public void Test_CartPrice_SingleQuanity()
		{
			var products = MockTestData.InitializeProductsScenarioA();
			var order = new Order()
			{
				Products = products,
				Id = 123
			};

			var price = _cartEngine.CalculateTotalPrice(order);
			Assert.AreEqual(price, 100.0M);
		}

		[TestMethod]
		public void Test_CartPrice_MultipleQuanity()
		{
			var products = MockTestData.InitializeProductsScenarioB();
			var order = new Order()
			{
				Products = products,
				Id = 123
			};

			var price = _cartEngine.CalculateTotalPrice(order);
			Assert.AreEqual(price, 370.0M);
		}


		[TestMethod]
		public void Test_CartPrice_MultipleQuanity_CombinedRule()
		{
			var products = MockTestData.InitializeProductsScenarioC();
			var order = new Order()
			{
				Products = products,
				Id = 123
			};

			var price = _cartEngine.CalculateTotalPrice(order);
			Assert.AreEqual(price, 280.0M);
		}

		[TestMethod]
		[ExpectedException(typeof(InvalidOrderException))]
		public void Test_CartPRice_InvalidOrder()
		{
			var order = new Order();
			this._cartEngine.CalculateTotalPrice(order);
		}
	}


}
