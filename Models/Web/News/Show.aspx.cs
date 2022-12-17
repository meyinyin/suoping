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
namespace Maticsoft.Web.News
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
		Maticsoft.BLL.News bll=new Maticsoft.BLL.News();
		Maticsoft.Model.News model=bll.GetModel(ID);
		this.lblAddDateTime.Text=model.AddDateTime.ToString();
		this.lblAuthor.Text=model.Author;
		this.lblContent.Text=model.Content;
		this.lblDescription.Text=model.Description;
		this.lblFileURL.Text=model.FileURL;
		this.lblFromWhere.Text=model.FromWhere;
		this.lblID.Text=model.ID.ToString();
		this.lblInfo.Text=model.Info;
		this.lblIsDelete.Text=model.IsDelete?"是":"否";
		this.lblIsLock.Text=model.IsLock?"是":"否";
		this.lblIsTJ.Text=model.IsTJ?"是":"否";
		this.lblIsHot.Text=model.IsHot?"是":"否";
		this.lblIsTop.Text=model.IsTop?"是":"否";
		this.lblKeyWord.Text=model.KeyWord;
		this.lblPicURL.Text=model.PicURL;
		this.lblReadCount.Text=model.ReadCount.ToString();
		this.lblSortID.Text=model.SortID.ToString();
		this.lblTag.Text=model.Tag;
		this.lblTitle.Text=model.Title;
		this.lblURL.Text=model.URL;
		this.lblVideoURL.Text=model.VideoURL;
		this.lblWeight.Text=model.Weight.ToString();
		this.lblSiteID.Text=model.SiteID.ToString();
		this.lblUninoID.Text=model.UninoID.ToString();
		this.lblUserID.Text=model.UserID.ToString();
		this.lblIsPic.Text=model.IsPic?"是":"否";
		this.lblIsStore.Text=model.IsStore?"是":"否";
		this.lblDingNum.Text=model.DingNum.ToString();
		this.lblZhuangNum.Text=model.ZhuangNum.ToString();
		this.lblZhiChiNum.Text=model.ZhiChiNum.ToString();
		this.lblSCNum.Text=model.SCNum.ToString();
		this.lblHasAddress.Text=model.HasAddress?"是":"否";
		this.lblAddressName.Text=model.AddressName;
		this.lblAddress.Text=model.Address;
		this.lblAddressX.Text=model.AddressX.ToString();
		this.lblAddressY.Text=model.AddressY.ToString();
		this.lblShopMenberID.Text=model.ShopMenberID.ToString();
		this.lblShareTxt.Text=model.ShareTxt;
		this.lblSharePicID.Text=model.SharePicID.ToString();
		this.lblShareMainPicUrl.Text=model.ShareMainPicUrl;
		this.lblEditDateTime.Text=model.EditDateTime.ToString();

	}


    }
}
