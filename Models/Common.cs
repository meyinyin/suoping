using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

namespace suoping2
{
    public class ResultCode
    {
        public bool IsSuccess { get; set; }

        public int Code { get; set; }

        public string Msg { get; set; }
    }
    
    public class ResultToJson
    {
        public static HttpResponseMessage toJson(Object obj)
        {
            String str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                str = serializer.Serialize(obj);
            }
            HttpResponseMessage result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }
    }
    /// <summary>
    /// 公共类
    /// </summary>
    public static class suoping2
    {
        //public static void AddRz(string username, string info)
        //{
        //    Maticsoft.BLL.AdminUser rzbll = new Maticsoft.BLL.AdminUser();
        //    rzbll.Add(new Maticsoft.Model.AdminUser
        //    {
        //        AdminUserName = username,
        //        AdminLoginName = info,
        //        PWD = DateTime.Now.ToLongDateString()
        //    });
        //}
    }
    public class ReturnStateModel<T>
    {
        public bool IsSuccess { get; set; }
        public string Msg { get; set; }

        public T Data { get; set; }
    }

    #region 数组去重
    public class CommonEqualityComparer<T, V> : IEqualityComparer<T>
    {
        private Func<T, V> keySelector;
        private IEqualityComparer<V> comparer;

        public CommonEqualityComparer(Func<T, V> keySelector, IEqualityComparer<V> comparer)
        {
            this.keySelector = keySelector;
            this.comparer = comparer;
        }

        public CommonEqualityComparer(Func<T, V> keySelector)
            : this(keySelector, EqualityComparer<V>.Default)
        { }

        public bool Equals(T x, T y)
        {
            return comparer.Equals(keySelector(x), keySelector(y));
        }

        public int GetHashCode(T obj)
        {
            return comparer.GetHashCode(keySelector(obj));
        }
    }
    public static class DistinctExtensions
    {
        public static IEnumerable<T> Distinct<T, V>(this IEnumerable<T> source, Func<T, V> keySelector)
        {
            return source.Distinct(new CommonEqualityComparer<T, V>(keySelector));
        }

        public static IEnumerable<T> Distinct<T, V>(this IEnumerable<T> source, Func<T, V> keySelector, IEqualityComparer<V> comparer)
        {
            return source.Distinct(new CommonEqualityComparer<T, V>(keySelector, comparer));
        }
    }
    #endregion
}