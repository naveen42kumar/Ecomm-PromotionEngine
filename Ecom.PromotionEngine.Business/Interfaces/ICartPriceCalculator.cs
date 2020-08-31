using Ecom.PromotionEngine.Entity;

namespace Ecom.PromotionEngine.Business.Interfaces
{
	public interface ICartPriceCalculator
	{
		/// <summary>
		/// Calculates the complete order
		/// </summary>
		/// <param name="order">Complete order details</param>
		/// <returns>Returns the grand total.</returns>
		decimal CalculateTotalPrice(Order order);
	}
}
