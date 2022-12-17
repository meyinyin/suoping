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
namespace Maticsoft.Web.Message
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
		Maticsoft.BLL.Message bll=new Maticsoft.BLL.Message();
		Maticsoft.Model.Message model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblMName.Text=model.MName;
		this.lblMPhone.Text=model.MPhone.ToString();
		this.lblMEmail.Text=model.MEmail;
		this.lblMAdress.Text=model.MAdress;
		this.lblMContent.Text=model.MContent;
		this.lblMDate.Text=model.MDate.ToString();
		this.lblMState.Text=model.MState?"是":"否";
		this.lblavg1.Text=model.avg1.ToString();
		this.lblavg2.Text=model.avg2;
		this.lblavg3.Text=model.avg3.ToString();

	}


    }
}
