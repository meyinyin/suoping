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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:News
	/// </summary>
	public partial class News
	{
		public News()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "News"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from News");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.News model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into News(");
			strSql.Append("AddDateTime,Author,Content,Description,FileURL,FromWhere,Info,IsDelete,IsLock,IsTJ,IsHot,IsTop,KeyWord,PicURL,ReadCount,SortID,Tag,Title,URL,VideoURL,Weight,SiteID,UninoID,UserID,IsPic,IsStore,DingNum,ZhuangNum,ZhiChiNum,SCNum,HasAddress,AddressName,Address,AddressX,AddressY,ShopMenberID,ShareTxt,SharePicID,ShareMainPicUrl,EditDateTime)");
			strSql.Append(" values (");
			strSql.Append("@AddDateTime,@Author,@Content,@Description,@FileURL,@FromWhere,@Info,@IsDelete,@IsLock,@IsTJ,@IsHot,@IsTop,@KeyWord,@PicURL,@ReadCount,@SortID,@Tag,@Title,@URL,@VideoURL,@Weight,@SiteID,@UninoID,@UserID,@IsPic,@IsStore,@DingNum,@ZhuangNum,@ZhiChiNum,@SCNum,@HasAddress,@AddressName,@Address,@AddressX,@AddressY,@ShopMenberID,@ShareTxt,@SharePicID,@ShareMainPicUrl,@EditDateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@AddDateTime", SqlDbType.DateTime),
					new SqlParameter("@Author", SqlDbType.NVarChar,50),
					new SqlParameter("@Content", SqlDbType.NText),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@FileURL", SqlDbType.NVarChar,200),
					new SqlParameter("@FromWhere", SqlDbType.NVarChar,50),
					new SqlParameter("@Info", SqlDbType.NText),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@IsTJ", SqlDbType.Bit,1),
					new SqlParameter("@IsHot", SqlDbType.Bit,1),
					new SqlParameter("@IsTop", SqlDbType.Bit,1),
					new SqlParameter("@KeyWord", SqlDbType.NVarChar,200),
					new SqlParameter("@PicURL", SqlDbType.NVarChar,200),
					new SqlParameter("@ReadCount", SqlDbType.Int,4),
					new SqlParameter("@SortID", SqlDbType.Int,4),
					new SqlParameter("@Tag", SqlDbType.NVarChar,200),
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@URL", SqlDbType.NVarChar,200),
					new SqlParameter("@VideoURL", SqlDbType.NVarChar,200),
					new SqlParameter("@Weight", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@UninoID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@IsPic", SqlDbType.Bit,1),
					new SqlParameter("@IsStore", SqlDbType.Bit,1),
					new SqlParameter("@DingNum", SqlDbType.Int,4),
					new SqlParameter("@ZhuangNum", SqlDbType.Int,4),
					new SqlParameter("@ZhiChiNum", SqlDbType.Int,4),
					new SqlParameter("@SCNum", SqlDbType.Int,4),
					new SqlParameter("@HasAddress", SqlDbType.Bit,1),
					new SqlParameter("@AddressName", SqlDbType.NVarChar,200),
					new SqlParameter("@Address", SqlDbType.NVarChar,500),
					new SqlParameter("@AddressX", SqlDbType.Float,8),
					new SqlParameter("@AddressY", SqlDbType.Float,8),
					new SqlParameter("@ShopMenberID", SqlDbType.Int,4),
					new SqlParameter("@ShareTxt", SqlDbType.NText),
					new SqlParameter("@SharePicID", SqlDbType.Int,4),
					new SqlParameter("@ShareMainPicUrl", SqlDbType.NText),
					new SqlParameter("@EditDateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.AddDateTime;
			parameters[1].Value = model.Author;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.FileURL;
			parameters[5].Value = model.FromWhere;
			parameters[6].Value = model.Info;
			parameters[7].Value = model.IsDelete;
			parameters[8].Value = model.IsLock;
			parameters[9].Value = model.IsTJ;
			parameters[10].Value = model.IsHot;
			parameters[11].Value = model.IsTop;
			parameters[12].Value = model.KeyWord;
			parameters[13].Value = model.PicURL;
			parameters[14].Value = model.ReadCount;
			parameters[15].Value = model.SortID;
			parameters[16].Value = model.Tag;
			parameters[17].Value = model.Title;
			parameters[18].Value = model.URL;
			parameters[19].Value = model.VideoURL;
			parameters[20].Value = model.Weight;
			parameters[21].Value = model.SiteID;
			parameters[22].Value = model.UninoID;
			parameters[23].Value = model.UserID;
			parameters[24].Value = model.IsPic;
			parameters[25].Value = model.IsStore;
			parameters[26].Value = model.DingNum;
			parameters[27].Value = model.ZhuangNum;
			parameters[28].Value = model.ZhiChiNum;
			parameters[29].Value = model.SCNum;
			parameters[30].Value = model.HasAddress;
			parameters[31].Value = model.AddressName;
			parameters[32].Value = model.Address;
			parameters[33].Value = model.AddressX;
			parameters[34].Value = model.AddressY;
			parameters[35].Value = model.ShopMenberID;
			parameters[36].Value = model.ShareTxt;
			parameters[37].Value = model.SharePicID;
			parameters[38].Value = model.ShareMainPicUrl;
			parameters[39].Value = model.EditDateTime;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.News model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update News set ");
			strSql.Append("AddDateTime=@AddDateTime,");
			strSql.Append("Author=@Author,");
			strSql.Append("Content=@Content,");
			strSql.Append("Description=@Description,");
			strSql.Append("FileURL=@FileURL,");
			strSql.Append("FromWhere=@FromWhere,");
			strSql.Append("Info=@Info,");
			strSql.Append("IsDelete=@IsDelete,");
			strSql.Append("IsLock=@IsLock,");
			strSql.Append("IsTJ=@IsTJ,");
			strSql.Append("IsHot=@IsHot,");
			strSql.Append("IsTop=@IsTop,");
			strSql.Append("KeyWord=@KeyWord,");
			strSql.Append("PicURL=@PicURL,");
			strSql.Append("ReadCount=@ReadCount,");
			strSql.Append("SortID=@SortID,");
			strSql.Append("Tag=@Tag,");
			strSql.Append("Title=@Title,");
			strSql.Append("URL=@URL,");
			strSql.Append("VideoURL=@VideoURL,");
			strSql.Append("Weight=@Weight,");
			strSql.Append("SiteID=@SiteID,");
			strSql.Append("UninoID=@UninoID,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("IsPic=@IsPic,");
			strSql.Append("IsStore=@IsStore,");
			strSql.Append("DingNum=@DingNum,");
			strSql.Append("ZhuangNum=@ZhuangNum,");
			strSql.Append("ZhiChiNum=@ZhiChiNum,");
			strSql.Append("SCNum=@SCNum,");
			strSql.Append("HasAddress=@HasAddress,");
			strSql.Append("AddressName=@AddressName,");
			strSql.Append("Address=@Address,");
			strSql.Append("AddressX=@AddressX,");
			strSql.Append("AddressY=@AddressY,");
			strSql.Append("ShopMenberID=@ShopMenberID,");
			strSql.Append("ShareTxt=@ShareTxt,");
			strSql.Append("SharePicID=@SharePicID,");
			strSql.Append("ShareMainPicUrl=@ShareMainPicUrl,");
			strSql.Append("EditDateTime=@EditDateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@AddDateTime", SqlDbType.DateTime),
					new SqlParameter("@Author", SqlDbType.NVarChar,50),
					new SqlParameter("@Content", SqlDbType.NText),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@FileURL", SqlDbType.NVarChar,200),
					new SqlParameter("@FromWhere", SqlDbType.NVarChar,50),
					new SqlParameter("@Info", SqlDbType.NText),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@IsTJ", SqlDbType.Bit,1),
					new SqlParameter("@IsHot", SqlDbType.Bit,1),
					new SqlParameter("@IsTop", SqlDbType.Bit,1),
					new SqlParameter("@KeyWord", SqlDbType.NVarChar,200),
					new SqlParameter("@PicURL", SqlDbType.NVarChar,200),
					new SqlParameter("@ReadCount", SqlDbType.Int,4),
					new SqlParameter("@SortID", SqlDbType.Int,4),
					new SqlParameter("@Tag", SqlDbType.NVarChar,200),
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@URL", SqlDbType.NVarChar,200),
					new SqlParameter("@VideoURL", SqlDbType.NVarChar,200),
					new SqlParameter("@Weight", SqlDbType.Int,4),
					new SqlParameter("@SiteID", SqlDbType.Int,4),
					new SqlParameter("@UninoID", SqlDbType.Int,4),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@IsPic", SqlDbType.Bit,1),
					new SqlParameter("@IsStore", SqlDbType.Bit,1),
					new SqlParameter("@DingNum", SqlDbType.Int,4),
					new SqlParameter("@ZhuangNum", SqlDbType.Int,4),
					new SqlParameter("@ZhiChiNum", SqlDbType.Int,4),
					new SqlParameter("@SCNum", SqlDbType.Int,4),
					new SqlParameter("@HasAddress", SqlDbType.Bit,1),
					new SqlParameter("@AddressName", SqlDbType.NVarChar,200),
					new SqlParameter("@Address", SqlDbType.NVarChar,500),
					new SqlParameter("@AddressX", SqlDbType.Float,8),
					new SqlParameter("@AddressY", SqlDbType.Float,8),
					new SqlParameter("@ShopMenberID", SqlDbType.Int,4),
					new SqlParameter("@ShareTxt", SqlDbType.NText),
					new SqlParameter("@SharePicID", SqlDbType.Int,4),
					new SqlParameter("@ShareMainPicUrl", SqlDbType.NText),
					new SqlParameter("@EditDateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.AddDateTime;
			parameters[1].Value = model.Author;
			parameters[2].Value = model.Content;
			parameters[3].Value = model.Description;
			parameters[4].Value = model.FileURL;
			parameters[5].Value = model.FromWhere;
			parameters[6].Value = model.Info;
			parameters[7].Value = model.IsDelete;
			parameters[8].Value = model.IsLock;
			parameters[9].Value = model.IsTJ;
			parameters[10].Value = model.IsHot;
			parameters[11].Value = model.IsTop;
			parameters[12].Value = model.KeyWord;
			parameters[13].Value = model.PicURL;
			parameters[14].Value = model.ReadCount;
			parameters[15].Value = model.SortID;
			parameters[16].Value = model.Tag;
			parameters[17].Value = model.Title;
			parameters[18].Value = model.URL;
			parameters[19].Value = model.VideoURL;
			parameters[20].Value = model.Weight;
			parameters[21].Value = model.SiteID;
			parameters[22].Value = model.UninoID;
			parameters[23].Value = model.UserID;
			parameters[24].Value = model.IsPic;
			parameters[25].Value = model.IsStore;
			parameters[26].Value = model.DingNum;
			parameters[27].Value = model.ZhuangNum;
			parameters[28].Value = model.ZhiChiNum;
			parameters[29].Value = model.SCNum;
			parameters[30].Value = model.HasAddress;
			parameters[31].Value = model.AddressName;
			parameters[32].Value = model.Address;
			parameters[33].Value = model.AddressX;
			parameters[34].Value = model.AddressY;
			parameters[35].Value = model.ShopMenberID;
			parameters[36].Value = model.ShareTxt;
			parameters[37].Value = model.SharePicID;
			parameters[38].Value = model.ShareMainPicUrl;
			parameters[39].Value = model.EditDateTime;
			parameters[40].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from News ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from News ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.News GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 AddDateTime,Author,Content,Description,FileURL,FromWhere,ID,Info,IsDelete,IsLock,IsTJ,IsHot,IsTop,KeyWord,PicURL,ReadCount,SortID,Tag,Title,URL,VideoURL,Weight,SiteID,UninoID,UserID,IsPic,IsStore,DingNum,ZhuangNum,ZhiChiNum,SCNum,HasAddress,AddressName,Address,AddressX,AddressY,ShopMenberID,ShareTxt,SharePicID,ShareMainPicUrl,EditDateTime from News ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.News model=new Maticsoft.Model.News();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.News DataRowToModel(DataRow row)
		{
			Maticsoft.Model.News model=new Maticsoft.Model.News();
			if (row != null)
			{
				if(row["AddDateTime"]!=null && row["AddDateTime"].ToString()!="")
				{
					model.AddDateTime=DateTime.Parse(row["AddDateTime"].ToString());
				}
				if(row["Author"]!=null)
				{
					model.Author=row["Author"].ToString();
				}
				if(row["Content"]!=null)
				{
					model.Content=row["Content"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["FileURL"]!=null)
				{
					model.FileURL=row["FileURL"].ToString();
				}
				if(row["FromWhere"]!=null)
				{
					model.FromWhere=row["FromWhere"].ToString();
				}
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["IsDelete"]!=null && row["IsDelete"].ToString()!="")
				{
					if((row["IsDelete"].ToString()=="1")||(row["IsDelete"].ToString().ToLower()=="true"))
					{
						model.IsDelete=true;
					}
					else
					{
						model.IsDelete=false;
					}
				}
				if(row["IsLock"]!=null && row["IsLock"].ToString()!="")
				{
					if((row["IsLock"].ToString()=="1")||(row["IsLock"].ToString().ToLower()=="true"))
					{
						model.IsLock=true;
					}
					else
					{
						model.IsLock=false;
					}
				}
				if(row["IsTJ"]!=null && row["IsTJ"].ToString()!="")
				{
					if((row["IsTJ"].ToString()=="1")||(row["IsTJ"].ToString().ToLower()=="true"))
					{
						model.IsTJ=true;
					}
					else
					{
						model.IsTJ=false;
					}
				}
				if(row["IsHot"]!=null && row["IsHot"].ToString()!="")
				{
					if((row["IsHot"].ToString()=="1")||(row["IsHot"].ToString().ToLower()=="true"))
					{
						model.IsHot=true;
					}
					else
					{
						model.IsHot=false;
					}
				}
				if(row["IsTop"]!=null && row["IsTop"].ToString()!="")
				{
					if((row["IsTop"].ToString()=="1")||(row["IsTop"].ToString().ToLower()=="true"))
					{
						model.IsTop=true;
					}
					else
					{
						model.IsTop=false;
					}
				}
				if(row["KeyWord"]!=null)
				{
					model.KeyWord=row["KeyWord"].ToString();
				}
				if(row["PicURL"]!=null)
				{
					model.PicURL=row["PicURL"].ToString();
				}
				if(row["ReadCount"]!=null && row["ReadCount"].ToString()!="")
				{
					model.ReadCount=int.Parse(row["ReadCount"].ToString());
				}
				if(row["SortID"]!=null && row["SortID"].ToString()!="")
				{
					model.SortID=int.Parse(row["SortID"].ToString());
				}
				if(row["Tag"]!=null)
				{
					model.Tag=row["Tag"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["URL"]!=null)
				{
					model.URL=row["URL"].ToString();
				}
				if(row["VideoURL"]!=null)
				{
					model.VideoURL=row["VideoURL"].ToString();
				}
				if(row["Weight"]!=null && row["Weight"].ToString()!="")
				{
					model.Weight=int.Parse(row["Weight"].ToString());
				}
				if(row["SiteID"]!=null && row["SiteID"].ToString()!="")
				{
					model.SiteID=int.Parse(row["SiteID"].ToString());
				}
				if(row["UninoID"]!=null && row["UninoID"].ToString()!="")
				{
					model.UninoID=int.Parse(row["UninoID"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["IsPic"]!=null && row["IsPic"].ToString()!="")
				{
					if((row["IsPic"].ToString()=="1")||(row["IsPic"].ToString().ToLower()=="true"))
					{
						model.IsPic=true;
					}
					else
					{
						model.IsPic=false;
					}
				}
				if(row["IsStore"]!=null && row["IsStore"].ToString()!="")
				{
					if((row["IsStore"].ToString()=="1")||(row["IsStore"].ToString().ToLower()=="true"))
					{
						model.IsStore=true;
					}
					else
					{
						model.IsStore=false;
					}
				}
				if(row["DingNum"]!=null && row["DingNum"].ToString()!="")
				{
					model.DingNum=int.Parse(row["DingNum"].ToString());
				}
				if(row["ZhuangNum"]!=null && row["ZhuangNum"].ToString()!="")
				{
					model.ZhuangNum=int.Parse(row["ZhuangNum"].ToString());
				}
				if(row["ZhiChiNum"]!=null && row["ZhiChiNum"].ToString()!="")
				{
					model.ZhiChiNum=int.Parse(row["ZhiChiNum"].ToString());
				}
				if(row["SCNum"]!=null && row["SCNum"].ToString()!="")
				{
					model.SCNum=int.Parse(row["SCNum"].ToString());
				}
				if(row["HasAddress"]!=null && row["HasAddress"].ToString()!="")
				{
					if((row["HasAddress"].ToString()=="1")||(row["HasAddress"].ToString().ToLower()=="true"))
					{
						model.HasAddress=true;
					}
					else
					{
						model.HasAddress=false;
					}
				}
				if(row["AddressName"]!=null)
				{
					model.AddressName=row["AddressName"].ToString();
				}
				if(row["Address"]!=null)
				{
					model.Address=row["Address"].ToString();
				}
				if(row["AddressX"]!=null && row["AddressX"].ToString()!="")
				{
					model.AddressX=decimal.Parse(row["AddressX"].ToString());
				}
				if(row["AddressY"]!=null && row["AddressY"].ToString()!="")
				{
					model.AddressY=decimal.Parse(row["AddressY"].ToString());
				}
				if(row["ShopMenberID"]!=null && row["ShopMenberID"].ToString()!="")
				{
					model.ShopMenberID=int.Parse(row["ShopMenberID"].ToString());
				}
				if(row["ShareTxt"]!=null)
				{
					model.ShareTxt=row["ShareTxt"].ToString();
				}
				if(row["SharePicID"]!=null && row["SharePicID"].ToString()!="")
				{
					model.SharePicID=int.Parse(row["SharePicID"].ToString());
				}
				if(row["ShareMainPicUrl"]!=null)
				{
					model.ShareMainPicUrl=row["ShareMainPicUrl"].ToString();
				}
				if(row["EditDateTime"]!=null && row["EditDateTime"].ToString()!="")
				{
					model.EditDateTime=DateTime.Parse(row["EditDateTime"].ToString());
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select AddDateTime,Author,Content,Description,FileURL,FromWhere,ID,Info,IsDelete,IsLock,IsTJ,IsHot,IsTop,KeyWord,PicURL,ReadCount,SortID,Tag,Title,URL,VideoURL,Weight,SiteID,UninoID,UserID,IsPic,IsStore,DingNum,ZhuangNum,ZhiChiNum,SCNum,HasAddress,AddressName,Address,AddressX,AddressY,ShopMenberID,ShareTxt,SharePicID,ShareMainPicUrl,EditDateTime ");
			strSql.Append(" FROM News ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" AddDateTime,Author,Content,Description,FileURL,FromWhere,ID,Info,IsDelete,IsLock,IsTJ,IsHot,IsTop,KeyWord,PicURL,ReadCount,SortID,Tag,Title,URL,VideoURL,Weight,SiteID,UninoID,UserID,IsPic,IsStore,DingNum,ZhuangNum,ZhiChiNum,SCNum,HasAddress,AddressName,Address,AddressX,AddressY,ShopMenberID,ShareTxt,SharePicID,ShareMainPicUrl,EditDateTime ");
			strSql.Append(" FROM News ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM News ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from News T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "News";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

