using AccountingTable.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingTable.Controllers
{
    public class AccountingController : Controller
    {
        public ActionResult Accounting( )
        {
            var fakeDataList = new List<AccountingViewModel>
            {
                new AccountingViewModel{Type="支出",Date=DateTime.Parse("2017/01/01"),Amount=1000},
                new AccountingViewModel{Type="支出",Date=DateTime.Parse("2017/01/02"),Amount=500},
                new AccountingViewModel{Type="支出",Date=DateTime.Parse("2017/01/03"),Amount=1500},
                new AccountingViewModel{Type="支出",Date=DateTime.Parse("2017/01/04"),Amount=20000}
            };

            return View( fakeDataList );
        }
    }
}