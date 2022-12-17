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
namespace Maticsoft.Web.News
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
		Maticsoft.BLL.News bll=new Maticsoft.BLL.News();
		Maticsoft.Model.News model=bll.GetModel(ID);
		this.txtAddDateTime.Text=model.AddDateTime.ToString();
		this.txtAuthor.Text=model.Author;
		this.txtContent.Text=model.Content;
		this.txtDescription.Text=model.Description;
		this.txtFileURL.Text=model.FileURL;
		this.txtFromWhere.Text=model.FromWhere;
		this.lblID.Text=model.ID.ToString();
		this.txtInfo.Text=model.Info;
		this.chkIsDelete.Checked=model.IsDelete;
		this.chkIsLock.Checked=model.IsLock;
		this.chkIsTJ.Checked=model.IsTJ;
		this.chkIsHot.Checked=model.IsHot;
		this.chkIsTop.Checked=model.IsTop;
		this.txtKeyWord.Text=model.KeyWord;
		this.txtPicURL.Text=model.PicURL;
		this.txtReadCount.Text=model.ReadCount.ToString();
		this.txtSortID.Text=model.SortID.ToString();
		this.txtTag.Text=model.Tag;
		this.txtTitle.Text=model.Title;
		this.txtURL.Text=model.URL;
		this.txtVideoURL.Text=model.VideoURL;
		this.txtWeight.Text=model.Weight.ToString();
		this.txtSiteID.Text=model.SiteID.ToString();
		this.txtUninoID.Text=model.UninoID.ToString();
		this.txtUserID.Text=model.UserID.ToString();
		this.chkIsPic.Checked=model.IsPic;
		this.chkIsStore.Checked=model.IsStore;
		this.txtDingNum.Text=model.DingNum.ToString();
		this.txtZhuangNum.Text=model.ZhuangNum.ToString();
		this.txtZhiChiNum.Text=model.ZhiChiNum.ToString();
		this.txtSCNum.Text=model.SCNum.ToString();
		this.chkHasAddress.Checked=model.HasAddress;
		this.txtAddressName.Text=model.AddressName;
		this.txtAddress.Text=model.Address;
		this.txtAddressX.Text=model.AddressX.ToString();
		this.txtAddressY.Text=model.AddressY.ToString();
		this.txtShopMenberID.Text=model.ShopMenberID.ToString();
		this.txtShareTxt.Text=model.ShareTxt;
		this.txtSharePicID.Text=model.SharePicID.ToString();
		this.txtShareMainPicUrl.Text=model.ShareMainPicUrl;
		this.txtEditDateTime.Text=model.EditDateTime.ToString();

	}

		public void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsDateTime(txtAddDateTime.Text))
			{
				strErr+="文章添加时间格式错误！\\n";	
			}
			if(this.txtAuthor.Text.Trim().Length==0)
			{
				strErr+="作者不能为空！\\n";	
			}
			if(this.txtContent.Text.Trim().Length==0)
			{
				strErr+="内容不能为空！\\n";	
			}
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="描述不能为空！\\n";	
			}
			if(this.txtFileURL.Text.Trim().Length==0)
			{
				strErr+="FileURL不能为空！\\n";	
			}
			if(this.txtFromWhere.Text.Trim().Length==0)
			{
				strErr+="来源不能为空！\\n";	
			}
			if(this.txtInfo.Text.Trim().Length==0)
			{
				strErr+="Info不能为空！\\n";	
			}
			if(this.txtKeyWord.Text.Trim().Length==0)
			{
				strErr+="关键字不能为空！\\n";	
			}
			if(this.txtPicURL.Text.Trim().Length==0)
			{
				strErr+="主图地址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtReadCount.Text))
			{
				strErr+="阅读量格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSortID.Text))
			{
				strErr+="分类ID格式错误！\\n";	
			}
			if(this.txtTag.Text.Trim().Length==0)
			{
				strErr+="标签不能为空！\\n";	
			}
			if(this.txtTitle.Text.Trim().Length==0)
			{
				strErr+="标题不能为空！\\n";	
			}
			if(this.txtURL.Text.Trim().Length==0)
			{
				strErr+="URL不能为空！\\n";	
			}
			if(this.txtVideoURL.Text.Trim().Length==0)
			{
				strErr+="视频地址不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtWeight.Text))
			{
				strErr+="权重格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSiteID.Text))
			{
				strErr+="站点格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUninoID.Text))
			{
				strErr+="UninoID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtUserID.Text))
			{
				strErr+="UserID格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtDingNum.Text))
			{
				strErr+="DingNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtZhuangNum.Text))
			{
				strErr+="ZhuangNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtZhiChiNum.Text))
			{
				strErr+="ZhiChiNum格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtSCNum.Text))
			{
				strErr+="SCNum格式错误！\\n";	
			}
			if(this.txtAddressName.Text.Trim().Length==0)
			{
				strErr+="AddressName不能为空！\\n";	
			}
			if(this.txtAddress.Text.Trim().Length==0)
			{
				strErr+="地址不能为空！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAddressX.Text))
			{
				strErr+="AddressX格式错误！\\n";	
			}
			if(!PageValidate.IsDecimal(txtAddressY.Text))
			{
				strErr+="AddressY格式错误！\\n";	
			}
			if(!PageValidate.IsNumber(txtShopMenberID.Text))
			{
				strErr+="ShopMenberID格式错误！\\n";	
			}
			if(this.txtShareTxt.Text.Trim().Length==0)
			{
				strErr+="ShareTxt不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtSharePicID.Text))
			{
				strErr+="SharePicID格式错误！\\n";	
			}
			if(this.txtShareMainPicUrl.Text.Trim().Length==0)
			{
				strErr+="ShareMainPicUrl不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtEditDateTime.Text))
			{
				strErr+="EditDateTime格式错误！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			DateTime AddDateTime=DateTime.Parse(this.txtAddDateTime.Text);
			string Author=this.txtAuthor.Text;
			string Content=this.txtContent.Text;
			string Description=this.txtDescription.Text;
			string FileURL=this.txtFileURL.Text;
			string FromWhere=this.txtFromWhere.Text;
			int ID=int.Parse(this.lblID.Text);
			string Info=this.txtInfo.Text;
			bool IsDelete=this.chkIsDelete.Checked;
			bool IsLock=this.chkIsLock.Checked;
			bool IsTJ=this.chkIsTJ.Checked;
			bool IsHot=this.chkIsHot.Checked;
			bool IsTop=this.chkIsTop.Checked;
			string KeyWord=this.txtKeyWord.Text;
			string PicURL=this.txtPicURL.Text;
			int ReadCount=int.Parse(this.txtReadCount.Text);
			int SortID=int.Parse(this.txtSortID.Text);
			string Tag=this.txtTag.Text;
			string Title=this.txtTitle.Text;
			string URL=this.txtURL.Text;
			string VideoURL=this.txtVideoURL.Text;
			int Weight=int.Parse(this.txtWeight.Text);
			int SiteID=int.Parse(this.txtSiteID.Text);
			int UninoID=int.Parse(this.txtUninoID.Text);
			int UserID=int.Parse(this.txtUserID.Text);
			bool IsPic=this.chkIsPic.Checked;
			bool IsStore=this.chkIsStore.Checked;
			int DingNum=int.Parse(this.txtDingNum.Text);
			int ZhuangNum=int.Parse(this.txtZhuangNum.Text);
			int ZhiChiNum=int.Parse(this.txtZhiChiNum.Text);
			int SCNum=int.Parse(this.txtSCNum.Text);
			bool HasAddress=this.chkHasAddress.Checked;
			string AddressName=this.txtAddressName.Text;
			string Address=this.txtAddress.Text;
			decimal AddressX=decimal.Parse(this.txtAddressX.Text);
			decimal AddressY=decimal.Parse(this.txtAddressY.Text);
			int ShopMenberID=int.Parse(this.txtShopMenberID.Text);
			string ShareTxt=this.txtShareTxt.Text;
			int SharePicID=int.Parse(this.txtSharePicID.Text);
			string ShareMainPicUrl=this.txtShareMainPicUrl.Text;
			DateTime EditDateTime=DateTime.Parse(this.txtEditDateTime.Text);


			Maticsoft.Model.News model=new Maticsoft.Model.News();
			model.AddDateTime=AddDateTime;
			model.Author=Author;
			model.Content=Content;
			model.Description=Description;
			model.FileURL=FileURL;
			model.FromWhere=FromWhere;
			model.ID=ID;
			model.Info=Info;
			model.IsDelete=IsDelete;
			model.IsLock=IsLock;
			model.IsTJ=IsTJ;
			model.IsHot=IsHot;
			model.IsTop=IsTop;
			model.KeyWord=KeyWord;
			model.PicURL=PicURL;
			model.ReadCount=ReadCount;
			model.SortID=SortID;
			model.Tag=Tag;
			model.Title=Title;
			model.URL=URL;
			model.VideoURL=VideoURL;
			model.Weight=Weight;
			model.SiteID=SiteID;
			model.UninoID=UninoID;
			model.UserID=UserID;
			model.IsPic=IsPic;
			model.IsStore=IsStore;
			model.DingNum=DingNum;
			model.ZhuangNum=ZhuangNum;
			model.ZhiChiNum=ZhiChiNum;
			model.SCNum=SCNum;
			model.HasAddress=HasAddress;
			model.AddressName=AddressName;
			model.Address=Address;
			model.AddressX=AddressX;
			model.AddressY=AddressY;
			model.ShopMenberID=ShopMenberID;
			model.ShareTxt=ShareTxt;
			model.SharePicID=SharePicID;
			model.ShareMainPicUrl=ShareMainPicUrl;
			model.EditDateTime=EditDateTime;

			Maticsoft.BLL.News bll=new Maticsoft.BLL.News();
			bll.Update(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","list.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
