using suoping2;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Net.NetworkInformation;
using System.Web.Http;
namespace baohemiju.Controllers.api
{
    [AllowAnonymous]
    public class pData
    {
        public DateTime GDate { get; set; }
        public int MsgType { get; set; }
        public string GChannel { get; set; }
    }
    
    public class GMileApiController : ApiController
    {
        Maticsoft.BLL.GMile gbll = new Maticsoft.BLL.GMile();

        /// <summary>
        /// 根据客服IP获取消息列表(s端)
        /// </summary>
        /// <param name="serverip">客服IP</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/msglist")]
        public HttpResponseMessage GetMsg(string serverip)
        {
            List<Maticsoft.Model.GMile> msglist = new List<Maticsoft.Model.GMile>();
            //string where = "IP=" + fromip + "and GChannel=" + fromip;
            string where = "IP='"+ serverip + "' or GChannel='"+ serverip + "'";
            var listcount = gbll.GetModelList(where).Count();
            //var list = listt.OrderByDescending(c => c.GDate).Skip((page - 1) * pagesize).Take(pagesize).ToList();
            if (listcount >0)
            {
                var listt = gbll.GetModelList(where);
                var list = listt.OrderByDescending(c => c.GDate).ToList();
                return suoping2.ResultToJson.toJson(new { IsSuccess = true, Data = list });
            }
            return suoping2.ResultToJson.toJson(new { IsSuccess = false});
        }
        /// <summary>
        /// 获取所有消息列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/getallmsg")]
        public HttpResponseMessage GetAllMsg()
        {
            var listt = gbll.GetModelList("").Count();
            if(listt > 0)
            {
                var list = gbll.GetModelList("").OrderByDescending(c => c.GDate).ToList();
                return suoping2.ResultToJson.toJson(new { IsSuccess = true, Data = list });
            }
            else
            {
                return suoping2.ResultToJson.toJson(new { IsSuccess = false ,Msg = "消息列表为空!"});
            }

        }

        /// <summary>
        /// 获取联系人列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/getmsg")]
        public HttpResponseMessage GetMsg()
        {
            string where = "GState=" + 0;
            var listt = gbll.GetModelList(where).Count();

            List<Maticsoft.Model.GMile> userlist = new List<Maticsoft.Model.GMile>();
            if (listt > 0)
            {
                var list = gbll.GetModelList(where).OrderByDescending(c => c.GDate).Distinct(c => c.IP, StringComparer.CurrentCultureIgnoreCase).ToList();
                //#region 单独计算第一个
                //if (list[0].IP != list[1].IP)
                //{
                //    userlist.Add(list[0]);
                //}
                //#endregion
                //foreach(var m in list)
                //{
                    
                //}
                //for (int i = 1; i < listt; i++)
                //{
                //    if (list[i].IP != list[i - 1].IP)
                //    {
                //        userlist.Add(list[i]);
                //    }
                //}
                return suoping2.ResultToJson.toJson(new { IsSuccess = true, Data = list });
            }
            else
            {
                return suoping2.ResultToJson.toJson(new { IsSuccess = false, Msg = "消息列表为空!" });
            }

        }
        /// <summary>
        /// 未读消息数目
        /// </summary>
        /// <param name="serverip">客服ip</param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/msgwd")]
        public HttpResponseMessage GetMsgwd(string serverip)
        {
            //string where = "GChannel=" + toip + "and MsgType=0";
            string where = "GChannel='" + serverip + "'and MsgType=0";
            var list = gbll.GetModelList(where).Count();
            return suoping2.ResultToJson.toJson(new { IsSuccess = true, Data = list });
        }
        /// <summary>
        /// 阅读消息
        /// </summary>
        /// <param name="serverip"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/msgread")]
        public HttpResponseMessage GetMsgRead(string serverip)
        {
            string where = "GChannel='" + serverip + "'";
            var list = gbll.GetModelList(where);
            //更新消息状态
            foreach (var s in list)
            {
                s.MsgType = 1;
                gbll.Update(s);
            }
            return suoping2.ResultToJson.toJson(new { IsSuccess = true, Data = list });
        }
        /// <summary>
        /// 阅读消息(c端)
        /// </summary>
        /// <param name="userip"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/msgreadc")]
        public HttpResponseMessage GetMsgReadc(string userip)
        {
            string where = "IP='" + userip + "'";
            var list = gbll.GetModelList(where);
            //更新消息状态
            foreach (var s in list)
            {
                s.MsgType = 1;
                gbll.Update(s);
            }
            return suoping2.ResultToJson.toJson(new { IsSuccess = true, Data = list });
        }
        /// <summary>
        /// 新增一条消息记录
        /// </summary>
        /// <param name="userip">用户ip</param>
        /// <param name="serverip">客服ip</param>
        /// <param name="content"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/addmsg")]
        public HttpResponseMessage AddMsg(string userip, string serverip, string content,bool isserver)
        {
            
            gbll.Add(new Maticsoft.Model.GMile
            {
                GDate = DateTime.Now,
                GContent = content,
                MsgType = 0,
                GChannel = serverip,
                IP = userip,
                GState = isserver
            });
            return suoping2.ResultToJson.toJson(new { IsSuccess = true,msg = "新增消息成功!"});
        }
        
