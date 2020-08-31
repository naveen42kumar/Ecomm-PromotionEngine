using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecom.PromotionEngine.Entity
{
	/// <summary>
	/// Entity to hold the Order details
	/// </summary>
	public class Order 
	{
		/// <summary>
		/// Order unique identifier
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Product and its order details
		/// </summary>
		public IList<ShortlistedProduct> Products { get; set; }

		/// <summary>
		/// Time stamp of purchase
		/// </summary>
		public DateTime PurchasedDate { get; set; }

	}
}
