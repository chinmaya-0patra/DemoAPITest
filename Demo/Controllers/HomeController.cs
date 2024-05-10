using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{

    [Route("api/[controller]")]
    //[ApiController]
    public class HomeController : Controller
    {


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        private readonly MyDb _context;

        public HomeController()
        {
            _context = new MyDb();
        }

        

        public ActionResult Index()
        {
            try
            {
                var salesData = _context.Sales1.ToList();

                var response = salesData.Select(sale => new
                {
                    Sale_Order_Code = sale.Sale_Order_Code,
                    Customer_Paid_Amount = sale.Customer_Paid_Amount,
                    Tcs_Igst_Amount = sale.Tcs_Igst_Amount,
                    Tds_Amount = sale.tds_amount,
                    Charges = sale.Charges,
                    Logistics_Amount = sale.LogisticsAmount
                }).ToList();

                return Json(response, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                // Log the exception
                return Json(new { error = "An error occurred while processing your request." }, JsonRequestBehavior.AllowGet);
            }
        }

    }
}