        /// <summary>
        /// 删除一条记录
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/msgdel")]
        public HttpResponseMessage GetMsgDel(int id)
        {
            gbll.Delete(id);
            return suoping2.ResultToJson.toJson(new { IsSuccess = true });
        }
        /// <summary>
        /// 获取mac地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/getmac")]
        public HttpResponseMessage GetMac()  
        {
            //先获取MAC地址，
            string macAddress = "";
            using (ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration"))
            {
                ManagementObjectCollection moc2 = mc.GetInstances();
                foreach (ManagementObject mo in moc2)
                {
                    if ((bool)mo["IPEnabled"] == true)
                        macAddress = mo["MacAddress"].ToString();
                    mo.Dispose();
                }
            }
            //如果没有MAC获取IP地址
            if (macAddress == "" || macAddress == null)
            {
                foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                {
                    if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                    {
                        macAddress = _IPAddress.ToString();
                    }
                }
            }
            return suoping2.ResultToJson.toJson(new { IsSuccess = true ,Data = macAddress});
        }

        /// <summary>
        /// 获取新的mac地址
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/gmile/getnewmac")]
        public HttpResponseMessage GetNewMac()
        {
            //先获取MAC地址，
            string macAddress = "";

            //List<string> macAddress = new List<string>();

            //    ProcessStartInfo startInfo = new ProcessStartInfo("ipconfig", "/all");
            //    startInfo.UseShellExecute = false;
            //    startInfo.RedirectStandardInput = true;
            //    startInfo.RedirectStandardOutput = true;
            //    startInfo.RedirectStandardError = true;
            //    startInfo.CreateNoWindow = true;
            //    Process p = Process.Start(startInfo);   //截取输出流   
            //    StreamReader reader = p.StandardOutput;
            //    string line = reader.ReadLine();
            //    while (!reader.EndOfStream)
            //    {
            //        if (!string.IsNullOrEmpty(line))
            //        {
            //            line = line.Trim();
            //            if (line.StartsWith("物理地址"))
            //            {
            //                macAddress.Add(line.Substring(line.IndexOf(':') + 1));
            //            }
            //        }
            //        line = reader.ReadLine();
            //    }
            //    //等待程序执行完退出进程   
            //    p.WaitForExit();
            //    p.Close();
            //    reader.Close();
            //return macAddress;


            //return macAddresses.Replace(":", "-");
            //return suoping2.ResultToJson.toJson(new { IsSuccess = true, Data = macAddresses.Replace(":", "-") });
            //如果没有MAC获取IP地址
            //if (macAddress == "" || macAddress == null)
            {
                foreach (IPAddress _IPAddress in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
                {
                    if (_IPAddress.AddressFamily.ToString() == "InterNetwork")
                    {
                        macAddress = _IPAddress.ToString();
                    }
                }
            }
                return suoping2.ResultToJson.toJson(new { IsSuccess = true, Data = macAddress });
        }
    }
}
