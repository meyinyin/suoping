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
namespace Maticsoft.Web.GMile
{
    public partial class Show : Page
    {        
        		public string strid=""; 
		protected void Page_Load(object sender, EventArgs e)
		{
			if (!Page.IsPostBack)
			{
				if (Request.Params["id"] != null && Request.Params["id"].Trim() != "")
				{
					strid = Request.Params["id"];
					int ID=(Convert.ToInt32(strid));
					ShowInfo(ID);
				}
			}
		}
		
	private void ShowInfo(int ID)
	{
		Maticsoft.BLL.GMile bll=new Maticsoft.BLL.GMile();
		Maticsoft.Model.GMile model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblGName.Text=model.GName;
		this.lblGContent.Text=model.GContent;
		this.lblGDate.Text=model.GDate.ToString();
		this.lblGChannel.Text=model.GChannel;
		this.lblGState.Text=model.GState?"是":"否";
		this.lblavg5.Text=model.avg5;
		this.lblFaceURL.Text=model.FaceURL;
		this.lblIsLock.Text=model.IsLock?"是":"否";
		this.lblPicUrl.Text=model.PicUrl;
		this.lblRouteUrl.Text=model.RouteUrl;
		this.lblMsgType.Text=model.MsgType.ToString();
		this.lblMsgSortID.Text=model.MsgSortID.ToString();
		this.lblTargetID.Text=model.TargetID.ToString();
		this.lblMsgParentID.Text=model.MsgParentID.ToString();
		this.lblLevel.Text=model.Level.ToString();
		this.lblIP.Text=model.IP;

	}


    }
}
