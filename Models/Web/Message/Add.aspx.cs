using System;
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
//using LTP.Accounts.Bus;
namespace Maticsoft.Web.Message
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtMName.Text.Trim().Length==0)
			{
				strErr+="留言姓名不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMPhone.Text))
			{
				strErr+="留言电话格式错误！\\n";	
			}
			if(this.txtMEmail.Text.Trim().Length==0)
			{
				strErr+="留言邮箱不能为空！\\n";	
			}
			if(this.txtMAdress.Text.Trim().Length==0)
			{
				strErr+="留言地址不能为空！\\n";	
			}
			if(this.txtMContent.Text.Trim().Length==0)
			{
				strErr+="留言内容不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtMDate.Text))
			{
				strErr+="留言时间格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtavg1.Text))
			{
				strErr+="avg1格式错误！\\n";	
			}
			if(this.txtavg2.Text.Trim().Length==0)
			{
				strErr+="avg2不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtavg3.Text))
			{
				strErr+="avg3格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string MName=this.txtMName.Text;
			int MPhone=int.Parse(this.txtMPhone.Text);
			string MEmail=this.txtMEmail.Text;
			string MAdress=this.txtMAdress.Text;
			string MContent=this.txtMContent.Text;
			DateTime MDate=DateTime.Parse(this.txtMDate.Text);
			bool MState=this.chkMState.Checked;
			int avg1=int.Parse(this.txtavg1.Text);
			string avg2=this.txtavg2.Text;
			int avg3=int.Parse(this.txtavg3.Text);

			Maticsoft.Model.Message model=new Maticsoft.Model.Message();
			model.MName=MName;
			model.MPhone=MPhone;
			model.MEmail=MEmail;
			model.MAdress=MAdress;
			model.MContent=MContent;
			model.MDate=MDate;
			model.MState=MState;
			model.avg1=avg1;
			model.avg2=avg2;
			model.avg3=avg3;

			Maticsoft.BLL.Message bll=new Maticsoft.BLL.Message();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
