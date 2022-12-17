using suoping2;
using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Hosting;
using System.Web.Http;

namespace suoping2.Controllers.api
{
    public class FileResult
    {
        public string FileNames { get; set; }
        public string Description { get; set; }
        public DateTime CreatedTimestamp { get; set; }
        public DateTime UpdatedTimestamp { get; set; }
        public string FileLength { get; set; }
        public string ContentTypes { get; set; }
        public string OriginalNames { get; set; }
        public string Status { get; set; }

        public string Msg { get; set; }
    }


    public class WithExtensionMultipartFormDataStreamProvider : MultipartFormDataStreamProvider
    {
        public WithExtensionMultipartFormDataStreamProvider(string rootPath)
            : base(rootPath)
        {

        }
        public override string GetLocalFileName(System.Net.Http.Headers.HttpContentHeaders headers)
        {
            string extension = !string.IsNullOrWhiteSpace(headers.ContentDisposition.FileName) ? Path.GetExtension(GetValidFileName(headers.ContentDisposition.FileName)) : "";
            return Guid.NewGuid().ToString().Replace("-", "_") + extension;
        }

        private string GetValidFileName(string filePath)
        {
            char[] invalids = System.IO.Path.GetInvalidFileNameChars();
            return String.Join("_", filePath.Split(invalids, StringSplitOptions.RemoveEmptyEntries)).TrimEnd('.');
        }
    }

    public class UpLoadController : ApiController
    {
        private const string UploadFolder = "uploads";

