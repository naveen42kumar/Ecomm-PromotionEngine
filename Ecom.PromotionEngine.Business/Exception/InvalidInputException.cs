using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.PromotionEngine.Business.Exception
{
	class InvalidInputException : System.Exception
	{
		public override string Message
		{
			get
			{
				return "input is invalid.";
			}
		}
    }
}
