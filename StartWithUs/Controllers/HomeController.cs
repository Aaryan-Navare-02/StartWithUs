using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StartWithUs.Models;
using StartWithUs.SWTDataDB;
//using Microsoft.AspNet.Mvc;
using Investor = StartWithUs.SWTDataDB.Investor;
using Enterpreneur = StartWithUs.SWTDataDB.Enterpreneur;
using Feedback = StartWithUs.SWTDataDB.Feedback;
using Company = StartWithUs.SWTDataDB.Company;
using System.IO;

public class HomeController : Controller
{
    public ActionResult Index()
    {

        return View();
    }

    public ActionResult About()
    {
        return View();
    }
    [HttpGet]
    public ActionResult Contact()
    {
        return View();
    }
    [HttpPost]
    public ActionResult Contact(FeedbackModel feedbackModel)
    {
        StartWithUsContext startWithUsContext = new StartWithUsContext();
        try
        {
            var feedbackDetails = new Feedback()
            {
                Name = feedbackModel.name,
                Email = feedbackModel.email,
                Message = feedbackModel.message,
                Subject = feedbackModel.subject
            };
            startWithUsContext.Feedback.Add(feedbackDetails);
            startWithUsContext.SaveChanges();
            ViewBag.Status = 1;
        }
        catch
        {
            ViewBag.Status = 0;
        }
        return View();
    }
    public ActionResult Services()
    {
        return View();
    }
    public ActionResult TNC()
    {
        return View();
    }

    public ActionResult Login()
    {
        return View();
    }
    public ActionResult MyAccount()
    {
        return View();
    }
    public ActionResult SaveChanges()
    {
        return View();
    }
    [HttpGet]
    public ActionResult BusinessLogin()
    {
        BusinessLoginModel businessLoginModel = new BusinessLoginModel();
        return View(businessLoginModel);
    }
    [HttpPost]
    public ActionResult BusinessLogin(BusinessLoginModel businessLoginModel)
    {

        StartWithUsContext startWithUsContext = new StartWithUsContext();
        Session["BID"] = Convert.ToString(businessLoginModel.EnterpreneurId);
        var status = startWithUsContext.Enterpreneur.Where(m => m.EnterpreneurId == businessLoginModel.EnterpreneurId && m.Password == businessLoginModel.Password).FirstOrDefault();
        if (status == null)
        {
            ViewBag.LoginStatus = 0;
        }
        else
        {
            Session["Name"] = status.Name.ToString();
            Session["DoB"] = Convert.ToDateTime(status.Dob).Date;
            Session["Address"] = status.Address.ToString();
            Session["Email"] = status.Email.ToString();
            Session["MobileNo"] = status.MobileNo.ToString();
            //return RedirectToAction("MyAccount","Home");
            return RedirectToAction("Index", "Home");
        }
        return View(businessLoginModel);
    }
    [HttpGet]
    public ActionResult BusinesSignUp()
    {
        return View();
    }
    [HttpPost]
    public ActionResult BusinesSignUp(BusinessSignUpModel businessSignUpModel)
    {
        StartWithUsContext startWithUsContext = new StartWithUsContext();
        try
        {
            var EnterpreneurDetails = new Enterpreneur()
            {
                Name = businessSignUpModel.Name,
                EnterpreneurId = businessSignUpModel.EnterpreneurId,
                Pan = businessSignUpModel.PAN,
                Email = businessSignUpModel.Email,
                MobileNo = businessSignUpModel.MobileNo,
                Dob = Convert.ToDateTime(businessSignUpModel.DOB).Date,
                Address = businessSignUpModel.Address,
                Password = businessSignUpModel.Password
            };
            startWithUsContext.Enterpreneur.Add(EnterpreneurDetails);
            startWithUsContext.SaveChanges();
            ViewBag.Status = 1;
        }
        catch
        {
            ViewBag.Status = 0;
        }
        return View();
    }
    [HttpGet]
    public ActionResult CompanyDetails()
    {
        //CompanyDetailsModel companyDetailsModel = new CompanyDetailsModel();
        return View();
    }
    [HttpPost]
    public ActionResult CompanyDetails(CompanyDetailsModel companyDetailsModel, HttpPostedFileBase CompanyImage)
    {
        if (CompanyImage != null)
        {
            companyDetailsModel.CompanyImage = new byte[CompanyImage.ContentLength];
            CompanyImage.InputStream.Read(companyDetailsModel.CompanyImage,0,CompanyImage.ContentLength);
        }
        return View();
    }
  
