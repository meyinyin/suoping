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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Message
	/// </summary>
	public partial class Message
	{
		public Message()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "Message"); 
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

			int result= DbHelperSQL.RunProcedure("Message_Exists",parameters,out rowsAffected);
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
		public int Add(Maticsoft.Model.Message model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MName", SqlDbType.NVarChar,50),
					new SqlParameter("@MPhone", SqlDbType.Int,4),
					new SqlParameter("@MEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@MAdress", SqlDbType.NVarChar,250),
					new SqlParameter("@MContent", SqlDbType.NText),
					new SqlParameter("@MDate", SqlDbType.DateTime),
					new SqlParameter("@MState", SqlDbType.Bit,1),
					new SqlParameter("@avg1", SqlDbType.Int,4),
					new SqlParameter("@avg2", SqlDbType.NVarChar,50),
					new SqlParameter("@avg3", SqlDbType.Int,4)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.MName;
			parameters[2].Value = model.MPhone;
			parameters[3].Value = model.MEmail;
			parameters[4].Value = model.MAdress;
			parameters[5].Value = model.MContent;
			parameters[6].Value = model.MDate;
			parameters[7].Value = model.MState;
			parameters[8].Value = model.avg1;
			parameters[9].Value = model.avg2;
			parameters[10].Value = model.avg3;

			DbHelperSQL.RunProcedure("Message_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Message model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@MName", SqlDbType.NVarChar,50),
					new SqlParameter("@MPhone", SqlDbType.Int,4),
					new SqlParameter("@MEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@MAdress", SqlDbType.NVarChar,250),
					new SqlParameter("@MContent", SqlDbType.NText),
					new SqlParameter("@MDate", SqlDbType.DateTime),
					new SqlParameter("@MState", SqlDbType.Bit,1),
					new SqlParameter("@avg1", SqlDbType.Int,4),
					new SqlParameter("@avg2", SqlDbType.NVarChar,50),
					new SqlParameter("@avg3", SqlDbType.Int,4)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.MName;
			parameters[2].Value = model.MPhone;
			parameters[3].Value = model.MEmail;
			parameters[4].Value = model.MAdress;
			parameters[5].Value = model.MContent;
			parameters[6].Value = model.MDate;
			parameters[7].Value = model.MState;
			parameters[8].Value = model.avg1;
			parameters[9].Value = model.avg2;
			parameters[10].Value = model.avg3;

			DbHelperSQL.RunProcedure("Message_Update",parameters,out rowsAffected);
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

			DbHelperSQL.RunProcedure("Message_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from Message ");
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
		public Maticsoft.Model.Message GetModel(int ID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.Message model=new Maticsoft.Model.Message();
			DataSet ds= DbHelperSQL.RunProcedure("Message_GetModel",parameters,"ds");
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
		public Maticsoft.Model.Message DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Message model=new Maticsoft.Model.Message();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["MName"]!=null)
				{
					model.MName=row["MName"].ToString();
				}
				if(row["MPhone"]!=null && row["MPhone"].ToString()!="")
				{
					model.MPhone=int.Parse(row["MPhone"].ToString());
				}
				if(row["MEmail"]!=null)
				{
					model.MEmail=row["MEmail"].ToString();
				}
				if(row["MAdress"]!=null)
				{
					model.MAdress=row["MAdress"].ToString();
				}
				if(row["MContent"]!=null)
				{
					model.MContent=row["MContent"].ToString();
				}
				if(row["MDate"]!=null && row["MDate"].ToString()!="")
				{
					model.MDate=DateTime.Parse(row["MDate"].ToString());
				}
				if(row["MState"]!=null && row["MState"].ToString()!="")
				{
					if((row["MState"].ToString()=="1")||(row["MState"].ToString().ToLower()=="true"))
					{
						model.MState=true;
					}
					else
					{
						model.MState=false;
					}
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
					model.avg3=int.Parse(row["avg3"].ToString());
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
			strSql.Append("select ID,MName,MPhone,MEmail,MAdress,MContent,MDate,MState,avg1,avg2,avg3 ");
			strSql.Append(" FROM Message ");
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
			strSql.Append(" ID,MName,MPhone,MEmail,MAdress,MContent,MDate,MState,avg1,avg2,avg3 ");
			strSql.Append(" FROM Message ");
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
			strSql.Append("select count(1) FROM Message ");
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
			strSql.Append(")AS Row, T.*  from Message T ");
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
			parameters[0].Value = "Message";
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

