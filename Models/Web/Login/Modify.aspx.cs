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
using LTP.Accounts.Bus;
namespace Maticsoft.Web.Login
{
    public partial class Modify : Page
    {       

        		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					int ID=(Convert.ToInt32(Request.Params["id"]));
					ShowInfo(ID);
				}
			}
		}
			
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.Login bll=new Maticsoft.BLL.Login();
		Maticsoft.Model.Login model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtLName.Text=model.LName;
		this.txtLPwd.Text=model.LPwd;
		this.txtLever.Text=model.Lever.ToString();
		this.chkavg.Checked=model.avg;
		this.txtavg2.Text=model.avg2;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtLName.Text.Trim().Length==0)
			{
				strErr+="LName不能为空！\\n";	
			}
			if(this.txtLPwd.Text.Trim().Length==0)
			{
				strErr+="LPwd不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtLever.Text))
			{
				strErr+="登录级别格式错误！\\n";	
			}
			if(this.txtavg2.Text.Trim().Length==0)
			{
				strErr+="avg2不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string LName=this.txtLName.Text;
			string LPwd=this.txtLPwd.Text;
			int Lever=int.Parse(this.txtLever.Text);
			bool avg=this.chkavg.Checked;
			string avg2=this.txtavg2.Text;


			Maticsoft.Model.Login model=new Maticsoft.Model.Login();
			model.ID=ID;
			model.LName=LName;
			model.LPwd=LPwd;
			model.Lever=Lever;
			model.avg=avg;
			model.avg2=avg2;

			Maticsoft.BLL.Login bll=new Maticsoft.BLL.Login();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
