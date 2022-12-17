using suoping2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace suoping2.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        public Maticsoft.BLL.Message mbll = new Maticsoft.BLL.Message();
        public Maticsoft.BLL.About abll = new Maticsoft.BLL.About();
        
        /// <summary>
        /// 首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 关于我们
        /// </summary>
        /// <returns></returns>
        public ActionResult About()
        {
            string where = "ID=1";
            var list = abll.GetModelList(where);
            return View(list);
        }
        /// <summary>
        /// 联系我们
        /// </summary>
        /// <returns></returns>
        public ActionResult Contact(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        [HttpPost]
        public ActionResult Contact(Maticsoft.Model.Message model)
        {
            try
            {
                var result = mbll.Add(model);
                return RedirectToAction("Contact", new ResultCode { IsSuccess = true, Msg = "留言提交成功", Code = 200 });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Contact", new ResultCode { IsSuccess = false, Msg = "留言提交出现错误:" + ex, Code = 200 });
            }

        }
        /// <summary>
        /// 前台留言页面
        /// </summary>
        /// <param name="IsSuccess">是否提交成功</param>
        /// <returns></returns>
        //public ActionResult Message(bool IsSuccess = false)
        //{
        //    ViewBag.IsSuccess = IsSuccess;
        //    return View();
        //}
        //[HttpPost]
        //public ActionResult Message(Maticsoft.Model.Message model)
        //{
        //    try
        //    {
        //        var result = mbll.Add(model);
        //        return RedirectToAction("Message", new ResultCode { IsSuccess = true,Msg="留言提交成功",Code=200 }) ;
        //    }
        //    catch(Exception ex)
        //    {
        //        return RedirectToAction("Message", new ResultCode { IsSuccess = false, Msg = "留言提交出现错误:"+ex, Code = 200 });
        //    }
          
        //}
        /// <summary>
        /// 荣誉页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Honor()
        {
            //string where = "ID=1";
            //var list = abll.GetModelList(where);
            //return View(list);
            return View();
        }
        /// <summary>
        /// 基地首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Jidi()
        {
            string where = "ID=1";
            var list = abll.GetModelList(where);
            return View(list);
        }
    };
}