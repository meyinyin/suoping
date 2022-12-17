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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:About
	/// </summary>
	public partial class About
	{
		public About()
		{}
		#region  Method

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("ID", "About"); 
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

			int result= DbHelperSQL.RunProcedure("About_Exists",parameters,out rowsAffected);
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
		public int Add(Maticsoft.Model.About model)
		{
			int rowsAffected;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@Info", SqlDbType.NText),
					new SqlParameter("@PicURL", SqlDbType.NVarChar,250),
					new SqlParameter("@avg1", SqlDbType.Int,4),
					new SqlParameter("@avg2", SqlDbType.Bit,1),
					new SqlParameter("@avg3", SqlDbType.NVarChar,50),
					new SqlParameter("@PicURL1", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL2", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL3", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL4", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL5", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL6", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL7", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL8", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL9", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL10", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL11", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL12", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL13", SqlDbType.NVarChar,250),
					new SqlParameter("@WAdress", SqlDbType.NVarChar,250),
					new SqlParameter("@Adress", SqlDbType.NVarChar,250),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@CPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@PostNum", SqlDbType.NVarChar,50),
					new SqlParameter("@APicURL", SqlDbType.NVarChar,250),
					new SqlParameter("@avg4", SqlDbType.NVarChar,50),
					new SqlParameter("@avg5", SqlDbType.NVarChar,50),
					new SqlParameter("@avg6", SqlDbType.Bit,1),
					new SqlParameter("@JDtxt1", SqlDbType.NText),
					new SqlParameter("@JDtxt2", SqlDbType.NText),
					new SqlParameter("@JDtxt3", SqlDbType.NText),
					new SqlParameter("@JDtxt4", SqlDbType.NText),
					new SqlParameter("@JDtxt5", SqlDbType.NText),
					new SqlParameter("@WXURL1", SqlDbType.NVarChar,250),
					new SqlParameter("@WXURL2", SqlDbType.NVarChar,250),
					new SqlParameter("@WXURL3", SqlDbType.NVarChar,250),
					new SqlParameter("@JDtxt6", SqlDbType.NText),
					new SqlParameter("@JDtxt7", SqlDbType.NText),
					new SqlParameter("@JDtxt8", SqlDbType.NText),
					new SqlParameter("@JDtxt9", SqlDbType.NText),
					new SqlParameter("@JDtxt10", SqlDbType.NText),
					new SqlParameter("@Title1", SqlDbType.NVarChar,250),
					new SqlParameter("@Title2", SqlDbType.NVarChar,250),
					new SqlParameter("@Title3", SqlDbType.NVarChar,250),
					new SqlParameter("@Title4", SqlDbType.NVarChar,250),
					new SqlParameter("@Title5", SqlDbType.NVarChar,250),
					new SqlParameter("@Title7", SqlDbType.NVarChar,250)};
			parameters[0].Direction = ParameterDirection.Output;
			parameters[1].Value = model.Description;
			parameters[2].Value = model.Info;
			parameters[3].Value = model.PicURL;
			parameters[4].Value = model.avg1;
			parameters[5].Value = model.avg2;
			parameters[6].Value = model.avg3;
			parameters[7].Value = model.PicURL1;
			parameters[8].Value = model.PicURL2;
			parameters[9].Value = model.PicURL3;
			parameters[10].Value = model.PicURL4;
			parameters[11].Value = model.PicURL5;
			parameters[12].Value = model.PicURL6;
			parameters[13].Value = model.PicURL7;
			parameters[14].Value = model.PicURL8;
			parameters[15].Value = model.PicURL9;
			parameters[16].Value = model.PicURL10;
			parameters[17].Value = model.PicURL11;
			parameters[18].Value = model.PicURL12;
			parameters[19].Value = model.PicURL13;
			parameters[20].Value = model.WAdress;
			parameters[21].Value = model.Adress;
			parameters[22].Value = model.Phone;
			parameters[23].Value = model.CPhone;
			parameters[24].Value = model.PostNum;
			parameters[25].Value = model.APicURL;
			parameters[26].Value = model.avg4;
			parameters[27].Value = model.avg5;
			parameters[28].Value = model.avg6;
			parameters[29].Value = model.JDtxt1;
			parameters[30].Value = model.JDtxt2;
			parameters[31].Value = model.JDtxt3;
			parameters[32].Value = model.JDtxt4;
			parameters[33].Value = model.JDtxt5;
			parameters[34].Value = model.WXURL1;
			parameters[35].Value = model.WXURL2;
			parameters[36].Value = model.WXURL3;
			parameters[37].Value = model.JDtxt6;
			parameters[38].Value = model.JDtxt7;
			parameters[39].Value = model.JDtxt8;
			parameters[40].Value = model.JDtxt9;
			parameters[41].Value = model.JDtxt10;
			parameters[42].Value = model.Title1;
			parameters[43].Value = model.Title2;
			parameters[44].Value = model.Title3;
			parameters[45].Value = model.Title4;
			parameters[46].Value = model.Title5;
			parameters[47].Value = model.Title7;

			DbHelperSQL.RunProcedure("About_ADD",parameters,out rowsAffected);
			return (int)parameters[0].Value;
		}

		/// <summary>
		///  更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.About model)
		{
			int rowsAffected=0;
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4),
					new SqlParameter("@Description", SqlDbType.NText),
					new SqlParameter("@Info", SqlDbType.NText),
					new SqlParameter("@PicURL", SqlDbType.NVarChar,250),
					new SqlParameter("@avg1", SqlDbType.Int,4),
					new SqlParameter("@avg2", SqlDbType.Bit,1),
					new SqlParameter("@avg3", SqlDbType.NVarChar,50),
					new SqlParameter("@PicURL1", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL2", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL3", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL4", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL5", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL6", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL7", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL8", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL9", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL10", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL11", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL12", SqlDbType.NVarChar,250),
					new SqlParameter("@PicURL13", SqlDbType.NVarChar,250),
					new SqlParameter("@WAdress", SqlDbType.NVarChar,250),
					new SqlParameter("@Adress", SqlDbType.NVarChar,250),
					new SqlParameter("@Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@CPhone", SqlDbType.NVarChar,50),
					new SqlParameter("@PostNum", SqlDbType.NVarChar,50),
					new SqlParameter("@APicURL", SqlDbType.NVarChar,250),
					new SqlParameter("@avg4", SqlDbType.NVarChar,50),
					new SqlParameter("@avg5", SqlDbType.NVarChar,50),
					new SqlParameter("@avg6", SqlDbType.Bit,1),
					new SqlParameter("@JDtxt1", SqlDbType.NText),
					new SqlParameter("@JDtxt2", SqlDbType.NText),
					new SqlParameter("@JDtxt3", SqlDbType.NText),
					new SqlParameter("@JDtxt4", SqlDbType.NText),
					new SqlParameter("@JDtxt5", SqlDbType.NText),
					new SqlParameter("@WXURL1", SqlDbType.NVarChar,250),
					new SqlParameter("@WXURL2", SqlDbType.NVarChar,250),
					new SqlParameter("@WXURL3", SqlDbType.NVarChar,250),
					new SqlParameter("@JDtxt6", SqlDbType.NText),
					new SqlParameter("@JDtxt7", SqlDbType.NText),
					new SqlParameter("@JDtxt8", SqlDbType.NText),
					new SqlParameter("@JDtxt9", SqlDbType.NText),
					new SqlParameter("@JDtxt10", SqlDbType.NText),
					new SqlParameter("@Title1", SqlDbType.NVarChar,250),
					new SqlParameter("@Title2", SqlDbType.NVarChar,250),
					new SqlParameter("@Title3", SqlDbType.NVarChar,250),
					new SqlParameter("@Title4", SqlDbType.NVarChar,250),
					new SqlParameter("@Title5", SqlDbType.NVarChar,250),
					new SqlParameter("@Title7", SqlDbType.NVarChar,250)};
			parameters[0].Value = model.ID;
			parameters[1].Value = model.Description;
			parameters[2].Value = model.Info;
			parameters[3].Value = model.PicURL;
			parameters[4].Value = model.avg1;
			parameters[5].Value = model.avg2;
			parameters[6].Value = model.avg3;
			parameters[7].Value = model.PicURL1;
			parameters[8].Value = model.PicURL2;
			parameters[9].Value = model.PicURL3;
			parameters[10].Value = model.PicURL4;
			parameters[11].Value = model.PicURL5;
			parameters[12].Value = model.PicURL6;
			parameters[13].Value = model.PicURL7;
			parameters[14].Value = model.PicURL8;
			parameters[15].Value = model.PicURL9;
			parameters[16].Value = model.PicURL10;
			parameters[17].Value = model.PicURL11;
			parameters[18].Value = model.PicURL12;
			parameters[19].Value = model.PicURL13;
			parameters[20].Value = model.WAdress;
			parameters[21].Value = model.Adress;
			parameters[22].Value = model.Phone;
			parameters[23].Value = model.CPhone;
			parameters[24].Value = model.PostNum;
			parameters[25].Value = model.APicURL;
			parameters[26].Value = model.avg4;
			parameters[27].Value = model.avg5;
			parameters[28].Value = model.avg6;
			parameters[29].Value = model.JDtxt1;
			parameters[30].Value = model.JDtxt2;
			parameters[31].Value = model.JDtxt3;
			parameters[32].Value = model.JDtxt4;
			parameters[33].Value = model.JDtxt5;
			parameters[34].Value = model.WXURL1;
			parameters[35].Value = model.WXURL2;
			parameters[36].Value = model.WXURL3;
			parameters[37].Value = model.JDtxt6;
			parameters[38].Value = model.JDtxt7;
			parameters[39].Value = model.JDtxt8;
			parameters[40].Value = model.JDtxt9;
			parameters[41].Value = model.JDtxt10;
			parameters[42].Value = model.Title1;
			parameters[43].Value = model.Title2;
			parameters[44].Value = model.Title3;
			parameters[45].Value = model.Title4;
			parameters[46].Value = model.Title5;
			parameters[47].Value = model.Title7;

			DbHelperSQL.RunProcedure("About_Update",parameters,out rowsAffected);
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

			DbHelperSQL.RunProcedure("About_Delete",parameters,out rowsAffected);
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
			strSql.Append("delete from About ");
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
		public Maticsoft.Model.About GetModel(int ID)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Maticsoft.Model.About model=new Maticsoft.Model.About();
			DataSet ds= DbHelperSQL.RunProcedure("About_GetModel",parameters,"ds");
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
		public Maticsoft.Model.About DataRowToModel(DataRow row)
		{
			Maticsoft.Model.About model=new Maticsoft.Model.About();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["Description"]!=null)
				{
					model.Description=row["Description"].ToString();
				}
				if(row["Info"]!=null)
				{
					model.Info=row["Info"].ToString();
				}
				if(row["PicURL"]!=null)
				{
					model.PicURL=row["PicURL"].ToString();
				}
				if(row["avg1"]!=null && row["avg1"].ToString()!="")
				{
					model.avg1=int.Parse(row["avg1"].ToString());
				}
				if(row["avg2"]!=null && row["avg2"].ToString()!="")
				{
					if((row["avg2"].ToString()=="1")||(row["avg2"].ToString().ToLower()=="true"))
					{
						model.avg2=true;
					}
					else
					{
						model.avg2=false;
					}
				}
				if(row["avg3"]!=null)
				{
					model.avg3=row["avg3"].ToString();
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
				if(row["PicURL6"]!=null)
				{
					model.PicURL6=row["PicURL6"].ToString();
				}
				if(row["PicURL7"]!=null)
				{
					model.PicURL7=row["PicURL7"].ToString();
				}
				if(row["PicURL8"]!=null)
				{
					model.PicURL8=row["PicURL8"].ToString();
				}
				if(row["PicURL9"]!=null)
				{
					model.PicURL9=row["PicURL9"].ToString();
				}
				if(row["PicURL10"]!=null)
				{
					model.PicURL10=row["PicURL10"].ToString();
				}
				if(row["PicURL11"]!=null)
				{
					model.PicURL11=row["PicURL11"].ToString();
				}
				if(row["PicURL12"]!=null)
				{
					model.PicURL12=row["PicURL12"].ToString();
				}
				if(row["PicURL13"]!=null)
				{
					model.PicURL13=row["PicURL13"].ToString();
				}
				if(row["WAdress"]!=null)
				{
					model.WAdress=row["WAdress"].ToString();
				}
				if(row["Adress"]!=null)
				{
					model.Adress=row["Adress"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["CPhone"]!=null)
				{
					model.CPhone=row["CPhone"].ToString();
				}
				if(row["PostNum"]!=null)
				{
					model.PostNum=row["PostNum"].ToString();
				}
				if(row["APicURL"]!=null)
				{
					model.APicURL=row["APicURL"].ToString();
				}
				if(row["avg4"]!=null)
				{
					model.avg4=row["avg4"].ToString();
				}
				if(row["avg5"]!=null)
				{
					model.avg5=row["avg5"].ToString();
				}
				if(row["avg6"]!=null && row["avg6"].ToString()!="")
				{
					if((row["avg6"].ToString()=="1")||(row["avg6"].ToString().ToLower()=="true"))
					{
						model.avg6=true;
					}
					else
					{
						model.avg6=false;
					}
				}
				if(row["JDtxt1"]!=null)
				{
					model.JDtxt1=row["JDtxt1"].ToString();
				}
				if(row["JDtxt2"]!=null)
				{
					model.JDtxt2=row["JDtxt2"].ToString();
				}
				if(row["JDtxt3"]!=null)
				{
					model.JDtxt3=row["JDtxt3"].ToString();
				}
				if(row["JDtxt4"]!=null)
				{
					model.JDtxt4=row["JDtxt4"].ToString();
				}
				if(row["JDtxt5"]!=null)
				{
					model.JDtxt5=row["JDtxt5"].ToString();
				}
				if(row["WXURL1"]!=null)
				{
					model.WXURL1=row["WXURL1"].ToString();
				}
				if(row["WXURL2"]!=null)
				{
					model.WXURL2=row["WXURL2"].ToString();
				}
				if(row["WXURL3"]!=null)
				{
					model.WXURL3=row["WXURL3"].ToString();
				}
				if(row["JDtxt6"]!=null)
				{
					model.JDtxt6=row["JDtxt6"].ToString();
				}
				if(row["JDtxt7"]!=null)
				{
					model.JDtxt7=row["JDtxt7"].ToString();
				}
				if(row["JDtxt8"]!=null)
				{
					model.JDtxt8=row["JDtxt8"].ToString();
				}
				if(row["JDtxt9"]!=null)
				{
					model.JDtxt9=row["JDtxt9"].ToString();
				}
				if(row["JDtxt10"]!=null)
				{
					model.JDtxt10=row["JDtxt10"].ToString();
				}
				if(row["Title1"]!=null)
				{
					model.Title1=row["Title1"].ToString();
				}
				if(row["Title2"]!=null)
				{
					model.Title2=row["Title2"].ToString();
				}
				if(row["Title3"]!=null)
				{
					model.Title3=row["Title3"].ToString();
				}
				if(row["Title4"]!=null)
				{
					model.Title4=row["Title4"].ToString();
				}
				if(row["Title5"]!=null)
				{
					model.Title5=row["Title5"].ToString();
				}
				if(row["Title7"]!=null)
				{
					model.Title7=row["Title7"].ToString();
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
			strSql.Append("select ID,Description,Info,PicURL,avg1,avg2,avg3,PicURL1,PicURL2,PicURL3,PicURL4,PicURL5,PicURL6,PicURL7,PicURL8,PicURL9,PicURL10,PicURL11,PicURL12,PicURL13,WAdress,Adress,Phone,CPhone,PostNum,APicURL,avg4,avg5,avg6,JDtxt1,JDtxt2,JDtxt3,JDtxt4,JDtxt5,WXURL1,WXURL2,WXURL3,JDtxt6,JDtxt7,JDtxt8,JDtxt9,JDtxt10,Title1,Title2,Title3,Title4,Title5,Title7 ");
			strSql.Append(" FROM About ");
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
			strSql.Append(" ID,Description,Info,PicURL,avg1,avg2,avg3,PicURL1,PicURL2,PicURL3,PicURL4,PicURL5,PicURL6,PicURL7,PicURL8,PicURL9,PicURL10,PicURL11,PicURL12,PicURL13,WAdress,Adress,Phone,CPhone,PostNum,APicURL,avg4,avg5,avg6,JDtxt1,JDtxt2,JDtxt3,JDtxt4,JDtxt5,WXURL1,WXURL2,WXURL3,JDtxt6,JDtxt7,JDtxt8,JDtxt9,JDtxt10,Title1,Title2,Title3,Title4,Title5,Title7 ");
			strSql.Append(" FROM About ");
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
			strSql.Append("select count(1) FROM About ");
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
			strSql.Append(")AS Row, T.*  from About T ");
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
			parameters[0].Value = "About";
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

