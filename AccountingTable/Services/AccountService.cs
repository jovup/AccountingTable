using AccountingTable.Models;
using AccountingTable.Repositories;
using System.Linq;

namespace AccountingTable.Services
{
    public class AccountService
    {
        private readonly IRepository<AccountBook> _accountBookRepo;
        private readonly IUnitOfWork _unitOfWork;

        public AccountService( IUnitOfWork unitOfWork )
        {
            _unitOfWork = unitOfWork;
            _accountBookRepo = new Repository<AccountBook>( unitOfWork );
        }

        public IQueryable<AccountBook> ReadAll( )
        {
            return _accountBookRepo.ReadAll( );
        }

        public void Create( AccountBook inputData )
        {
            _accountBookRepo.Create( inputData );
        }

        public void Save( )
        {
            _accountBookRepo.SaveChanges( );
        }
    }
}