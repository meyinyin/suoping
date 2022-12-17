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
namespace Maticsoft.Web.SortType
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
		Maticsoft.BLL.SortType bll=new Maticsoft.BLL.SortType();
		Maticsoft.Model.SortType model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtName.Text=model.Name;
		this.txtUrl.Text=model.Url;
		this.chkIsLock.Checked=model.IsLock;
		this.txtSiteID.Text=model.SiteID.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtName.Text.Trim().Length==0)
			{
				strErr+="Name不能为空！\\n";	
			}
			if(this.txtUrl.Text.Trim().Length==0)
			{
				strErr+="Url不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="SiteID格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string Name=this.txtName.Text;
			string Url=this.txtUrl.Text;
			bool IsLock=this.chkIsLock.Checked;
			int SiteID=int.Parse(this.txtSiteID.Text);


			Maticsoft.Model.SortType model=new Maticsoft.Model.SortType();
			model.ID=ID;
			model.Name=Name;
			model.Url=Url;
			model.IsLock=IsLock;
			model.SiteID=SiteID;

			Maticsoft.BLL.SortType bll=new Maticsoft.BLL.SortType();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
