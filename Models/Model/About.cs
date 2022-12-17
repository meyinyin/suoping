/**  版本信息模板在安装目录下，可自行修改。
* About.cs
*
* 功 能： N/A
* 类 名： About
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2021/3/29 17:01:19   N/A    初版
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
	/// About:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class About
	{
		public About()
		{}
		#region Model
		private int _id;
		private string _description;
		private string _info;
		private string _picurl;
		private int? _avg1;
		private bool _avg2;
		private string _avg3;
		private string _picurl1;
		private string _picurl2;
		private string _picurl3;
		private string _picurl4;
		private string _picurl5;
		private string _picurl6;
		private string _picurl7;
		private string _picurl8;
		private string _picurl9;
		private string _picurl10;
		private string _picurl11;
		private string _picurl12;
		private string _picurl13;
		private string _wadress;
		private string _adress;
		private string _phone;
		private string _cphone;
		private string _postnum;
		private string _apicurl;
		private string _avg4;
		private string _avg5;
		private bool _avg6;
		private string _jdtxt1;
		private string _jdtxt2;
		private string _jdtxt3;
		private string _jdtxt4;
		private string _jdtxt5;
		private string _wxurl1;
		private string _wxurl2;
		private string _wxurl3;
		private string _jdtxt6;
		private string _jdtxt7;
		private string _jdtxt8;
		private string _jdtxt9;
		private string _jdtxt10;
		private string _title1;
		private string _title2;
		private string _title3;
		private string _title4;
		private string _title5;
		private string _title7;
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
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
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
		/// 关于我们图片
		/// </summary>
		public string PicURL
		{
			set{ _picurl=value;}
			get{return _picurl;}
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
		public bool avg2
		{
			set{ _avg2=value;}
			get{return _avg2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string avg3
		{
			set{ _avg3=value;}
			get{return _avg3;}
		}
		/// <summary>
		/// 基地展示图片1
		/// </summary>
		public string PicURL1
		{
			set{ _picurl1=value;}
			get{return _picurl1;}
		}
		/// <summary>
		/// 基地展示图片2
		/// </summary>
		public string PicURL2
		{
			set{ _picurl2=value;}
			get{return _picurl2;}
		}
		/// <summary>
		/// 基地展示图片3
		/// </summary>
		public string PicURL3
		{
			set{ _picurl3=value;}
			get{return _picurl3;}
		}
		/// <summary>
		/// 基地展示图片4
		/// </summary>
		public string PicURL4
		{
			set{ _picurl4=value;}
			get{return _picurl4;}
		}
		/// <summary>
		/// 基地展示图片5
		/// </summary>
		public string PicURL5
		{
			set{ _picurl5=value;}
			get{return _picurl5;}
		}
		/// <summary>
		/// 荣誉资质1
		/// </summary>
		public string PicURL6
		{
			set{ _picurl6=value;}
			get{return _picurl6;}
		}
		/// <summary>
		/// 荣誉资质2
		/// </summary>
		public string PicURL7
		{
			set{ _picurl7=value;}
			get{return _picurl7;}
		}
		/// <summary>
		/// 荣誉资质3
		/// </summary>
		public string PicURL8
		{
			set{ _picurl8=value;}
			get{return _picurl8;}
		}
		/// <summary>
		/// 荣誉资质4
		/// </summary>
		public string PicURL9
		{
			set{ _picurl9=value;}
			get{return _picurl9;}
		}
		/// <summary>
		/// 荣誉资质5
		/// </summary>
		public string PicURL10
		{
			set{ _picurl10=value;}
			get{return _picurl10;}
		}
		/// <summary>
		/// 荣誉资质6
		/// </summary>
		public string PicURL11
		{
			set{ _picurl11=value;}
			get{return _picurl11;}
		}
		/// <summary>
		/// 荣誉资质7
		/// </summary>
		public string PicURL12
		{
			set{ _picurl12=value;}
			get{return _picurl12;}
		}
		/// <summary>
		/// 荣誉资质8
		/// </summary>
		public string PicURL13
		{
			set{ _picurl13=value;}
			get{return _picurl13;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WAdress
		{
			set{ _wadress=value;}
			get{return _wadress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Adress
		{
			set{ _adress=value;}
			get{return _adress;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CPhone
		{
			set{ _cphone=value;}
			get{return _cphone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PostNum
		{
			set{ _postnum=value;}
			get{return _postnum;}
		}
		/// <summary>
		/// 联系我们图片
		/// </summary>
		public string APicURL
		{
			set{ _apicurl=value;}
			get{return _apicurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string avg4
		{
			set{ _avg4=value;}
			get{return _avg4;}
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
		public bool avg6
		{
			set{ _avg6=value;}
			get{return _avg6;}
		}
		/// <summary>
		/// 基地展示图片一描述
		/// </summary>
		public string JDtxt1
		{
			set{ _jdtxt1=value;}
			get{return _jdtxt1;}
		}
		/// <summary>
		/// 基地展示图片描述
		/// </summary>
		public string JDtxt2
		{
			set{ _jdtxt2=value;}
			get{return _jdtxt2;}
		}
		/// <summary>
		/// 基地展示图片描述
		/// </summary>
		public string JDtxt3
		{
			set{ _jdtxt3=value;}
			get{return _jdtxt3;}
		}
		/// <summary>
		/// 基地展示图片描述
		/// </summary>
		public string JDtxt4
		{
			set{ _jdtxt4=value;}
			get{return _jdtxt4;}
		}
		/// <summary>
		/// 基地展示图片描述
		/// </summary>
		public string JDtxt5
		{
			set{ _jdtxt5=value;}
			get{return _jdtxt5;}
		}
		/// <summary>
		/// 微信二维码
		/// </summary>
		public string WXURL1
		{
			set{ _wxurl1=value;}
			get{return _wxurl1;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXURL2
		{
			set{ _wxurl2=value;}
			get{return _wxurl2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string WXURL3
		{
			set{ _wxurl3=value;}
			get{return _wxurl3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JDtxt6
		{
			set{ _jdtxt6=value;}
			get{return _jdtxt6;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JDtxt7
		{
			set{ _jdtxt7=value;}
			get{return _jdtxt7;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JDtxt8
		{
			set{ _jdtxt8=value;}
			get{return _jdtxt8;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JDtxt9
		{
			set{ _jdtxt9=value;}
			get{return _jdtxt9;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JDtxt10
		{
			set{ _jdtxt10=value;}
			get{return _jdtxt10;}
		}
		/// <summary>
		/// 标题1
		/// </summary>
		public string Title1
		{
			set{ _title1=value;}
			get{return _title1;}
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
		public string Title3
		{
			set{ _title3=value;}
			get{return _title3;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title4
		{
			set{ _title4=value;}
			get{return _title4;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title5
		{
			set{ _title5=value;}
			get{return _title5;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Title7
		{
			set{ _title7=value;}
			get{return _title7;}
		}
		#endregion Model

	}
}

