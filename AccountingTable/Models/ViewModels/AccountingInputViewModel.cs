using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AccountingTable.Models.ViewModels
{
    public class AccountingInputViewModel
    {
        public Guid Id { get; set; }

        [DisplayName( "類別" )]
        public CategoryEnum Category { get; set; }

        [Required( ErrorMessage = "金額為必填項目" )]
        [Remote( "Amount", "Validate", ErrorMessage = "請輸入正整數" )]
        [DisplayName( "金額" )]
        public int Amount { get; set; }

        [Required( ErrorMessage = "日期為必填項目" )]
        [Remote( "Date", "Validate", ErrorMessage = "日期不可超過今天" )]
        [DisplayName( "日期" )]
        [DataType( DataType.Date )]
        public DateTime Date { get; set; }

        [Required( ErrorMessage = "備註為必填項目" )]
        [StringLength( 100, ErrorMessage = "長度不可超過 {0} 個字元" )]
        [DisplayName( "備註" )]
        public string Remark { get; set; }
    }
}