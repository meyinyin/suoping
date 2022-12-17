/**  版本信息模板在安装目录下，可自行修改。
* GMile.cs
*
* 功 能： N/A
* 类 名： GMile
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2021/3/29 17:01:20   N/A    初版
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
	/// GMile:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GMile
	{
		public GMile()
		{}
		#region Model
		private int _id;
		private string _gname;
		private string _gcontent;
		private DateTime? _gdate;
		private string _gchannel;
		private bool _gstate;
		private string _avg5;
		private string _faceurl;
		private bool _islock;
		private string _picurl;
		private string _routeurl;
		private int? _msgtype;
		private int? _msgsortid;
		private int? _targetid;
		private int? _msgparentid;
		private int? _level;
		private string _ip;
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
		public string GName
		{
			set{ _gname=value;}
			get{return _gname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GContent
		{
			set{ _gcontent=value;}
			get{return _gcontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? GDate
		{
			set{ _gdate=value;}
			get{return _gdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GChannel
		{
			set{ _gchannel=value;}
			get{return _gchannel;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool GState
		{
			set{ _gstate=value;}
			get{return _gstate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string avg5
		{
			set{ _avg5=value;}
			get{return _avg5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FaceURL
		{
			set{ _faceurl=value;}
			get{return _faceurl;}
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
		public string PicUrl
		{
			set{ _picurl=value;}
			get{return _picurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RouteUrl
		{
			set{ _routeurl=value;}
			get{return _routeurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MsgType
		{
			set{ _msgtype=value;}
			get{return _msgtype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MsgSortID
		{
			set{ _msgsortid=value;}
			get{return _msgsortid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TargetID
		{
			set{ _targetid=value;}
			get{return _targetid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MsgParentID
		{
			set{ _msgparentid=value;}
			get{return _msgparentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string IP
		{
			set{ _ip=value;}
			get{return _ip;}
		}
		#endregion Model

	}
}

