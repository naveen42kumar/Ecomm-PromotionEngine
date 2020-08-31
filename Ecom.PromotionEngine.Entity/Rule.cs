namespace Ecom.PromotionEngine.Entity
{
	/// <summary>
	/// Class holds the discount rule information
	/// </summary>
	public class Rule
	{
		/// <summary>
		/// Unique identifier of the Rule
		/// </summary>
		public long Id { get; set; }

		/// <summary>
		/// Name of the rule.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Details of the rule
		/// </summary>
		public string Details { get; set; }

	}
}
