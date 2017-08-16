using AccountingTable.Models;
using System.Data.Entity;

namespace AccountingTable.Repositories
{
    public class EFUnitOfWork : IUnitOfWork
    {
        public DbContext Context { get; set; }

        public EFUnitOfWork( )
        {
            Context = new SkillTreeHomeworkEntities( );
        }

        public void Dispose( )
        {
            Context.Dispose( );
        }

        public void Save( )
        {
            Context.SaveChanges( );
        }
    }
}