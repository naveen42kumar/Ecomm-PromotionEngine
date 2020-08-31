using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.PromotionEngine.Business.Exception
{
	public class InvalidOrderException : System.Exception
	{
		public override string Message
		{
			get
			{
				return "Order details are incorrect.";
			}
		}
	}
}
