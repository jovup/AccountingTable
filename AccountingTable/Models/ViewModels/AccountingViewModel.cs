using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AccountingTable.Models.ViewModels
{
    public class AccountingViewModel
    {
        [DisplayName( "類別" )]
        public CategoryEnum Type { get; set; }

        [DisplayName( "日期" )]
        [DataType( DataType.Date )]
        [DisplayFormat( DataFormatString = "{0:yyyy-MM-dd}" )]
        public DateTime Date { get; set; }

        [DisplayName( "金額" )]
        [DisplayFormat( DataFormatString = "{0:#,0}" )]
        public decimal Amount { get; set; }
    }
}