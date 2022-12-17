using suoping2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static suoping2.Controllers.LoginController;

namespace suoping2.Controllers
{
    [LoginAuthorize]
    public class MangerController : Controller
    {
        
        public Maticsoft.BLL.Message mbll = new Maticsoft.BLL.Message();
        public Maticsoft.BLL.News nbll = new Maticsoft.BLL.News();
        public Maticsoft.BLL.SortType sbll = new Maticsoft.BLL.SortType();
        public Maticsoft.BLL.Product pbll = new Maticsoft.BLL.Product();
        public Maticsoft.BLL.About abll = new Maticsoft.BLL.About();
        public Maticsoft.BLL.Login lbll = new Maticsoft.BLL.Login();
        public Maticsoft.BLL.GMile gbll = new Maticsoft.BLL.GMile();
        // GET: Manger
        #region 首页
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 客服页面
        /// </summary>
        /// <returns></returns>
        public ActionResult Index2() {
            return View();
        }
        public ActionResult Welcome()
        {
            return View();
        }
        #endregion


        #region 留言板模块
        /// <summary>
        /// 留言板首页
        /// </summary>
        /// <returns></returns>
        public ActionResult Email(int page = 1, int sort = 0, int day = 0, string keyword = "", int pagesize = 10, int id = 0)
        {
            var temp = mbll.GetModelList("").OrderByDescending(c => c.MDate).ToList();
            ViewBag.PageStr = string.Format("?page={0}&sort={1}&day={2}&keyword={3}&pagesize={4}", page, sort, day, keyword, pagesize);
            ViewBag.Str = string.Format("&sort={0}&day={1}&keyword={2}&pagesize={3}", sort, day, keyword, pagesize);
            ViewBag.PageCount = (int)((temp.Count - 1) / pagesize) + 1;
            ViewBag.CurrentPage = page;
            ViewBag.RowCount = temp.Count;
            return View(temp.Skip((page - 1) * pagesize).Take(pagesize).ToList());
        }
        /// <summary>
        /// 留言板删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult EmailDel(int ID)
        {
            var del = mbll.Delete(ID);
            return RedirectToAction("Email");
        }
        #endregion

