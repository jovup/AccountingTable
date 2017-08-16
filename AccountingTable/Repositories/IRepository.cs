using System;
using System.Linq;
using System.Linq.Expressions;

namespace AccountingTable.Repositories
{
    public interface IRepository<T> where T : class
    {
        IUnitOfWork UnitOfWork { get; set; }

        IQueryable<T> ReadAll( );

        IQueryable<T> Read( Expression<Func<T, bool>> predicate );

        void Create( T entity );

        void Delete( T entity );

        void SaveChanges( );
    }
}