        [HttpPost]
        public Task<IQueryable<FileResult>> UpLoadFile()
        {
            try
            {
                string uploadFolderPath = HostingEnvironment.MapPath("~/" + UploadFolder);

                //如果路径不存在，创建路径
                if (!Directory.Exists(uploadFolderPath))
                    Directory.CreateDirectory(uploadFolderPath);
                if (Request.Content.IsMimeMultipartContent())
                {
                    var streamProvider = new WithExtensionMultipartFormDataStreamProvider(uploadFolderPath);
                    var task = Request.Content.ReadAsMultipartAsync(streamProvider).ContinueWith<IQueryable<FileResult>>(t =>
                    {
                        if (t.IsFaulted || t.IsCanceled)
                        {
                            throw new HttpResponseException(HttpStatusCode.InternalServerError);
                        }
                        var fileInfo = streamProvider.FileData.Select(i =>
                        {
                            var info = new FileInfo(i.LocalFileName);
                            return new FileResult()
                            {
                                FileNames = info.Name,
                                Description = "描述文本",
                                ContentTypes = info.Extension.ToString(),
                                CreatedTimestamp = info.CreationTime,
                                OriginalNames = info.Name.ToString(),
                                FileLength = info.Length.ToString()
                            };
                        });
                        return fileInfo.AsQueryable();
                    });

                    return task;
                }
                else
                {
                    throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.NotAcceptable, "This request is not properly formatted"));
                }
            }
            catch (Exception ex)
            {
                throw new HttpResponseException(Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message));
            }
        }

        [HttpGet]
        public HttpResponseMessage DownloadFile(string fileName)
        {
            HttpResponseMessage result = null;

            DirectoryInfo directoryInfo = new DirectoryInfo(HostingEnvironment.MapPath("~/" + UploadFolder));
            FileInfo foundFileInfo = directoryInfo.GetFiles().Where(x => x.Name == fileName).FirstOrDefault();
            if (foundFileInfo != null)
            {
                FileStream fs = new FileStream(foundFileInfo.FullName, FileMode.Open);

                result = new HttpResponseMessage(HttpStatusCode.OK);
                result.Content = new StreamContent(fs);
                result.Content.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");
                result.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
                result.Content.Headers.ContentDisposition.FileName = foundFileInfo.Name;
            }
            else
            {
                result = new HttpResponseMessage(HttpStatusCode.NotFound);
            }

            return result;
        }

        private HttpResponseMessage ConvertImage(string Filename)
        {
            try
            {
                string NewFilename = Filename.Substring(0, Filename.LastIndexOf('.')) + ".png";
                string surl = HttpContext.Current.Server.MapPath("/UploadShop/" + Filename);
                string turl = HttpContext.Current.Server.MapPath("/UploadShop/" + NewFilename);
                if (System.IO.File.Exists(turl))
                    return ResultToJson.toJson(new { IsSuccess = true, Msg = "已经存在Png图片", Data = NewFilename });
                MakeThumbnailImage(surl, turl, 360, 120);
                return ResultToJson.toJson(new { IsSuccess = true, Msg = "转换成功，生成" + NewFilename + "，如下所示。", Data = NewFilename });
            }
            catch (Exception ex)
            {
                return ResultToJson.toJson(new { IsSuccess = false, Msg = ex.Message });
            }
        }

        //[HttpGet]
        //public IHttpActionResult GetFileFromWebApi(int newsid, int picid = 0)
        //{
        //    var browser = String.Empty;
        //    if (HttpContext.Current.Request.UserAgent != null)
        //    {
        //        browser = HttpContext.Current.Request.UserAgent.ToUpper();
        //    }
        //    string filename = "";
        //    Maticsoft.BLL.News nbll = new Maticsoft.BLL.News();
        //    Maticsoft.BLL.Pics pbll = new Maticsoft.BLL.Pics();
        //    if (picid == 0)
        //    {
        //        filename = nbll.GetModel(newsid).PicURL;
        //        if (filename.Trim() == "" || filename == string.Empty)
        //        {
        //            filename = pbll.GetModelList("NewsID=" + newsid).FirstOrDefault().PicUrl;
        //        }
        //    }
        //    else
        //    {
        //        filename = pbll.GetModel(picid).PicUrl;
        //    }
        //    filename = ConvertImage(filename).Data;
        //    string filePath = HttpContext.Current.Server.MapPath("/UploadShop/" + filename);
        //    HttpResponseMessage httpResponseMessage = new HttpResponseMessage(HttpStatusCode.OK);
        //    FileStream fileStream = File.OpenRead(filePath);
        //    httpResponseMessage.Content = new StreamContent(fileStream);
        //    httpResponseMessage.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
        //    httpResponseMessage.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment")
        //    {
        //        FileName =
        //            browser.Contains("FIREFOX")
        //                ? Path.GetFileName(filePath)
        //                : HttpUtility.UrlEncode(Path.GetFileName(filePath))
        //    };
        //    return ResponseMessage(httpResponseMessage);
        //}

        /// <summary>  
        /// 压缩文件下载  
        /// </summary>  
        /// <param name="fileIds">文件编号</param>  
        /// <returns></returns>  
        //[HttpGet]
        //public HttpResponseMessage DownLoad(string fileIds)
        //{
        //    string customFileName = DateTime.Now.ToString("yyyyMMddHHmmss") + ".zip";//客户端保存的文件名
        //    string path = HostingEnvironment.MapPath("~/" + UploadFolder + "/");
        //    HttpResponseMessage response = new HttpResponseMessage();
        //    try
        //    {
        //        string[] filenames = { "4c301d70-a681-46bd-88c1-97a133ee4b79.png", "4648cac5-d15f-45f2-9b06-7a2eebf5c604.jpg" };
        //        using (ZipOutputStream s = new ZipOutputStream(File.Create(path + "/" + customFileName)))
        //        {
        //            s.SetLevel(9);
        //            byte[] buffer = new byte[4096];

        //            foreach (string file in filenames)
        //            {
        //                var entry = new ZipEntry(Path.GetFileName(path + "/" + file));
        //                entry.DateTime = DateTime.Now;
        //                s.PutNextEntry(entry);
        //                using (FileStream fs = File.OpenRead(path + "/" + file))
        //                {
        //                    int sourceBytes;
        //                    do
        //                    {
        //                        sourceBytes = fs.Read(buffer, 0, buffer.Length);
        //                        s.Write(buffer, 0, sourceBytes);
        //                    } while (sourceBytes > 0);
        //                }
        //            }
        //            s.Finish();
        //            s.Close();
        //        }
        //        FileStream fileStream = new FileStream(path + "/" + customFileName, FileMode.Open, FileAccess.Read, FileShare.Read);
        //        response.Content = new StreamContent(fileStream);
        //        response.Content.Headers.ContentDisposition = new ContentDispositionHeaderValue("attachment");
        //        response.Content.Headers.ContentDisposition.FileName = customFileName;
        //        response.Content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");  // 这句话要告诉浏览器要下载文件  
        //        response.Content.Headers.ContentLength = new FileInfo(path + "/" + customFileName).Length;
        //    }
        //    catch (Exception ex)
        //    {

        //    }
        //    return response;
        //}

        /// <summary>
        /// 图片上传  [FromBody]string token
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public Task<IQueryable<Hashtable>> ImgUpload()
        {
            string status = "0";
            string msg = "";
            const int maxSize = 10000000;
            const string fileTypes = "gif,jpg,jpeg,png,bmp";
            bool isthumb = true;//是否生成缩略图
            string PrefixThumbnail = "thumb_"; //随机生成缩略图文件名前缀
            string daypath = DateTime.Now.ToString("yyyyMMdd");

            // 检查是否是 multipart/form-data 
            if (!Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            // 文件保存目录路径 
            string uploadFolderPath = HostingEnvironment.MapPath("~/" + UploadFolder + "/" + daypath);
            //检查上传的物理路径是否存在，不存在则创建
            if (!Directory.Exists(uploadFolderPath))
            {
                Directory.CreateDirectory(uploadFolderPath);
            }
            var streamProvider = new WithExtensionMultipartFormDataStreamProvider(uploadFolderPath);
            //var streamProvider =  new MultipartFormDataStreamProvider(uploadFolderPath);

            var task = Request.Content.ReadAsMultipartAsync(streamProvider).ContinueWith<IQueryable<Hashtable>>(t =>
            {

                if (t.IsFaulted || t.IsCanceled)
                {
                    throw new HttpResponseException(HttpStatusCode.InternalServerError);
                }

                var fileInfo = streamProvider.FileData.Select(i =>
                {

                    var info = new FileInfo(i.LocalFileName);

                    //原始上传名称
                    //LogHelper.writeLog(i.Headers.ContentDisposition.FileName);
                    string orfilename = GetOrginFileName(i.Headers.ContentDisposition.FileName);

                    if (info.Length <= 0)
                    {
                        status = "0";
                        msg = "请选择上传文件";
                    }
                    else if (info.Length > maxSize)
                    {
                        status = "0";
                        msg = "上传文件大小超过限制";
                    }
                    else
                    {
                        var fileExt = info.Extension.ToString();
                        if (String.IsNullOrEmpty(fileExt) ||
                            Array.IndexOf(fileTypes.Split(','), fileExt.Substring(1).ToLower()) == -1)
                        {
                            status = "0";
                            msg = "不支持上传文件类型";
                        }
                        else
                        {
                            status = "1";
                            msg = "上传成功";
                            //生成缩略图
                            if (isthumb)
                            {
                                MakeThumbnailImage(uploadFolderPath + "/" + info.Name, uploadFolderPath + "/" + PrefixThumbnail + info.Name, 300, 300, "Cut");
                            }
                        }
                    }
                    Hashtable hs = new Hashtable();
                    hs["status"] = status;
                    hs["msg"] = msg;
                    hs["filename"] = "/" + UploadFolder + "/" + daypath + "/" + info.Name;
                    hs["orginname"] = orfilename;
                    return hs;
                });
                return fileInfo.AsQueryable();
            });

            return task;
        }

        private string GetOrginFileName(string filePath)
        {
            string result = "";
            try
            {
                var filename = Regex.Match(filePath, @"[^\\]+$");
                result = filename.ToString().Replace("\"", "");
            }
            catch (Exception)
            { }
            return result;
        }

        /// <summary>
        /// 生成缩略图
        /// </summary>
        /// <param name="fileName">源图路径（绝对路径）</param>
        /// <param name="newFileName">缩略图路径（绝对路径）</param>
        /// <param name="width">缩略图宽度</param>
        /// <param name="height">缩略图高度</param>
        /// <param name="mode">生成缩略图的方式</param>    
        public static void MakeThumbnailImage(string fileName, string newFileName, int width, int height, string mode = "W")
        {
            Image originalImage = Image.FromFile(fileName);
            int towidth = width;
            int toheight = height;

            int x = 0;
            int y = 0;
            int ow = originalImage.Width;
            int oh = originalImage.Height;

            switch (mode)
            {
                case "HW"://指定高宽缩放（补白）
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    else
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    break;
                case "W"://指定宽，高按比例                    
                    toheight = originalImage.Height * width / originalImage.Width;
                    break;
                case "H"://指定高，宽按比例
                    towidth = originalImage.Width * height / originalImage.Height;
                    break;
                case "Cut"://指定高宽裁减（不变形）                
                    if ((double)originalImage.Width / (double)originalImage.Height > (double)towidth / (double)toheight)
                    {
                        oh = originalImage.Height;
                        ow = originalImage.Height * towidth / toheight;
                        y = 0;
                        x = (originalImage.Width - ow) / 2;
                    }
                    else
                    {
                        ow = originalImage.Width;
                        oh = originalImage.Width * height / towidth;
                        x = 0;
                        y = (originalImage.Height - oh) / 2;
                    }
                    break;
                default:
                    break;
            }

            //新建一个bmp图片
            Bitmap b = new Bitmap(towidth, toheight);
            try
            {
                //新建一个画板
                Graphics g = Graphics.FromImage(b);
                //设置高质量插值法
                g.InterpolationMode = InterpolationMode.HighQualityBicubic;
                //设置高质量,低速度呈现平滑程度
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.PixelOffsetMode = PixelOffsetMode.HighQuality;
                //清空画布并以透明背景色填充
                g.Clear(Color.White);
                //g.Clear(Color.Transparent);
                //在指定位置并且按指定大小绘制原图片的指定部分
                g.DrawImage(originalImage, new Rectangle(0, 0, towidth, toheight), new Rectangle(x, y, ow, oh), GraphicsUnit.Pixel);

                SaveImage(b, newFileName, GetCodecInfo("image/" + GetFormat(newFileName).ToString().ToLower()));
            }
            catch (System.Exception e)
            {
                throw e;
            }
            finally
            {
                originalImage.Dispose();
                b.Dispose();
            }
        }

        /// <summary>
        /// 保存图片
        /// </summary>
        /// <param name="image">Image 对象</param>
        /// <param name="savePath">保存路径</param>
        /// <param name="ici">指定格式的编解码参数</param>
        private static void SaveImage(Image image, string savePath, ImageCodecInfo ici)
        {
            //设置 原图片 对象的 EncoderParameters 对象
            EncoderParameters parameters = new EncoderParameters(1);
            parameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, ((long)100));
            image.Save(savePath, ici, parameters);
            parameters.Dispose();
        }
        /// <summary>
        /// 获取图像编码解码器的所有相关信息
        /// </summary>
        /// <param name="mimeType">包含编码解码器的多用途网际邮件扩充协议 (MIME) 类型的字符串</param>
        /// <returns>返回图像编码解码器的所有相关信息</returns>
        private static ImageCodecInfo GetCodecInfo(string mimeType)
        {
            ImageCodecInfo[] CodecInfo = ImageCodecInfo.GetImageEncoders();
            foreach (ImageCodecInfo ici in CodecInfo)
            {
                if (ici.MimeType == mimeType)
                    return ici;
            }
            return null;
        }

        /// <summary>
        /// 得到图片格式
        /// </summary>
        /// <param name="name">文件名称</param>
        /// <returns></returns>
        public static ImageFormat GetFormat(string name)
        {
            string ext = name.Substring(name.LastIndexOf(".") + 1);
            switch (ext.ToLower())
            {
                case "jpg":
                case "jpeg":
                    return ImageFormat.Jpeg;
                case "bmp":
                    return ImageFormat.Bmp;
                case "png":
                    return ImageFormat.Png;
                case "gif":
                    return ImageFormat.Gif;
                default:
                    return ImageFormat.Jpeg;
            }
        }
    }
}