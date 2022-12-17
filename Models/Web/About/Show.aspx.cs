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
namespace Maticsoft.Web.About
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
		Maticsoft.BLL.About bll=new Maticsoft.BLL.About();
		Maticsoft.Model.About model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblDescription.Text=model.Description;
		this.lblInfo.Text=model.Info;
		this.lblPicURL.Text=model.PicURL;
		this.lblavg1.Text=model.avg1.ToString();
		this.lblavg2.Text=model.avg2?"是":"否";
		this.lblavg3.Text=model.avg3;
		this.lblPicURL1.Text=model.PicURL1;
		this.lblPicURL2.Text=model.PicURL2;
		this.lblPicURL3.Text=model.PicURL3;
		this.lblPicURL4.Text=model.PicURL4;
		this.lblPicURL5.Text=model.PicURL5;
		this.lblPicURL6.Text=model.PicURL6;
		this.lblPicURL7.Text=model.PicURL7;
		this.lblPicURL8.Text=model.PicURL8;
		this.lblPicURL9.Text=model.PicURL9;
		this.lblPicURL10.Text=model.PicURL10;
		this.lblPicURL11.Text=model.PicURL11;
		this.lblPicURL12.Text=model.PicURL12;
		this.lblPicURL13.Text=model.PicURL13;
		this.lblWAdress.Text=model.WAdress;
		this.lblAdress.Text=model.Adress;
		this.lblPhone.Text=model.Phone;
		this.lblCPhone.Text=model.CPhone;
		this.lblPostNum.Text=model.PostNum;
		this.lblAPicURL.Text=model.APicURL;
		this.lblavg4.Text=model.avg4;
		this.lblavg5.Text=model.avg5;
		this.lblavg6.Text=model.avg6?"是":"否";
		this.lblJDtxt1.Text=model.JDtxt1;
		this.lblJDtxt2.Text=model.JDtxt2;
		this.lblJDtxt3.Text=model.JDtxt3;
		this.lblJDtxt4.Text=model.JDtxt4;
		this.lblJDtxt5.Text=model.JDtxt5;
		this.lblWXURL1.Text=model.WXURL1;
		this.lblWXURL2.Text=model.WXURL2;
		this.lblWXURL3.Text=model.WXURL3;
		this.lblJDtxt6.Text=model.JDtxt6;
		this.lblJDtxt7.Text=model.JDtxt7;
		this.lblJDtxt8.Text=model.JDtxt8;
		this.lblJDtxt9.Text=model.JDtxt9;
		this.lblJDtxt10.Text=model.JDtxt10;
		this.lblTitle1.Text=model.Title1;
		this.lblTitle2.Text=model.Title2;
		this.lblTitle3.Text=model.Title3;
		this.lblTitle4.Text=model.Title4;
		this.lblTitle5.Text=model.Title5;
		this.lblTitle7.Text=model.Title7;

	}


    }
}
