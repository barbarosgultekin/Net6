﻿using Core.BaseEntity;
using System.Linq.Expressions;


namespace DataAccess.Repositories
{
    public interface IRepository<TEntity>
    where TEntity:class,IBaseEntity,new()
    {
        /// <summary>
        /// To Table
        /// </summary>
        IQueryable<TEntity> Table { get; }       
        
        /// <summary>
        ///  Get Entity by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> Get(int id);
        Task <List<TEntity>> GetAll();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="filter"></param>
        /// <returns></returns>
        Task<TEntity> Get(Expression<Func<TEntity, bool>> filter);

        /// <summary>
        /// Insert Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task Insert(TEntity entity);

        /// <summary>
        /// Update Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task Update(TEntity entity);

        /// <summary>
        /// Delete Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task Delete(TEntity entity);
        TEntity GetById(int id);
       
                       
    }
}