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
namespace Maticsoft.Web.About
{
    public partial class Add : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
                       
        }

        		protected void btnSave_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtDescription.Text.Trim().Length==0)
			{
				strErr+="Description不能为空！\\n";	
			}
			if(this.txtInfo.Text.Trim().Length==0)
			{
				strErr+="Info不能为空！\\n";	
			}
			if(this.txtPicURL.Text.Trim().Length==0)
			{
				strErr+="关于我们图片不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtavg1.Text))
			{
				strErr+="avg1格式错误！\\n";	
			}
			if(this.txtavg3.Text.Trim().Length==0)
			{
				strErr+="avg3不能为空！\\n";	
			}
			if(this.txtPicURL1.Text.Trim().Length==0)
			{
				strErr+="基地展示图片1不能为空！\\n";	
			}
			if(this.txtPicURL2.Text.Trim().Length==0)
			{
				strErr+="基地展示图片2不能为空！\\n";	
			}
			if(this.txtPicURL3.Text.Trim().Length==0)
			{
				strErr+="基地展示图片3不能为空！\\n";	
			}
			if(this.txtPicURL4.Text.Trim().Length==0)
			{
				strErr+="基地展示图片4不能为空！\\n";	
			}
			if(this.txtPicURL5.Text.Trim().Length==0)
			{
				strErr+="基地展示图片5不能为空！\\n";	
			}
			if(this.txtPicURL6.Text.Trim().Length==0)
			{
				strErr+="荣誉资质1不能为空！\\n";	
			}
			if(this.txtPicURL7.Text.Trim().Length==0)
			{
				strErr+="荣誉资质2不能为空！\\n";	
			}
			if(this.txtPicURL8.Text.Trim().Length==0)
			{
				strErr+="荣誉资质3不能为空！\\n";	
			}
			if(this.txtPicURL9.Text.Trim().Length==0)
			{
				strErr+="荣誉资质4不能为空！\\n";	
			}
			if(this.txtPicURL10.Text.Trim().Length==0)
			{
				strErr+="荣誉资质5不能为空！\\n";	
			}
			if(this.txtPicURL11.Text.Trim().Length==0)
			{
				strErr+="荣誉资质6不能为空！\\n";	
			}
			if(this.txtPicURL12.Text.Trim().Length==0)
			{
				strErr+="荣誉资质7不能为空！\\n";	
			}
			if(this.txtPicURL13.Text.Trim().Length==0)
			{
				strErr+="荣誉资质8不能为空！\\n";	
			}
			if(this.txtWAdress.Text.Trim().Length==0)
			{
				strErr+="WAdress不能为空！\\n";	
			}
			if(this.txtAdress.Text.Trim().Length==0)
			{
				strErr+="Adress不能为空！\\n";	
			}
			if(this.txtPhone.Text.Trim().Length==0)
			{
				strErr+="Phone不能为空！\\n";	
			}
			if(this.txtCPhone.Text.Trim().Length==0)
			{
				strErr+="CPhone不能为空！\\n";	
			}
			if(this.txtPostNum.Text.Trim().Length==0)
			{
				strErr+="PostNum不能为空！\\n";	
			}
			if(this.txtAPicURL.Text.Trim().Length==0)
			{
				strErr+="联系我们图片不能为空！\\n";	
			}
			if(this.txtavg4.Text.Trim().Length==0)
			{
				strErr+="avg4不能为空！\\n";	
			}
			if(this.txtavg5.Text.Trim().Length==0)
			{
				strErr+="avg5不能为空！\\n";	
			}
			if(this.txtJDtxt1.Text.Trim().Length==0)
			{
				strErr+="基地展示图片一描述不能为空！\\n";	
			}
			if(this.txtJDtxt2.Text.Trim().Length==0)
			{
				strErr+="基地展示图片描述不能为空！\\n";	
			}
			if(this.txtJDtxt3.Text.Trim().Length==0)
			{
				strErr+="基地展示图片描述不能为空！\\n";	
			}
			if(this.txtJDtxt4.Text.Trim().Length==0)
			{
				strErr+="基地展示图片描述不能为空！\\n";	
			}
			if(this.txtJDtxt5.Text.Trim().Length==0)
			{
				strErr+="基地展示图片描述不能为空！\\n";	
			}
			if(this.txtWXURL1.Text.Trim().Length==0)
			{
				strErr+="微信二维码不能为空！\\n";	
			}
			if(this.txtWXURL2.Text.Trim().Length==0)
			{
				strErr+="WXURL2不能为空！\\n";	
			}
			if(this.txtWXURL3.Text.Trim().Length==0)
			{
				strErr+="WXURL3不能为空！\\n";	
			}
			if(this.txtJDtxt6.Text.Trim().Length==0)
			{
				strErr+="JDtxt6不能为空！\\n";	
			}
			if(this.txtJDtxt7.Text.Trim().Length==0)
			{
				strErr+="JDtxt7不能为空！\\n";	
			}
			if(this.txtJDtxt8.Text.Trim().Length==0)
			{
				strErr+="JDtxt8不能为空！\\n";	
			}
			if(this.txtJDtxt9.Text.Trim().Length==0)
			{
				strErr+="JDtxt9不能为空！\\n";	
			}
			if(this.txtJDtxt10.Text.Trim().Length==0)
			{
				strErr+="JDtxt10不能为空！\\n";	
			}
			if(this.txtTitle1.Text.Trim().Length==0)
			{
				strErr+="标题1不能为空！\\n";	
			}
			if(this.txtTitle2.Text.Trim().Length==0)
			{
				strErr+="Title2不能为空！\\n";	
			}
			if(this.txtTitle3.Text.Trim().Length==0)
			{
				strErr+="Title3不能为空！\\n";	
			}
			if(this.txtTitle4.Text.Trim().Length==0)
			{
				strErr+="Title4不能为空！\\n";	
			}
			if(this.txtTitle5.Text.Trim().Length==0)
			{
				strErr+="Title5不能为空！\\n";	
			}
			if(this.txtTitle7.Text.Trim().Length==0)
			{
				strErr+="Title7不能为空！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string Description=this.txtDescription.Text;
			string Info=this.txtInfo.Text;
			string PicURL=this.txtPicURL.Text;
			int avg1=int.Parse(this.txtavg1.Text);
			bool avg2=this.chkavg2.Checked;
			string avg3=this.txtavg3.Text;
			string PicURL1=this.txtPicURL1.Text;
			string PicURL2=this.txtPicURL2.Text;
			string PicURL3=this.txtPicURL3.Text;
			string PicURL4=this.txtPicURL4.Text;
			string PicURL5=this.txtPicURL5.Text;
			string PicURL6=this.txtPicURL6.Text;
			string PicURL7=this.txtPicURL7.Text;
			string PicURL8=this.txtPicURL8.Text;
			string PicURL9=this.txtPicURL9.Text;
			string PicURL10=this.txtPicURL10.Text;
			string PicURL11=this.txtPicURL11.Text;
			string PicURL12=this.txtPicURL12.Text;
			string PicURL13=this.txtPicURL13.Text;
			string WAdress=this.txtWAdress.Text;
			string Adress=this.txtAdress.Text;
			string Phone=this.txtPhone.Text;
			string CPhone=this.txtCPhone.Text;
			string PostNum=this.txtPostNum.Text;
			string APicURL=this.txtAPicURL.Text;
			string avg4=this.txtavg4.Text;
			string avg5=this.txtavg5.Text;
			bool avg6=this.chkavg6.Checked;
			string JDtxt1=this.txtJDtxt1.Text;
			string JDtxt2=this.txtJDtxt2.Text;
			string JDtxt3=this.txtJDtxt3.Text;
			string JDtxt4=this.txtJDtxt4.Text;
			string JDtxt5=this.txtJDtxt5.Text;
			string WXURL1=this.txtWXURL1.Text;
			string WXURL2=this.txtWXURL2.Text;
			string WXURL3=this.txtWXURL3.Text;
			string JDtxt6=this.txtJDtxt6.Text;
			string JDtxt7=this.txtJDtxt7.Text;
			string JDtxt8=this.txtJDtxt8.Text;
			string JDtxt9=this.txtJDtxt9.Text;
			string JDtxt10=this.txtJDtxt10.Text;
			string Title1=this.txtTitle1.Text;
			string Title2=this.txtTitle2.Text;
			string Title3=this.txtTitle3.Text;
			string Title4=this.txtTitle4.Text;
			string Title5=this.txtTitle5.Text;
			string Title7=this.txtTitle7.Text;

			Maticsoft.Model.About model=new Maticsoft.Model.About();
			model.Description=Description;
			model.Info=Info;
			model.PicURL=PicURL;
			model.avg1=avg1;
			model.avg2=avg2;
			model.avg3=avg3;
			model.PicURL1=PicURL1;
			model.PicURL2=PicURL2;
			model.PicURL3=PicURL3;
			model.PicURL4=PicURL4;
			model.PicURL5=PicURL5;
			model.PicURL6=PicURL6;
			model.PicURL7=PicURL7;
			model.PicURL8=PicURL8;
			model.PicURL9=PicURL9;
			model.PicURL10=PicURL10;
			model.PicURL11=PicURL11;
			model.PicURL12=PicURL12;
			model.PicURL13=PicURL13;
			model.WAdress=WAdress;
			model.Adress=Adress;
			model.Phone=Phone;
			model.CPhone=CPhone;
			model.PostNum=PostNum;
			model.APicURL=APicURL;
			model.avg4=avg4;
			model.avg5=avg5;
			model.avg6=avg6;
			model.JDtxt1=JDtxt1;
			model.JDtxt2=JDtxt2;
			model.JDtxt3=JDtxt3;
			model.JDtxt4=JDtxt4;
			model.JDtxt5=JDtxt5;
			model.WXURL1=WXURL1;
			model.WXURL2=WXURL2;
			model.WXURL3=WXURL3;
			model.JDtxt6=JDtxt6;
			model.JDtxt7=JDtxt7;
			model.JDtxt8=JDtxt8;
			model.JDtxt9=JDtxt9;
			model.JDtxt10=JDtxt10;
			model.Title1=Title1;
			model.Title2=Title2;
			model.Title3=Title3;
			model.Title4=Title4;
			model.Title5=Title5;
			model.Title7=Title7;

			Maticsoft.BLL.About bll=new Maticsoft.BLL.About();
			bll.Add(model);
			Maticsoft.Common.MessageBox.ShowAndRedirect(this,"保存成功！","add.aspx");

		}


        public void btnCancle_Click(object sender, EventArgs e)
        {
            Response.Redirect("list.aspx");
        }
    }
}
