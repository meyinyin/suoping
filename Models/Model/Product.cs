/**  版本信息模板在安装目录下，可自行修改。
* Product.cs
*
* 功 能： N/A
* 类 名： Product
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2021/3/29 17:01:21   N/A    初版
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
	/// Product:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Product
	{
		public Product()
		{}
		#region Model
		private int _id;
		private string _picurl;
		private string _picurl1;
		private string _picurl2;
		private string _picurl3;
		private string _picurl4;
		private string _picurl5;
		private string _title;
		private string _description;
		private string _tag;
		private string _info;
		private bool _ishot;
		private bool _istop;
		private bool _istj;
		private string _keyword;
		private int? _sortid;
		private string _videourl;
		private int? _weight;
		private int? _readcount;
		private bool _islock;
		private bool _isdelete;
		private string _title2;
		private int? _avg1;
		private string _avg2;
		private bool _avg3;
		private DateTime? _adddatetime;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 产品主图
		/// </summary>
		public string PicURL
		{
			set{ _picurl=value;}
			get{return _picurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PicURL1
		{
			set{ _picurl1=value;}
			get{return _picurl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PicURL2
		{
			set{ _picurl2=value;}
			get{return _picurl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PicURL3
		{
			set{ _picurl3=value;}
			get{return _picurl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PicURL4
		{
			set{ _picurl4=value;}
			get{return _picurl4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PicURL5
		{
			set{ _picurl5=value;}
			get{return _picurl5;}
		}
		/// <summary>
		/// 产品标题
		/// </summary>
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 产品描述
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 产品标签
		/// </summary>
		public string Tag
		{
			set{ _tag=value;}
			get{return _tag;}
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
		public bool IsHot
		{
			set{ _ishot=value;}
			get{return _ishot;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsTop
		{
			set{ _istop=value;}
			get{return _istop;}
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
		/// 
		/// </summary>
		public string KeyWord
		{
			set{ _keyword=value;}
			get{return _keyword;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SortID
		{
			set{ _sortid=value;}
			get{return _sortid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string VideoURL
		{
			set{ _videourl=value;}
			get{return _videourl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Weight
		{
			set{ _weight=value;}
			get{return _weight;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ReadCount
		{
			set{ _readcount=value;}
			get{return _readcount;}
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
		public bool IsDelete
		{
			set{ _isdelete=value;}
			get{return _isdelete;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title2
		{
			set{ _title2=value;}
			get{return _title2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? avg1
		{
			set{ _avg1=value;}
			get{return _avg1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string avg2
		{
			set{ _avg2=value;}
			get{return _avg2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool avg3
		{
			set{ _avg3=value;}
			get{return _avg3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? AddDateTime
		{
			set{ _adddatetime=value;}
			get{return _adddatetime;}
		}
		#endregion Model

	}
}

