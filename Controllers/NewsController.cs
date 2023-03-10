using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace suoping2.Controllers
{
    [AllowAnonymous]
    public class NewsController : Controller
    {
        public Maticsoft.BLL.News nbll = new Maticsoft.BLL.News();
        public Maticsoft.BLL.SortType sbll = new Maticsoft.BLL.SortType();
        // GET: News
        /// <summary>
        /// 官网前台新闻页(法律咨询)
        /// </summary>
        /// <returns></returns>
        public ActionResult Index(int page = 1, int sort = 0, int day = 0, string keyword = "", int pagesize = 10, int id = 0)
        {
            var where1 = "IsLock=1";
            var temp = nbll.GetModelList(where1).OrderByDescending(c => c.AddDateTime).ToList();
            //var temp = new List<Maticsoft.Model.News>();
            if (keyword != "")
            {
                temp = temp.Where(c => c.Title.Contains(keyword) || c.Content.Contains(keyword)).ToList();
            }
            if (sort != 0)
            {
                temp = temp.Where(c => c.SortID == sort).ToList();
            }
            if (day != 0)
            {
                DateTime now = DateTime.Now;
                temp = temp.Where(c => (((DateTime)c.AddDateTime) - now) <= new TimeSpan(day, 0, 0, 0, 0)).ToList();
            }
            ViewBag.PageStr = string.Format("?page={0}&sort={1}&day={2}&keyword={3}&pagesize={4}", page, sort, day, keyword, pagesize);
            ViewBag.Str = string.Format("&sort={0}&day={1}&keyword={2}&pagesize={3}", sort, day, keyword, pagesize);
            ViewBag.PageCount = (int)((temp.Count - 1) / pagesize) + 1;
            ViewBag.PageCounts = (int)((temp.Count - 1) / pagesize) - 1;
            ViewBag.CurrentPage = page;
            ViewBag.RowCount = temp.Count;
            ViewBag.SortID = sort;
            return View(temp.Skip((page - 1) * pagesize).Take(pagesize).ToList());
        }
        public ActionResult NewsShow(int ID)
        {
            var where ="ID="+ ID + "and IsLock=1";
            var list = nbll.GetModelList(where);
            ViewBag.list = list;
            ViewBag.id = ID;
            return View(list);
        }
    }
}