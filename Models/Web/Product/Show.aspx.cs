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
namespace Maticsoft.Web.Product
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
		Maticsoft.BLL.Product bll=new Maticsoft.BLL.Product();
		Maticsoft.Model.Product model=bll.GetModel(ID);
		this.lblID.Text=model.ID.ToString();
		this.lblPicURL.Text=model.PicURL;
		this.lblPicURL1.Text=model.PicURL1;
		this.lblPicURL2.Text=model.PicURL2;
		this.lblPicURL3.Text=model.PicURL3;
		this.lblPicURL4.Text=model.PicURL4;
		this.lblPicURL5.Text=model.PicURL5;
		this.lblTitle.Text=model.Title;
		this.lblDescription.Text=model.Description;
		this.lblTag.Text=model.Tag;
		this.lblInfo.Text=model.Info;
		this.lblIsHot.Text=model.IsHot?"是":"否";
		this.lblIsTop.Text=model.IsTop?"是":"否";
		this.lblIsTJ.Text=model.IsTJ?"是":"否";
		this.lblKeyWord.Text=model.KeyWord;
		this.lblSortID.Text=model.SortID.ToString();
		this.lblVideoURL.Text=model.VideoURL;
		this.lblWeight.Text=model.Weight.ToString();
		this.lblReadCount.Text=model.ReadCount.ToString();
		this.lblIsLock.Text=model.IsLock?"是":"否";
		this.lblIsDelete.Text=model.IsDelete?"是":"否";
		this.lblTitle2.Text=model.Title2;
		this.lblavg1.Text=model.avg1.ToString();
		this.lblavg2.Text=model.avg2;
		this.lblavg3.Text=model.avg3?"是":"否";
		this.lblAddDateTime.Text=model.AddDateTime.ToString();

	}


    }
}
