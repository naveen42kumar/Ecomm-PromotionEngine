using System;
using System.Collections.Generic;
using System.Text;
using Ecom.PromotionEngine.Entity;

namespace Ecom.PromotionEngine.Business.Interfaces
{
	interface IProducts
	{
		/// <summary>
		/// Get the all products
		/// </summary>
		/// <returns>Products</returns>
		 IList<Product> GetProducts();
	}
}
