using System;
using System.Collections.Generic;
using System.Text;

namespace Ecom.PromotionEngine.DAL
{
	public class CommonRepository<TEntity, TEntityIdentifier> : ICommonRepository<TEntity, TEntityIdentifier>
	{
		/// <summary>
		/// Gets all entities
		/// </summary>
		/// <returns></returns>
		public ICollection<TEntity> GetAll()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Creates a new entity.
		/// </summary>
		/// <returns>Returns created entity</returns>
		public TEntity Create()
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Deletes provided entity
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		public bool Delete(TEntity t)
		{
			throw new NotImplementedException();
		}
	}
}
