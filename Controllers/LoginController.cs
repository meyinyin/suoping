using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace suoping2.Controllers
{
    public class LoginController : Controller
    {
        public Maticsoft.BLL.Login lbll = new Maticsoft.BLL.Login();

        // GET: Login
        [AllowAnonymous]
        public ActionResult Index(bool IsSuccess = false)
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public  ActionResult Index(Maticsoft.Model.Login model)
        {

            var target = lbll.GetModel(1);
            if (model.LName == "suoping" && model.LPwd == "suoping")
            {
                Session.Timeout = 360;
                Session["login"] = true;
                Session["level"] = 1;
                return RedirectToAction("Index2", "Manger");
            }
            else {
                if (model.LName == target.LName && model.LPwd == target.LPwd)
                {
                    Session.Timeout = 120;
                    Session["login"] = true;
                    return RedirectToAction("Index", "Manger");
                }
                else
                {
                    ViewBag.IsLogin = false;
                    return RedirectToAction("Index", "Login");
                }
            }
            
            
        }

        #region 注销
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }

        #endregion  
        #region 过滤器
        public class LoginAuthorizeAttribute : AuthorizeAttribute
        {

            protected override bool AuthorizeCore(HttpContextBase httpContext)
            {
                //return base.AuthorizeCore(httpContext);

                //return (bool)httpContext.Session["login"];
                bool Pass = false;
                if (httpContext.Session["login"] == null|| !(bool)httpContext.Session["login"])
                {
                    //httpContext.Response.StatusCode = 401;//无权限状态码  
                    Pass = false;
                }
                else
                {
                
                    Pass = true;
                }
                return Pass;
            }


            protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
            {
                //base.HandleUnauthorizedRequest(filterContext);
                //if(filterContext.HttpContext.Response.StatusCode == 401)
                //{
                //    filterContext.Result = new RedirectResult("/Login/Index");

                //}
                filterContext.HttpContext.Response.Redirect("/Login/Index");
            }
        }
        #endregion  
    }
}