        #region 新闻模块
        /// <summary>
        /// 新闻首页
        /// </summary>
        /// <param name="page">当前页码</param>
        /// <param name="sort">当前栏目</param>
        /// <param name="day">时间</param>
        /// <param name="keyword">关键字</param>
        /// <param name="pagesize">每页显示多少条记录</param>
        /// <returns></returns>
        public ActionResult News(int page = 1, int sort = 0, int day = 0, string keyword = "", int pagesize = 10, int id = 0)
        {
            //int SiteID = int.Parse(Session["StoreID"].ToString());
            //string where = "";
            //if (SiteID != 0)
            //{
            //    where = "ShopMenberID=" + SiteID;
            //}
            var temp = nbll.GetModelList("").OrderByDescending(c => c.AddDateTime).ToList();
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
            ViewBag.CurrentPage = page;
            ViewBag.RowCount = temp.Count;
            return View(temp.Skip((page - 1) * pagesize).Take(pagesize).ToList());
        }
        /// <summary>
        /// 新闻添加页
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsAdd(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult NewsAdd(Maticsoft.Model.News model)
        {
            try
            {
                model.EditDateTime = model.AddDateTime;
                nbll.Add(model);
                //HuaXuCommon.AddRz(User.Identity.Name, "添加了新文章,标题:" + model.Title);
                return RedirectToAction("NewsAdd", new { IsSuccess = true });
            }
            catch
            {
                return RedirectToAction("NewsAdd", new { IsSuccess = false });
            }
        }
        /// <summary>
        /// 新闻修改页
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsEdit(int id, bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(nbll.GetModel(id));
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult NewsEdit(Maticsoft.Model.News model)
        {
            var target = nbll.GetModel(model.ID);
            target.Title = model.Title;
            target.SortID = model.SortID;
            target.Author = model.Author;
            target.VideoURL = model.VideoURL;
            target.PicURL = model.PicURL;
            target.Content = model.Content;
            target.KeyWord = model.KeyWord;
            target.Description = model.Description;
            target.FromWhere = model.FromWhere;
            target.IsTJ = model.IsTJ;
            target.IsTop = model.IsTop;
            target.IsHot = model.IsHot;
            target.ReadCount = model.ReadCount;
            target.VideoURL = model.VideoURL;
            target.EditDateTime = DateTime.Now;
            nbll.Update(target);
            return RedirectToAction("NewsEdit", new { IsSuccess = true });
        }
        /// <summary>
        /// 新闻删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult NewsDel(int ID)
        {
            nbll.Delete(ID);
            return RedirectToAction("News");
        }

        /// <summary>
        /// 新闻分类页
        /// </summary>
        /// <returns></returns>
        public ActionResult NewsSort(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            var list = sbll.GetModelList("");
            return View(list);
        }
        /// <summary>
        /// 新闻分类添加
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsSortAdd(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        [HttpPost]
        public ActionResult NewsSortAdd(Maticsoft.Model.SortType model)
        {
            try
            {
                var result = sbll.Add(model);
                return RedirectToAction("NewsSortAdd", new ResultCode { IsSuccess = true, Msg = "留言提交成功", Code = 200 });
            }
            catch (Exception ex)
            {
                return RedirectToAction("NewsSortAdd", new ResultCode { IsSuccess = false, Msg = "留言提交出现错误:" + ex, Code = 200 });
            }
        }
        /// <summary>
        /// 新闻分类删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult NewsSortDel(int ID)
        {
            var del = sbll.Delete(ID);
            return RedirectToAction("NewsSort");
        }
        /// <summary>
        /// 新闻分类修改
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult NewsSortEdit(int id, bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(sbll.GetModel(id));
        }
        [HttpPost]
        public ActionResult NewsSortEdit(Maticsoft.Model.SortType model)
        {
            var target = sbll.GetModel(model.ID);
            target.Name = model.Name;
            sbll.Update(target);
            return RedirectToAction("NewsSort", new { IsSuccess = true });
        }
        /// <summary>
        /// 新闻锁定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult NewsSd(int id)
        {
            //suoping2.AddRz(User.Identity.Name, "锁定资讯ID" + id);
            var m = nbll.GetModel(id);
            m.IsLock = m.IsLock ? false : true;
            nbll.Update(m);
            return Json(new { IsSuccess = true }, JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 新闻分类锁定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult NewsSortSd(int id)
        {
            //suoping2.AddRz(User.Identity.Name, "锁定资讯ID" + id);
            var l = sbll.GetModel(id);
            l.IsLock = l.IsLock ? false : true;
            sbll.Update(l);
            return Json(new { IsSuccess = true }, JsonRequestBehavior.AllowGet);
        }
        #endregion

        #region 产品模块
        /// <summary>
        /// 后台产品首页
        /// </summary>
        /// <param name="page"></param>
        /// <param name="sort"></param>
        /// <param name="day"></param>
        /// <param name="keyword"></param>
        /// <param name="pagesize"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult Product(int page = 1, int sort = 0, int day = 0, string keyword = "", int pagesize = 10, int id = 0)
        {
            //int SiteID = int.Parse(Session["StoreID"].ToString());
            //string where = "";
            //if (SiteID != 0)
            //{
            //    where = "ShopMenberID=" + SiteID;
            //}
            var temp = pbll.GetModelList("").OrderByDescending(c => c.AddDateTime).ToList();
            //var temp = new List<Maticsoft.Model.News>();
            if (keyword != "")
            {
                temp = temp.Where(c => c.Title.Contains(keyword) || c.Info.Contains(keyword)).ToList();
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
            ViewBag.CurrentPage = page;
            ViewBag.RowCount = temp.Count;
            return View(temp.Skip((page - 1) * pagesize).Take(pagesize).ToList());
        }
        /// <summary>
        /// 产品添加
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult ProAdd(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View();
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProAdd(Maticsoft.Model.Product model)
        {
            try
            {
                pbll.Add(model);
                //HuaXuCommon.AddRz(User.Identity.Name, "添加了新文章,标题:" + model.Title);
                return RedirectToAction("ProAdd", new { IsSuccess = true });
            }
            catch
            {
                return RedirectToAction("ProAdd", new { IsSuccess = false });
            }
        }
        /// <summary>
        /// 产品修改页
        /// </summary>
        /// <param name="id"></param>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult ProEdit(int id, bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(pbll.GetModel(id));
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ProEdit(Maticsoft.Model.Product model)
        {
            var target = pbll.GetModel(model.ID);
            target.Title = model.Title;
            //target.SortID = model.SortID;
            //target.VideoURL = model.VideoURL;
            target.PicURL = model.PicURL;
            target.PicURL1 = model.PicURL1;
            target.PicURL2 = model.PicURL2;
            target.PicURL3 = model.PicURL3;
            target.PicURL4 = model.PicURL4;
            target.PicURL5 = model.PicURL5;
            target.Info = model.Info;
            target.KeyWord = model.KeyWord;
            target.Description = model.Description;
            target.IsTJ = model.IsTJ;
            target.IsTop = model.IsTop;
            target.IsHot = model.IsHot;
            target.ReadCount = model.ReadCount;
            pbll.Update(target);
            return RedirectToAction("ProEdit", new { IsSuccess = true });
        }
        /// <summary>
        /// 产品删除
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public ActionResult ProDel(int ID)
        {
            pbll.Delete(ID);
            return RedirectToAction("Product");
        }

        /// <summary>
        /// 商品锁定
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public JsonResult ProSD(int id)
        {
            //suoping2.AddRz(User.Identity.Name, "锁定资讯ID" + id);
            var m = pbll.GetModel(id);
            m.IsLock = m.IsLock ? false : true;
            pbll.Update(m);
            return Json(new { IsSuccess = true }, JsonRequestBehavior.AllowGet);
        }
        #endregion


        #region 前台其他页面

        /// <summary>
        /// 关于我们
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult AboutEdit(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(abll.GetModel(1));
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult AboutEdit(Maticsoft.Model.About model)
        {
            var target = abll.GetModel(1);
            target.PicURL = model.PicURL;
            target.Description = model.Description;
            target.JDtxt10 = model.JDtxt10;
            target.JDtxt9 = model.JDtxt9;
            target.JDtxt8 = model.JDtxt8;
            target.JDtxt7 = model.JDtxt7;
            target.PicURL13 = model.PicURL13; //标题字段不够用，顶替title6
            target.Title7 = model.Title7;
            target.Title5 = model.Title5;
            target.Title4 = model.Title4;
            target.PicURL12 = model.PicURL12;
            target.PicURL11 = model.PicURL11;
            target.PicURL10 = model.PicURL10;
            target.PicURL9 = model.PicURL9;
            target.PicURL8 = model.PicURL8;
            abll.Update(target);
            return RedirectToAction("AboutEdit", new { IsSuccess = true });
        }
        /// <summary>
        /// 基地展示（首页）
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult JiDiEdit(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(abll.GetModel(1));
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult JiDiEdit(Maticsoft.Model.About model)
        {
            var target = abll.GetModel(1);
            target.PicURL1 = model.PicURL1;
            target.PicURL2 = model.PicURL2;
            target.PicURL3 = model.PicURL3;
            target.PicURL4 = model.PicURL4; //首页3背景图
            target.PicURL5 = model.PicURL5; //首页2背景图
            target.JDtxt1 = model.JDtxt1;
            target.JDtxt2 = model.JDtxt2;
            target.JDtxt3 = model.JDtxt3;
            target.Title1 = model.Title1;
            target.Title2 = model.Title2;
            target.Title3 = model.Title3;
            abll.Update(target);
            return RedirectToAction("JiDiEdit", new { IsSuccess = true });
        }
        /// <summary>
        /// 资质荣誉
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        //public ActionResult HonorEdit(bool IsSuccess = false)
        //{
        //    ViewBag.IsSuccess = IsSuccess;
        //    return View(abll.GetModel(1));
        //}
        //[HttpPost]
        //[ValidateInput(false)]
        //public ActionResult HonorEdit(Maticsoft.Model.About model)
        //{
        //    var target = abll.GetModel(1);
        //    target.PicURL6 = model.PicURL6;
        //    target.PicURL7 = model.PicURL7;
        //    target.PicURL8 = model.PicURL8;
        //    target.PicURL9 = model.PicURL9;
        //    abll.Update(target);
        //    return RedirectToAction("HonorEdit", new { IsSuccess = true });
        //}
        /// <summary>
        /// 联系我们
        /// </summary>
        /// <param name="IsSuccess"></param>
        /// <returns></returns>
        public ActionResult ContactEdit(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(abll.GetModel(1));
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult ContactEdit(Maticsoft.Model.About model)
        {
            var target = abll.GetModel(1);
            target.WAdress = model.WAdress;
            target.Adress = model.Adress;
            target.Phone = model.Phone;
            target.CPhone = model.CPhone;
            target.PostNum = model.PostNum;
            target.APicURL = model.APicURL;
            target.avg3 = model.avg3; //手机号
            target.avg4 = model.avg4;  //邮箱
            abll.Update(target);
            return RedirectToAction("ContactEdit", new { IsSuccess = true });
        }
        #endregion

        #region 个人中心

        public ActionResult Self(bool IsSuccess = false)
        {
            ViewBag.IsSuccess = IsSuccess;
            return View(lbll.GetModel(1));
        }
        [HttpPost]
        public ActionResult Self(Maticsoft.Model.Login model)
        {
            var target = lbll.GetModel(1);
            if(model.avg2 == target.LPwd)
            {
                target.LPwd = model.LPwd;
                lbll.Update(target);
                return RedirectToAction("Self", new { IsSuccess = true });
            }
            else
            {
                return RedirectToAction("Self", new { IsSuccess = false });
            }
        }
        #endregion

        #region 在线回复

        public ActionResult GMile()
        {
            return View();
        }
        
        #endregion
    }
}