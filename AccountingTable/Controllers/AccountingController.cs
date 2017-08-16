using AccountingTable.Models.ViewModels;
using AccountingTable.Repositories;
using AccountingTable.Services;
using AutoMapper.QueryableExtensions;
using MvcPaging;
using System.Linq;
using System.Web.Mvc;

namespace AccountingTable.Controllers
{
    public class AccountingController : Controller
    {
        private readonly AccountService _accountService;
        private const int PAGE_SIZE = 10;

        public AccountingController( )
        {
            var unitOfWork = new EFUnitOfWork( );
            _accountService = new AccountService( unitOfWork );
        }

        public ActionResult Accounting( int? page )
        {
            var currentPage = page.HasValue ? page.Value - 1 : 0;
            var result = _accountService.ReadAll( ).OrderBy( x => x.Dateee ).ProjectTo<AccountingViewModel>( );
            return View( result.ToPagedList( currentPage, PAGE_SIZE ) );
        }
    }
}