using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Demo.Models
{

    // I have created Database named Sales1
    public class Sale
    {
        [Key]
        public int id { get; set; }

        public string Sale_Order_Code { get; set; }

        public Decimal Customer_Paid_Amount { get; set; }
        public Decimal Tcs_Igst_Amount { get; set; }
        public Decimal tds_amount { get; set; }
        public Decimal Charges { get; set; }
        public Decimal LogisticsAmount { get; set; }
    }
}