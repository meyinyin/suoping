/**  版本信息模板在安装目录下，可自行修改。
* News.cs
*
* 功 能： N/A
* 类 名： News
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2021/8/4 16:19:20   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// News:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class News
	{
		public News()
		{}
		#region Model
		private DateTime? _adddatetime= DateTime.Now;
		private string _author;
		private string _content;
		private string _description;
		private string _fileurl;
		private string _fromwhere;
		private int _id;
		private string _info;
		private bool _isdelete= false;
		private bool _islock= true;
		private bool _istj= false;
		private bool _ishot= false;
		private bool _istop= false;
		private string _keyword;
		private string _picurl;
		private int? _readcount=0;
		private int? _sortid;
		private string _tag;
		private string _title;
		private string _url;
		private string _videourl;
		private int? _weight=0;
		private int? _siteid=1;
		private int? _uninoid;
		private int? _userid;
		private bool _ispic;
		private bool _isstore;
		private int? _dingnum;
		private int? _zhuangnum;
		private int? _zhichinum;
		private int? _scnum;
		private bool _hasaddress;
		private string _addressname;
		private string _address;
		private decimal? _addressx;
		private decimal? _addressy;
		private int? _shopmenberid;
		private string _sharetxt;
		private int? _sharepicid;
		private string _sharemainpicurl;
		private DateTime? _editdatetime;
		/// <summary>
		/// 文章添加时间
		/// </summary>
		public DateTime? AddDateTime
		{
			set{ _adddatetime=value;}
			get{return _adddatetime;}
		}
		/// <summary>
		/// 作者
		/// </summary>
		public string Author
		{
			set{ _author=value;}
			get{return _author;}
		}
		/// <summary>
		/// 内容
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileURL
		{
			set{ _fileurl=value;}
			get{return _fileurl;}
		}
		/// <summary>
		/// 来源
		/// </summary>
		public string FromWhere
		{
			set{ _fromwhere=value;}
			get{return _fromwhere;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Info
		{
			set{ _info=value;}
			get{return _info;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsLock
		{
			set{ _islock=value;}
			get{return _islock;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsTJ
		{
			set{ _istj=value;}
			get{return _istj;}
		}
		/// <summary>
		/// 是否热点
		/// </summary>
		public bool IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 是否置顶
		/// </summary>
		public bool IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
		}
		/// <summary>
		/// 关键字
		/// </summary>
		public string KeyWord
		{
			set{ _keyword=value;}
			get{return _keyword;}
		}
		/// <summary>
		/// 主图地址
		/// </summary>
		public string PicURL
		{
			set{ _picurl=value;}
			get{return _picurl;}
		}
		/// <summary>
		/// 阅读量
		/// </summary>
		public int? ReadCount
		{
			set{ _readcount=value;}
			get{return _readcount;}
		}
		/// <summary>
		/// 分类ID
		/// </summary>
		public int? SortID
		{
			set{ _sortid=value;}
			get{return _sortid;}
		}
		/// <summary>
		/// 标签
		/// </summary>
		public string Tag
		{
			set{ _tag=value;}
			get{return _tag;}
		}
		/// <summary>
		/// 标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string URL
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 视频地址
		/// </summary>
		public string VideoURL
		{
			set{ _videourl=value;}
			get{return _videourl;}
		}
		/// <summary>
		/// 权重
		/// </summary>
		public int? Weight
		{
			set{ _weight=value;}
			get{return _weight;}
		}
		/// <summary>
		/// 站点
		/// </summary>
		public int? SiteID
		{
			set{ _siteid=value;}
			get{return _siteid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UninoID
		{
			set{ _uninoid=value;}
			get{return _uninoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 是否是写真
		/// </summary>
		public bool IsPic
		{
			set{ _ispic=value;}
			get{return _ispic;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsStore
		{
			set{ _isstore=value;}
			get{return _isstore;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DingNum
		{
			set{ _dingnum=value;}
			get{return _dingnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ZhuangNum
		{
			set{ _zhuangnum=value;}
			get{return _zhuangnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ZhiChiNum
		{
			set{ _zhichinum=value;}
			get{return _zhichinum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SCNum
		{
			set{ _scnum=value;}
			get{return _scnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool HasAddress
		{
			set{ _hasaddress=value;}
			get{return _hasaddress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string AddressName
		{
			set{ _addressname=value;}
			get{return _addressname;}
		}
		/// <summary>
		/// 地址
		/// </summary>
		public string Address
		{
			set{ _address=value;}
			get{return _address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AddressX
		{
			set{ _addressx=value;}
			get{return _addressx;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? AddressY
		{
			set{ _addressy=value;}
			get{return _addressy;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ShopMenberID
		{
			set{ _shopmenberid=value;}
			get{return _shopmenberid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShareTxt
		{
			set{ _sharetxt=value;}
			get{return _sharetxt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SharePicID
		{
			set{ _sharepicid=value;}
			get{return _sharepicid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ShareMainPicUrl
		{
			set{ _sharemainpicurl=value;}
			get{return _sharemainpicurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? EditDateTime
		{
			set{ _editdatetime=value;}
			get{return _editdatetime;}
		}
		#endregion Model

	}
}

