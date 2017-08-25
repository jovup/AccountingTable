using AccountingTable.Models;
using AccountingTable.Models.ViewModels;
using AccountingTable.Repositories;
using AccountingTable.Services;
using AutoMapper;
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

        public ActionResult Accounting( )
        {
            return View( );
        }

        [HttpPost]
        public ActionResult Accounting( AccountingInputViewModel inputData )
        {
            var accountBookData = Mapper.Map<AccountBook>( inputData );
            _accountService.Create( accountBookData );
            _accountService.Save( );

            return RedirectToAction( "Accounting" );
        }

        public ActionResult ShowTable( int? page )
        {
            var currentPage = page.HasValue ? page.Value - 1 : 0;
            var result = _accountService.ReadAll( ).OrderByDescending( x => x.Dateee ).ProjectTo<AccountingViewModel>( );
            return PartialView( "_AccountingTablePartialView", result.ToPagedList( currentPage, PAGE_SIZE ) );
        }
    }
}