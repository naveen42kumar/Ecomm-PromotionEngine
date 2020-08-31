using System;
using System.Collections.Generic;

namespace Ecom.PromotionEngine.DAL
{
	public interface ICommonRepository<TEntity, TEntityIdentifier>
	{
		/// <summary>
		/// Gets all entities
		/// </summary>
		/// <returns></returns>
		 ICollection<TEntity> GetAll();

		/// <summary>
		/// Creates a new entity.
		/// </summary>
		/// <returns>Returns created entity</returns>
		TEntity Create();

		/// <summary>
		/// Deletes provided entity
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		bool Delete(TEntity t);

	}
}