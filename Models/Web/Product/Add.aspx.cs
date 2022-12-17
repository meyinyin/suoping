﻿using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using Maticsoft.Common;
using LTP.Accounts.Bus;
namespace Maticsoft.Web.Product
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtPicURL.Text.Trim().Length==0)
			{
				strErr+="产品主图不能为空！\\n";	
			}
			if(this.txtPicURL1.Text.Trim().Length==0)
			{
				strErr+="PicURL1不能为空！\\n";	
			}
			if(this.txtPicURL2.Text.Trim().Length==0)
			{
				strErr+="PicURL2不能为空！\\n";	
			}
			if(this.txtPicURL3.Text.Trim().Length==0)
			{
				strErr+="PicURL3不能为空！\\n";	
			}
			if(this.txtPicURL4.Text.Trim().Length==0)
			{
				strErr+="PicURL4不能为空！\\n";	
			}
			if(this.txtPicURL5.Text.Trim().Length==0)
			{
				strErr+="PicURL5不能为空！\\n";	
			}
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="产品标题不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="产品描述不能为空！\\n";	
			}
			if(this.txtTag.Text.Trim().Length==0)
			{
				strErr+="产品标签不能为空！\\n";	
			}
			if(this.txtInfo.Text.Trim().Length==0)
			{
				strErr+="Info不能为空！\\n";	
			}
			if(this.txtKeyWord.Text.Trim().Length==0)
			{
				strErr+="KeyWord不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSortID.Text))
			{
				strErr+="SortID格式错误！\\n";	
			}
			if(this.txtVideoURL.Text.Trim().Length==0)
			{
				strErr+="VideoURL不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtWeight.Text))
			{
				strErr+="Weight格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtReadCount.Text))
			{
				strErr+="ReadCount格式错误！\\n";	
			}
			if(this.txtTitle2.Text.Trim().Length==0)
			{
				strErr+="Title2不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtavg1.Text))
			{
				strErr+="avg1格式错误！\\n";	
			}
			if(this.txtavg2.Text.Trim().Length==0)
			{
				strErr+="avg2不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtAddDateTime.Text))
			{
				strErr+="AddDateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string PicURL=this.txtPicURL.Text;
			string PicURL1=this.txtPicURL1.Text;
			string PicURL2=this.txtPicURL2.Text;
			string PicURL3=this.txtPicURL3.Text;
			string PicURL4=this.txtPicURL4.Text;
			string PicURL5=this.txtPicURL5.Text;
			string Title=this.txtTitle.Text;
			string Description=this.txtDescription.Text;
			string Tag=this.txtTag.Text;
			string Info=this.txtInfo.Text;
			bool IsHot=this.chkIsHot.Checked;
			bool IsTop=this.chkIsTop.Checked;
			bool IsTJ=this.chkIsTJ.Checked;
			string KeyWord=this.txtKeyWord.Text;
			int SortID=int.Parse(this.txtSortID.Text);
			string VideoURL=this.txtVideoURL.Text;
			int Weight=int.Parse(this.txtWeight.Text);
			int ReadCount=int.Parse(this.txtReadCount.Text);
			bool IsLock=this.chkIsLock.Checked;
			bool IsDelete=this.chkIsDelete.Checked;
			string Title2=this.txtTitle2.Text;
			int avg1=int.Parse(this.txtavg1.Text);
			string avg2=this.txtavg2.Text;
			bool avg3=this.chkavg3.Checked;
			DateTime AddDateTime=DateTime.Parse(this.txtAddDateTime.Text);

			Maticsoft.Model.Product model=new Maticsoft.Model.Product();
			model.PicURL=PicURL;
			model.PicURL1=PicURL1;
			model.PicURL2=PicURL2;
			model.PicURL3=PicURL3;
			model.PicURL4=PicURL4;
			model.PicURL5=PicURL5;
			model.Title=Title;
			model.Description=Description;
			model.Tag=Tag;
			model.Info=Info;
			model.IsHot=IsHot;
			model.IsTop=IsTop;
			model.IsTJ=IsTJ;
			model.KeyWord=KeyWord;
			model.SortID=SortID;
			model.VideoURL=VideoURL;
			model.Weight=Weight;
			model.ReadCount=ReadCount;
			model.IsLock=IsLock;
			model.IsDelete=IsDelete;
			model.Title2=Title2;
			model.avg1=avg1;
			model.avg2=avg2;
			model.avg3=avg3;
			model.AddDateTime=AddDateTime;

			Maticsoft.BLL.Product bll=new Maticsoft.BLL.Product();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
