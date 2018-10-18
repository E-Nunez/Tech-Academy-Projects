using InsuranceQuoteExercise.Models;
using InsuranceQuoteExercise.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuoteExercise.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
            {
                var userinfos = db.UserInfoes.ToList();
                var userinfoVms = new List<UserinfoVm>();
                foreach (var userinfo in userinfos)
                {
                    var userinfoVm = new UserinfoVm();
                    userinfoVm.FirstName = userinfo.FirstName;
                    userinfoVm.LastName = userinfo.LastName;
                    userinfoVm.EmailAddress = userinfo.EmailAddress;
                    userinfoVm.Total = Convert.ToInt32(userinfo.Total);
                    userinfoVms.Add(userinfoVm);
                }
                return View(userinfoVms);
            }
            
        }
    }
}