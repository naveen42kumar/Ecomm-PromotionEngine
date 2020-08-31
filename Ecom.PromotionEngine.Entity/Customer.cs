using System;

namespace Ecom.PromotionEngine.Entity
{
	/// <summary>
	/// Class holds the data related the customer details
	/// </summary>
	public class Customer
	{
		/// <summary>
		/// User unique identifier
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Name of the customer
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Customer Mobile number
		/// </summary>
		public string MobileNo { get; set; }

		/// <summary>
		/// Customer email address
		/// </summary>
		public string EmailId { get; set; }

		/// <summary>
		/// Delivery address of the customer
		/// </summary>
		public string Address { get; set; }
	}
}
