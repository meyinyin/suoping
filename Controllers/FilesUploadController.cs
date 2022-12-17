//using Qiniu.Http;
//using Qiniu.Storage;
//using Qiniu.Util;
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.IO;
//using System.Linq;
//using System.Net;
//using System.Web;
//using System.Web.Mvc;

//namespace HuaXuApplication.Controllers
//{
//    public class FilesUploadController : Controller
//    {
//        private static string AccessKey = "AyFR_dGWvkCx3p6325U4LypDt6083shF55ei78pK";
//        private static string SecretKey = "SX_Jpfe0JDFmA-Uyx615TxxLPyBd-kWgUemc6gS2";
//        public static string Bucket = "kanguo-upoload";
//        public static string UrlPrefix { get; set; }
//        /// <summary>
//        /// 上传文件
//        /// </summary>
//        /// <param name="name"></param>
//        /// <param name="path"></param>
//        /// <returns></returns>
//        public static string Upload(string localFile, string saveKey)
//        {
//            Mac mac = new Mac(AccessKey, SecretKey);
//            // 上传文件名
//            string key = localFile;
//            // 本地文件路径
//            string filePath = saveKey;
//            // 存储空间名
//            string Bucket = "kanguo-upoload";
//            // 设置上传策略，详见：https://developer.qiniu.com/kodo/manual/1206/put-policy
//            PutPolicy putPolicy = new PutPolicy();
//            // 设置要上传的目标空间
//            putPolicy.Scope = Bucket;
//            // 上传策略的过期时间(单位:秒)
//            putPolicy.SetExpires(3600);
//            // 文件上传完毕后，在多少天后自动被删除
//            //putPolicy.DeleteAfterDays = 1;
//            // 生成上传token
//            string token = Auth.CreateUploadToken(mac, putPolicy.ToJsonString());
//            Config config = new Config();
//            // 设置上传区域
//            config.Zone = Zone.ZONE_CN_East;
//            // 设置 http 或者 https 上传
//            config.UseHttps = true;
//            config.UseCdnDomains = true;
//            config.ChunkSize = ChunkUnit.U512K;
//            // 表单上传
//            FormUploader target = new FormUploader(config);
//            HttpResult result = target.UploadFile(localFile, saveKey, token, null);
//            //Console.WriteLine("form upload result: " + result.ToString());
//            if (result.Code != 200)
//            {
//                throw new Exception(result.RefText);
//            }
//            return result.ToString();
//        }
//        /// 直接上传可用于数据较小的文件  图片
//        /// <param name="upLoadFile">上传地址</param>
//        /// <returns></returns>
//        public static string UpLoading(string file)
//        {
//            bool bresult = false;
//            if (file == null)
//            {
//                return "请选择文件";
//            }
//            string filePath = string.Empty;
//            string upLoadFile = string.Empty;
//            //唯一标识
//            Guid gid = Guid.NewGuid();
//            filePath = Path.Combine(file);
//            try
//            {
//                //开始上传文件(七牛云上传)
//                Mac mac = new Mac(AccessKey, SecretKey);
//                string bucket = "kanguo-upoload";
//                string fileName = System.IO.Path.GetFileName(file);
//                string saveKey = fileName;
//                string localFile = file;
//                // 上传策略，参见 
//                // https://developer.qiniu.com/kodo/manual/put-policy
//                PutPolicy putPolicy = new PutPolicy();
//                // 如果需要设置为"覆盖"上传(如果云端已有同名文件则覆盖)，请使用 SCOPE = "BUCKET:KEY"
//                // putPolicy.Scope = bucket + ":" + saveKey;
//                putPolicy.Scope = bucket;
//                // 上传策略有效期(对应于生成的凭证的有效期)          
//                putPolicy.SetExpires(3600);
//                // 上传到云端多少天后自动删除该文件，如果不设置（即保持默认默认）则不删除
//                //putPolicy.DeleteAfterDays = 1;
//                putPolicy.ReturnBody = "{\"key\":\"$(key)\"}";
//                // 生成上传凭证，参见
//                // https://developer.qiniu.com/kodo/manual/upload-token            
//                string jstr = putPolicy.ToJsonString();
//                string token = Auth.CreateUploadToken(mac, jstr);

//                Config config = new Config();
//                // 空间对应的机房
//                config.Zone = Zone.ZONE_CN_East;
//                // 是否使用https域名
//                config.UseHttps = true;
//                // 上传是否使用cdn加速
//                config.UseCdnDomains = true;

//                UploadManager um = new UploadManager(config);
//                HttpResult result1 = um.UploadFile(localFile, saveKey, token, null);

//                //数据处理
//                //var res = JsonConvert.DeserializeObject<Text>(JsonConvert.SerializeObject(result1.Text));

//                DateTime t = DateTime.Now;
//                long ss = HuaXuApplication.Help.ConvertDateTimeInt(t);
//                //上传服务器地址
//                var http = "https://img.91goodluck.com/" + saveKey + "?t=" + ss;

//                //删除本地临时图片
//                //System.IO.FileInfo DeleFile = new System.IO.FileInfo(file);
//                //if (DeleFile.Exists)
//                //{
//                //    DeleFile.Delete();
//                //}
//                return http;
//            }
//            catch (Exception ex)
//            {
//                return ex.Message;
//            }
//        }
//        public static Image DownImage(string url)
//        {
//            WebRequest wreq = WebRequest.Create(url);
//            HttpWebResponse wresp = (HttpWebResponse)wreq.GetResponse();
//            Stream s = wresp.GetResponseStream();
//            System.Drawing.Image img;
//            img = System.Drawing.Image.FromStream(s);
//            //img.Dispose();
//            return img;
//        }
//        /// <summary>
//        /// 删除文件
//        /// </summary>
//        /// <param name="saveKey"></param>
//        public static void DeleteFile(string saveKey)
//        {
//            Mac mac = new Mac(AccessKey, SecretKey);

//            Config config = new Config();
//            // 设置上传区域
//            config.Zone = Zone.ZONE_CN_East;
//            // 设置 http 或者 https 上传
//            config.UseHttps = true;
//            config.UseCdnDomains = true;
//            config.ChunkSize = ChunkUnit.U512K;

//            BucketManager bm = new BucketManager(mac, config);

//            bm.Delete(Bucket, saveKey);
//        }
//    }
//}
