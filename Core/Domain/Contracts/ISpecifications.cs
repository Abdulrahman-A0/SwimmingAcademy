using Domain.Entities.Base;
using System.Linq.Expressions;

namespace Domain.Contracts
{
    public interface ISpecifications<TEntity, TKey> where TEntity : BaseEntity<TKey>
    {
        public Expression<Func<TEntity, bool>>? Criteria { get; }
        public List<Expression<Func<TEntity, object>>> IncludeExpressions { get; }
        public List<Func<IQueryable<TEntity>, IQueryable<TEntity>>> ThenIncludeExpressions { get; }
        public Expression<Func<TEntity, object>> OrderBy { get; }
        public Expression<Func<TEntity, object>> OrderByDescending { get; }
        int Take { get; }
        int Skip { get; }
        bool IsPaginated { get; }

    }
}
