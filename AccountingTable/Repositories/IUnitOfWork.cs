using System;
using System.Data.Entity;

namespace AccountingTable.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        DbContext Context { get; set; }

        void Save( );
    }
}