using InsuranceQuoteExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InsuranceQuoteExercise.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsuranceQuote(string firstName, string lastName, string emailAddress, DateTime dateOfBirth,
                                            int carYear, string carMake, string carModel, string dui, int speedTicket, string coverage)
        {

            using (InsuranceQuoteEntities db = new InsuranceQuoteEntities())
            {
                var userinfo = new UserInfo();
                userinfo.FirstName = firstName;
                userinfo.LastName = lastName;
                userinfo.EmailAddress = emailAddress;
                userinfo.DateOfBirth = dateOfBirth;
                userinfo.CarYear = carYear;
                userinfo.CarMake = carMake;
                userinfo.CarModel = carModel;
                userinfo.Dui = dui;
                userinfo.SpeedTicket = speedTicket;
                userinfo.Coverage = coverage;
                userinfo.Total = 50;
                
                var today = DateTime.Today;
                var age = today.Year - dateOfBirth.Year;
                if (age < 25 && age >= 18)
                {
                    userinfo.Total += 25;
                }
                else if (age < 18)
                {
                    userinfo.Total += 100;
                }
                else if (age > 100)
                {
                    userinfo.Total += 25;
                }

                if (userinfo.CarYear < 2000)
                {
                    userinfo.Total += 25;
                }
                else if (userinfo.CarYear > 2015)
                {
                    userinfo.Total += 25;
                }

                if (userinfo.CarMake.ToLower() == "porche")
                {
                    userinfo.Total += 25;
                }

                if (userinfo.CarMake.ToLower() == "porche" && userinfo.CarModel.ToLower() =="911 carrera")
                {
                    userinfo.Total += 25;
                }
                
                if (userinfo.SpeedTicket > 0)
                {
                    for (int i = 1; i <= userinfo.SpeedTicket; i++)
                    {
                        userinfo.Total += 10;
                    }
                }

                if (userinfo.Dui == "Yes")
                {
                    int p = Convert.ToInt32(userinfo.Total) * 25 / 100;
                    userinfo.Total += p;
                }

                if (userinfo.Coverage == "Full Coverage")
                {
                    int p = Convert.ToInt32(userinfo.Total) * 50 / 100;
                    userinfo.Total += p;
                }
                
                db.UserInfoes.Add(userinfo);
                db.SaveChanges();

                return View("Quote", userinfo);
            }
        }
    }
}