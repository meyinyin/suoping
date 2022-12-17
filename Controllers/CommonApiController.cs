using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Configuration;
using System.Security.Cryptography;
using System.Configuration;
using System.Text;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using suoping2;

namespace suoping2.Controllers.api
{
    public class CommonApi : ApiController
    {
        

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name = "s" > 是否生成缩略图 1：生成缩略图</param>
        /// <param name = "w" > 生成缩略图的宽度 </ param >
        /// < param name="h">生成缩略图的高度</param>
        /// <param name = "m" > 生成缩略图的方式 HW：指定高宽缩放（补白）W：指定宽，高按比例 H:指定高，宽按比例 Cut:指定高宽裁减（不变形） </param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/news/upload")]
        public async Task<ReturnStateModel<string>> upload()
        {
            string s = HttpContext.Current.Request["s"];
            string w = HttpContext.Current.Request["w"];
            string h = HttpContext.Current.Request["h"];
            string m = HttpContext.Current.Request["m"];
            if (!Request.Content.IsMimeMultipartContent())
            {
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
            }
            //上传到服务器的地址
            string uploadFolderPath = System.Web.Hosting.HostingEnvironment.MapPath("~/uploadshop");

            //如果路径不存在，创建路径
            if (!Directory.Exists(uploadFolderPath))
                Directory.CreateDirectory(uploadFolderPath);

            List<string> files = new List<string>();
            List<string> sfiles = new List<string>();
            var provider = new WithExtensionMultipartFormDataStreamProvider(uploadFolderPath);
            try
            {
                // Read the form data.
                await Request.Content.ReadAsMultipartAsync(provider);

                // This illustrates how to get the file names.

                foreach (var file in provider.FileData)
                {//接收文件
                    files.Add(Path.GetFileName(file.LocalFileName));
                }
                if (s != null && s != string.Empty)
                {
                    int width = 120, height = 120;
                    string mode = "W";
                    if (w != null && w != string.Empty)
                        width = Convert.ToInt32(w);
                    if (h != null && h != string.Empty)
                        height = Convert.ToInt32(h);
                    if (m != null && m != string.Empty)
                        mode = m.ToUpper();
                    foreach (var name in files)
                    {
                        UpLoadController.MakeThumbnailImage(uploadFolderPath + "/" + name, uploadFolderPath + "/s_" + name, width, height, mode);
                        sfiles.Add("s_" + name);
                    }
                }
            }
            catch
            {
                return new ReturnStateModel<string> { IsSuccess = false, Msg = "上传图片失败！", Data = "" };
            }
            if (s != null && s != string.Empty)
            {
                return new ReturnStateModel<string> { IsSuccess = true, Msg = "上传图片成功！", Data = string.Join(",", sfiles) };
            }
            else
            {
                return new ReturnStateModel<string> { IsSuccess = true, Msg = "上传图片成功！", Data = string.Join(",", files) };
            }
        }
    }
}
