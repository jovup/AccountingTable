using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace AccountingTable.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        public IUnitOfWork UnitOfWork { get; set; }

        private DbSet<T> _dbSet;

        private DbSet<T> DbSet
        {
            get
            {
                if ( _dbSet == null )
                {
                    _dbSet = UnitOfWork.Context.Set<T>( );
                }
                return _dbSet;
            }
        }

        public Repository( IUnitOfWork unitOfWork )
        {
            UnitOfWork = unitOfWork;
        }

        public void Create( T entity )
        {
            DbSet.Add( entity );
        }

        public void Delete( T entity )
        {
            DbSet.Remove( entity );
        }

        public IQueryable<T> Read( Expression<Func<T, bool>> predicate )
        {
            return DbSet.Where( predicate );
        }

        public IQueryable<T> ReadAll( )
        {
            return DbSet;
        }

        public void SaveChanges( )
        {
            UnitOfWork.Save( );
        }
    }
}