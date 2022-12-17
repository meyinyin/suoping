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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:GMile
	/// </summary>
	public partial class GMile
	{
		public GMile()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "GMile"); 
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

			int result= DbHelperSQL.RunProcedure("GMile_Exists",parameters,out rowsAffected);
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
		public int Add(Maticsoft.Model.GMile model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@GName", SqlDbType.NVarChar,100),
					new SqlParameter("@GContent", SqlDbType.NText),
					new SqlParameter("@GDate", SqlDbType.DateTime),
					new SqlParameter("@GChannel", SqlDbType.NVarChar,100),
					new SqlParameter("@GState", SqlDbType.Bit,1),
					new SqlParameter("@avg5", SqlDbType.NText),
					new SqlParameter("@FaceURL", SqlDbType.NVarChar,200),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@PicUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@RouteUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@MsgType", SqlDbType.Int,4),
					new SqlParameter("@MsgSortID", SqlDbType.Int,4),
					new SqlParameter("@TargetID", SqlDbType.Int,4),
					new SqlParameter("@MsgParentID", SqlDbType.Int,4),
					new SqlParameter("@Level", SqlDbType.Int,4),
					new SqlParameter("@IP", SqlDbType.NVarChar,100)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.GName;
			parameters[2].Value = model.GContent;
			parameters[3].Value = model.GDate;
			parameters[4].Value = model.GChannel;
			parameters[5].Value = model.GState;
			parameters[6].Value = model.avg5;
			parameters[7].Value = model.FaceURL;
			parameters[8].Value = model.IsLock;
			parameters[9].Value = model.PicUrl;
			parameters[10].Value = model.RouteUrl;
			parameters[11].Value = model.MsgType;
			parameters[12].Value = model.MsgSortID;
			parameters[13].Value = model.TargetID;
			parameters[14].Value = model.MsgParentID;
			parameters[15].Value = model.Level;
			parameters[16].Value = model.IP;

			DbHelperSQL.RunProcedure("GMile_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.GMile model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@GName", SqlDbType.NVarChar,100),
					new SqlParameter("@GContent", SqlDbType.NText),
					new SqlParameter("@GDate", SqlDbType.DateTime),
					new SqlParameter("@GChannel", SqlDbType.NVarChar,100),
					new SqlParameter("@GState", SqlDbType.Bit,1),
					new SqlParameter("@avg5", SqlDbType.NText),
					new SqlParameter("@FaceURL", SqlDbType.NVarChar,200),
					new SqlParameter("@IsLock", SqlDbType.Bit,1),
					new SqlParameter("@PicUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@RouteUrl", SqlDbType.NVarChar,200),
					new SqlParameter("@MsgType", SqlDbType.Int,4),
					new SqlParameter("@MsgSortID", SqlDbType.Int,4),
					new SqlParameter("@TargetID", SqlDbType.Int,4),
					new SqlParameter("@MsgParentID", SqlDbType.Int,4),
					new SqlParameter("@Level", SqlDbType.Int,4),
					new SqlParameter("@IP", SqlDbType.NVarChar,100)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.GName;
			parameters[2].Value = model.GContent;
			parameters[3].Value = model.GDate;
			parameters[4].Value = model.GChannel;
			parameters[5].Value = model.GState;
			parameters[6].Value = model.avg5;
			parameters[7].Value = model.FaceURL;
			parameters[8].Value = model.IsLock;
			parameters[9].Value = model.PicUrl;
			parameters[10].Value = model.RouteUrl;
			parameters[11].Value = model.MsgType;
			parameters[12].Value = model.MsgSortID;
			parameters[13].Value = model.TargetID;
			parameters[14].Value = model.MsgParentID;
			parameters[15].Value = model.Level;
			parameters[16].Value = model.IP;

			DbHelperSQL.RunProcedure("GMile_Update",parameters,out rowsAffected);
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

			DbHelperSQL.RunProcedure("GMile_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from GMile ");
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
		public Maticsoft.Model.GMile GetModel(int ID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.GMile model=new Maticsoft.Model.GMile();
			DataSet ds= DbHelperSQL.RunProcedure("GMile_GetModel",parameters,"ds");
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
		public Maticsoft.Model.GMile DataRowToModel(DataRow row)
		{
			Maticsoft.Model.GMile model=new Maticsoft.Model.GMile();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["GName"]!=null)
				{
					model.GName=row["GName"].ToString();
				}
				if(row["GContent"]!=null)
				{
					model.GContent=row["GContent"].ToString();
				}
				if(row["GDate"]!=null && row["GDate"].ToString()!="")
				{
					model.GDate=DateTime.Parse(row["GDate"].ToString());
				}
				if(row["GChannel"]!=null)
				{
					model.GChannel=row["GChannel"].ToString();
				}
				if(row["GState"]!=null && row["GState"].ToString()!="")
				{
					if((row["GState"].ToString()=="1")||(row["GState"].ToString().ToLower()=="true"))
					{
						model.GState=true;
					}
					else
					{
						model.GState=false;
					}
				}
				if(row["avg5"]!=null)
				{
					model.avg5=row["avg5"].ToString();
				}
				if(row["FaceURL"]!=null)
				{
					model.FaceURL=row["FaceURL"].ToString();
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
				if(row["PicUrl"]!=null)
				{
					model.PicUrl=row["PicUrl"].ToString();
				}
				if(row["RouteUrl"]!=null)
				{
					model.RouteUrl=row["RouteUrl"].ToString();
				}
				if(row["MsgType"]!=null && row["MsgType"].ToString()!="")
				{
					model.MsgType=int.Parse(row["MsgType"].ToString());
				}
				if(row["MsgSortID"]!=null && row["MsgSortID"].ToString()!="")
				{
					model.MsgSortID=int.Parse(row["MsgSortID"].ToString());
				}
				if(row["TargetID"]!=null && row["TargetID"].ToString()!="")
				{
					model.TargetID=int.Parse(row["TargetID"].ToString());
				}
				if(row["MsgParentID"]!=null && row["MsgParentID"].ToString()!="")
				{
					model.MsgParentID=int.Parse(row["MsgParentID"].ToString());
				}
				if(row["Level"]!=null && row["Level"].ToString()!="")
				{
					model.Level=int.Parse(row["Level"].ToString());
				}
				if(row["IP"]!=null)
				{
					model.IP=row["IP"].ToString();
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
			strSql.Append("select ID,GName,GContent,GDate,GChannel,GState,avg5,FaceURL,IsLock,PicUrl,RouteUrl,MsgType,MsgSortID,TargetID,MsgParentID,Level,IP ");
			strSql.Append(" FROM GMile ");
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
			strSql.Append(" ID,GName,GContent,GDate,GChannel,GState,avg5,FaceURL,IsLock,PicUrl,RouteUrl,MsgType,MsgSortID,TargetID,MsgParentID,Level,IP ");
			strSql.Append(" FROM GMile ");
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
			strSql.Append("select count(1) FROM GMile ");
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
			strSql.Append(")AS Row, T.*  from GMile T ");
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
			parameters[0].Value = "GMile";
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

