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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Product
	/// </summary>
	public partial class Product
	{
		public Product()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Product"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int ID)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int result= DbHelperSQL.RunProcedure("Product_Exists",parameters,out rowsAffected);
			if(result==1)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		///  增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Product model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PicURL", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL1", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL2", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL3", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL4", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL5", SqlDbType.NVarChar,250),
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@Tag", SqlDbType.NVarChar,200),
					new SqlParameter("@Info", SqlDbType.NText),
					new SqlParameter("@IsHot", SqlDbType.Bit,1),
					new SqlParameter("@IsTop", SqlDbType.Bit,1),
					new SqlParameter("@IsTJ", SqlDbType.Bit,1),
					new SqlParameter("@KeyWord", SqlDbType.NVarChar,200),
					new SqlParameter("@SortID", SqlDbType.Int,4),
					new SqlParameter("@VideoURL", SqlDbType.NVarChar,250),
					new SqlParameter("@Weight", SqlDbType.Int,4),
					new SqlParameter("@ReadCount", SqlDbType.Int,4),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1),
					new SqlParameter("@Title2", SqlDbType.NVarChar,250),
					new SqlParameter("@avg1", SqlDbType.Int,4),
					new SqlParameter("@avg2", SqlDbType.NVarChar,200),
					new SqlParameter("@avg3", SqlDbType.Bit,1),
					new SqlParameter("@AddDateTime", SqlDbType.DateTime)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.PicURL;
			parameters[2].Value = model.PicURL1;
			parameters[3].Value = model.PicURL2;
			parameters[4].Value = model.PicURL3;
			parameters[5].Value = model.PicURL4;
			parameters[6].Value = model.PicURL5;
			parameters[7].Value = model.Title;
			parameters[8].Value = model.Description;
			parameters[9].Value = model.Tag;
			parameters[10].Value = model.Info;
			parameters[11].Value = model.IsHot;
			parameters[12].Value = model.IsTop;
			parameters[13].Value = model.IsTJ;
			parameters[14].Value = model.KeyWord;
			parameters[15].Value = model.SortID;
			parameters[16].Value = model.VideoURL;
			parameters[17].Value = model.Weight;
			parameters[18].Value = model.ReadCount;
			parameters[19].Value = model.IsLock;
			parameters[20].Value = model.IsDelete;
			parameters[21].Value = model.Title2;
			parameters[22].Value = model.avg1;
			parameters[23].Value = model.avg2;
			parameters[24].Value = model.avg3;
			parameters[25].Value = model.AddDateTime;

			DbHelperSQL.RunProcedure("Product_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Product model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@PicURL", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL1", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL2", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL3", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL4", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL5", SqlDbType.NVarChar,250),
					new SqlParameter("@Title", SqlDbType.NVarChar,200),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@Tag", SqlDbType.NVarChar,200),
					new SqlParameter("@Info", SqlDbType.NText),
					new SqlParameter("@IsHot", SqlDbType.Bit,1),
					new SqlParameter("@IsTop", SqlDbType.Bit,1),
					new SqlParameter("@IsTJ", SqlDbType.Bit,1),
					new SqlParameter("@KeyWord", SqlDbType.NVarChar,200),
					new SqlParameter("@SortID", SqlDbType.Int,4),
					new SqlParameter("@VideoURL", SqlDbType.NVarChar,250),
					new SqlParameter("@Weight", SqlDbType.Int,4),
					new SqlParameter("@ReadCount", SqlDbType.Int,4),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@IsDelete", SqlDbType.Bit,1),
					new SqlParameter("@Title2", SqlDbType.NVarChar,250),
					new SqlParameter("@avg1", SqlDbType.Int,4),
					new SqlParameter("@avg2", SqlDbType.NVarChar,200),
					new SqlParameter("@avg3", SqlDbType.Bit,1),
					new SqlParameter("@AddDateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.PicURL;
			parameters[2].Value = model.PicURL1;
			parameters[3].Value = model.PicURL2;
			parameters[4].Value = model.PicURL3;
			parameters[5].Value = model.PicURL4;
			parameters[6].Value = model.PicURL5;
			parameters[7].Value = model.Title;
			parameters[8].Value = model.Description;
			parameters[9].Value = model.Tag;
			parameters[10].Value = model.Info;
			parameters[11].Value = model.IsHot;
			parameters[12].Value = model.IsTop;
			parameters[13].Value = model.IsTJ;
			parameters[14].Value = model.KeyWord;
			parameters[15].Value = model.SortID;
			parameters[16].Value = model.VideoURL;
			parameters[17].Value = model.Weight;
			parameters[18].Value = model.ReadCount;
			parameters[19].Value = model.IsLock;
			parameters[20].Value = model.IsDelete;
			parameters[21].Value = model.Title2;
			parameters[22].Value = model.avg1;
			parameters[23].Value = model.avg2;
			parameters[24].Value = model.avg3;
			parameters[25].Value = model.AddDateTime;

			DbHelperSQL.RunProcedure("Product_Update",parameters,out rowsAffected);
			if (rowsAffected > 0)
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
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			DbHelperSQL.RunProcedure("Product_Delete",parameters,out rowsAffected);
			if (rowsAffected > 0)
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
			strSql.Append("delete from Product ");
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
		public Maticsoft.Model.Product GetModel(int ID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.Product model=new Maticsoft.Model.Product();
			DataSet ds= DbHelperSQL.RunProcedure("Product_GetModel",parameters,"ds");
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
		public Maticsoft.Model.Product DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Product model=new Maticsoft.Model.Product();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["PicURL"]!=null)
				{
					model.PicURL=row["PicURL"].ToString();
				}
				if(row["PicURL1"]!=null)
				{
					model.PicURL1=row["PicURL1"].ToString();
				}
				if(row["PicURL2"]!=null)
				{
					model.PicURL2=row["PicURL2"].ToString();
				}
				if(row["PicURL3"]!=null)
				{
					model.PicURL3=row["PicURL3"].ToString();
				}
				if(row["PicURL4"]!=null)
				{
					model.PicURL4=row["PicURL4"].ToString();
				}
				if(row["PicURL5"]!=null)
				{
					model.PicURL5=row["PicURL5"].ToString();
				}
				if(row["Title"]!=null)
				{
					model.Title=row["Title"].ToString();
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["Tag"]!=null)
				{
					model.Tag=row["Tag"].ToString();
				}
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
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
				if(row["KeyWord"]!=null)
				{
					model.KeyWord=row["KeyWord"].ToString();
				}
				if(row["SortID"]!=null && row["SortID"].ToString()!="")
				{
					model.SortID=int.Parse(row["SortID"].ToString());
				}
				if(row["VideoURL"]!=null)
				{
					model.VideoURL=row["VideoURL"].ToString();
				}
				if(row["Weight"]!=null && row["Weight"].ToString()!="")
				{
					model.Weight=int.Parse(row["Weight"].ToString());
				}
				if(row["ReadCount"]!=null && row["ReadCount"].ToString()!="")
				{
					model.ReadCount=int.Parse(row["ReadCount"].ToString());
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
				if(row["Title2"]!=null)
				{
					model.Title2=row["Title2"].ToString();
				}
				if(row["avg1"]!=null && row["avg1"].ToString()!="")
				{
					model.avg1=int.Parse(row["avg1"].ToString());
				}
				if(row["avg2"]!=null)
				{
					model.avg2=row["avg2"].ToString();
				}
				if(row["avg3"]!=null && row["avg3"].ToString()!="")
				{
					if((row["avg3"].ToString()=="1")||(row["avg3"].ToString().ToLower()=="true"))
					{
						model.avg3=true;
					}
					else
					{
						model.avg3=false;
					}
				}
				if(row["AddDateTime"]!=null && row["AddDateTime"].ToString()!="")
				{
					model.AddDateTime=DateTime.Parse(row["AddDateTime"].ToString());
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
			strSql.Append("select ID,PicURL,PicURL1,PicURL2,PicURL3,PicURL4,PicURL5,Title,Description,Tag,Info,IsHot,IsTop,IsTJ,KeyWord,SortID,VideoURL,Weight,ReadCount,IsLock,IsDelete,Title2,avg1,avg2,avg3,AddDateTime ");
			strSql.Append(" FROM Product ");
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
			strSql.Append(" ID,PicURL,PicURL1,PicURL2,PicURL3,PicURL4,PicURL5,Title,Description,Tag,Info,IsHot,IsTop,IsTJ,KeyWord,SortID,VideoURL,Weight,ReadCount,IsLock,IsDelete,Title2,avg1,avg2,avg3,AddDateTime ");
			strSql.Append(" FROM Product ");
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
			strSql.Append("select count(1) FROM Product ");
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
			strSql.Append(")AS Row, T.*  from Product T ");
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
			parameters[0].Value = "Product";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
		#region  MethodEx

		#endregion  MethodEx
	}
}

