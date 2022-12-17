/**  版本信息模板在安装目录下，可自行修改。
* Login.cs
*
* 功 能： N/A
* 类 名： Login
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
	/// Login:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Login
	{
		public Login()
		{}
		#region Model
		private int _id;
		private string _lname;
		private string _lpwd;
		private int? _lever;
		private bool _avg;
		private string _avg2;
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
		public string LName
		{
			set{ _lname=value;}
			get{return _lname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LPwd
		{
			set{ _lpwd=value;}
			get{return _lpwd;}
		}
		/// <summary>
		/// 登录级别
		/// </summary>
		public int? Lever
		{
			set{ _lever=value;}
			get{return _lever;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool avg
		{
			set{ _avg=value;}
			get{return _avg;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string avg2
		{
			set{ _avg2=value;}
			get{return _avg2;}
		}
		#endregion Model

	}
}

