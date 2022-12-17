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
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
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
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
