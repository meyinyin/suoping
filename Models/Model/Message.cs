/**  版本信息模板在安装目录下，可自行修改。
* Message.cs
*
* 功 能： N/A
* 类 名： Message
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
	/// Message:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Message
	{
		public Message()
		{}
		#region Model
		private int _id;
		private string _mname;
		private int? _mphone;
		private string _memail;
		private string _madress;
		private string _mcontent;
		private DateTime? _mdate;
		private bool _mstate;
		private int? _avg1;
		private string _avg2;
		private int? _avg3;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 留言姓名
		/// </summary>
		public string MName
		{
			set{ _mname=value;}
			get{return _mname;}
		}
		/// <summary>
		/// 留言电话
		/// </summary>
		public int? MPhone
		{
			set{ _mphone=value;}
			get{return _mphone;}
		}
		/// <summary>
		/// 留言邮箱
		/// </summary>
		public string MEmail
		{
			set{ _memail=value;}
			get{return _memail;}
		}
		/// <summary>
		/// 留言地址
		/// </summary>
		public string MAdress
		{
			set{ _madress=value;}
			get{return _madress;}
		}
		/// <summary>
		/// 留言内容
		/// </summary>
		public string MContent
		{
			set{ _mcontent=value;}
			get{return _mcontent;}
		}
		/// <summary>
		/// 留言时间
		/// </summary>
		public DateTime? MDate
		{
			set{ _mdate=value;}
			get{return _mdate;}
		}
		/// <summary>
		/// 是否阅读
		/// </summary>
		public bool MState
		{
			set{ _mstate=value;}
			get{return _mstate;}
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
		public int? avg3
		{
			set{ _avg3=value;}
			get{return _avg3;}
		}
		#endregion Model

	}
}

