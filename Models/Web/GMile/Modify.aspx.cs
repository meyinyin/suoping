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
namespace Maticsoft.Web.GMile
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
		Maticsoft.BLL.GMile bll=new Maticsoft.BLL.GMile();
		Maticsoft.Model.GMile model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.txtGName.Text=model.GName;
		this.txtGContent.Text=model.GContent;
		this.txtGDate.Text=model.GDate.ToString();
		this.txtGChannel.Text=model.GChannel;
		this.chkGState.Checked=model.GState;
		this.txtavg5.Text=model.avg5;
		this.txtFaceURL.Text=model.FaceURL;
		this.chkIsLock.Checked=model.IsLock;
		this.txtPicUrl.Text=model.PicUrl;
		this.txtRouteUrl.Text=model.RouteUrl;
		this.txtMsgType.Text=model.MsgType.ToString();
		this.txtMsgSortID.Text=model.MsgSortID.ToString();
		this.txtTargetID.Text=model.TargetID.ToString();
		this.txtMsgParentID.Text=model.MsgParentID.ToString();
		this.txtLevel.Text=model.Level.ToString();
		this.txtIP.Text=model.IP;

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtGName.Text.Trim().Length==0)
			{
				strErr+="GName不能为空！\\n";	
			}
			if(this.txtGContent.Text.Trim().Length==0)
			{
				strErr+="GContent不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtGDate.Text))
			{
				strErr+="GDate格式错误！\\n";	
			}
			if(this.txtGChannel.Text.Trim().Length==0)
			{
				strErr+="GChannel不能为空！\\n";	
			}
			if(this.txtavg5.Text.Trim().Length==0)
			{
				strErr+="avg5不能为空！\\n";	
			}
			if(this.txtFaceURL.Text.Trim().Length==0)
			{
				strErr+="FaceURL不能为空！\\n";	
			}
			if(this.txtPicUrl.Text.Trim().Length==0)
			{
				strErr+="PicUrl不能为空！\\n";	
			}
			if(this.txtRouteUrl.Text.Trim().Length==0)
			{
				strErr+="RouteUrl不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtMsgType.Text))
			{
				strErr+="MsgType格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMsgSortID.Text))
			{
				strErr+="MsgSortID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtTargetID.Text))
			{
				strErr+="TargetID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtMsgParentID.Text))
			{
				strErr+="MsgParentID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtLevel.Text))
			{
				strErr+="Level格式错误！\\n";	
			}
			if(this.txtIP.Text.Trim().Length==0)
			{
				strErr+="IP不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ID=int.Parse(this.lblID.Text);
			string GName=this.txtGName.Text;
			string GContent=this.txtGContent.Text;
			DateTime GDate=DateTime.Parse(this.txtGDate.Text);
			string GChannel=this.txtGChannel.Text;
			bool GState=this.chkGState.Checked;
			string avg5=this.txtavg5.Text;
			string FaceURL=this.txtFaceURL.Text;
			bool IsLock=this.chkIsLock.Checked;
			string PicUrl=this.txtPicUrl.Text;
			string RouteUrl=this.txtRouteUrl.Text;
			int MsgType=int.Parse(this.txtMsgType.Text);
			int MsgSortID=int.Parse(this.txtMsgSortID.Text);
			int TargetID=int.Parse(this.txtTargetID.Text);
			int MsgParentID=int.Parse(this.txtMsgParentID.Text);
			int Level=int.Parse(this.txtLevel.Text);
			string IP=this.txtIP.Text;


			Maticsoft.Model.GMile model=new Maticsoft.Model.GMile();
			model.ID=ID;
			model.GName=GName;
			model.GContent=GContent;
			model.GDate=GDate;
			model.GChannel=GChannel;
			model.GState=GState;
			model.avg5=avg5;
			model.FaceURL=FaceURL;
			model.IsLock=IsLock;
			model.PicUrl=PicUrl;
			model.RouteUrl=RouteUrl;
			model.MsgType=MsgType;
			model.MsgSortID=MsgSortID;
			model.TargetID=TargetID;
			model.MsgParentID=MsgParentID;
			model.Level=Level;
			model.IP=IP;

			Maticsoft.BLL.GMile bll=new Maticsoft.BLL.GMile();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