    [HttpGet]
    public ActionResult InvestorLogin()
    {

        InvestorModel investorModel = new InvestorModel();
        //StartWithUsContext startWithUsContext = new StartWithUsContext();
        //var Investor = startWithUsContext.Investor;
        return View(investorModel);
    }
    [HttpPost]
    public ActionResult InvestorLogin(InvestorModel investorModel)
    {
        StartWithUsContext startWithUsContext = new StartWithUsContext();
        Session["ID"] = Convert.ToString(investorModel.InvestorId);
        var status = startWithUsContext.Investor.Where(m => m.InvestorId == investorModel.InvestorId && m.Password == investorModel.Password).FirstOrDefault();
        if (status == null)
        {
            ViewBag.LoginStatus = 0;
        }
        else
        {
            Session["Name"] = status.Name.ToString();
            Session["DoB"] = Convert.ToDateTime(status.Dob).Date;
            Session["Address"] = status.Address.ToString();
            Session["Email"] = status.EmailId.ToString();
            Session["MobileNo"] = status.MobileNo.ToString();
            //return RedirectToAction("MyAccount","Home");
            return RedirectToAction("Index", "Home");

        }
        return View(investorModel);
    }
    public ActionResult Logout()
    {
        Session.Abandon();
        return RedirectToAction("Index", "Home");
    }
    public ActionResult ExploreCompanies()
    {
        return View();
    }
    [HttpGet]
    public ActionResult InvestorSignUp()
    {

        //InvestorModel investorModel = new InvestorModel();
        return View();
    }
    [HttpPost]
    public ActionResult InvestorSignUp(InvestorSignUp investorSignUp)
    {

        StartWithUsContext startWithUsContext = new StartWithUsContext();
        try
        {
            var investorData = new Investor()
            {
                InvestorId = investorSignUp.InvestorId.ToString(),
                Name = investorSignUp.Name,
                Dob = Convert.ToDateTime(investorSignUp.DOB).Date,
                EmailId = investorSignUp.EmailId,
                Pannumber = investorSignUp.PANNumber,
                MobileNo = investorSignUp.MobileNo,
                Address = investorSignUp.Address,
                Password = investorSignUp.Password
            };
            startWithUsContext.Investor.Add(investorData);
            startWithUsContext.SaveChanges();
            ViewBag.Status = 1;
        }
        catch
        {
            ViewBag.Status = 0;
        }
        return View();
    }
    public ActionResult LosPollosHermosa()
    {
        return View();
    }
    public ActionResult KrispyFriedPotato()
    {
        return View();
    }
    public ActionResult BlueMath()
    {
        return View();
    }
    public ActionResult Sysfonics()
    {
        return View();
    }
    public ActionResult KingBurger()
    {
        return View();
    }
    public ActionResult Doracabs()
    {
        return View();
    }
    public ActionResult Hermosa()
    {
        return View();
    }
    public ActionResult PizzaBest()
    {
        return View();
    }
    public ActionResult Capscorpion()
    {
        return View();
    }
    public ActionResult LoginChoice()
    {
        return View();
    }
    public ActionResult InvestNow()
    {

        ViewBag.CompaniesSelectList = new SelectList(GetCompanies(), "Id", "Title");

        return View();
    }
    private List<CompanyVM> GetCompanies()
    {
        var companies = new List<CompanyVM>();
        companies.Add(new CompanyVM() { Id = 1, Title = "Los Pollos Hermanos" });
        companies.Add(new CompanyVM() { Id = 2, Title = "KFP" });
        companies.Add(new CompanyVM() { Id = 3, Title = "Blue Math" });
        companies.Add(new CompanyVM() { Id = 4, Title = "Sysfonics Solution" });
        companies.Add(new CompanyVM() { Id = 4, Title = "King's Burger" });
        companies.Add(new CompanyVM() { Id = 4, Title = "Dora Cabs" });
        companies.Add(new CompanyVM() { Id = 4, Title = "Hermosa Enterprise" });
        companies.Add(new CompanyVM() { Id = 4, Title = "Pizza Best" });
        companies.Add(new CompanyVM() { Id = 4, Title = "Capscorpion" });

        return companies;
    }
    public ActionResult PayNow()
    {
        return View();
    }
    public ActionResult PaymentSuccessful()
    {
        return View();
    }

}
