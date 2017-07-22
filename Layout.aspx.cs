using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageCup2014
{
    public partial class Layout : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            { this.databing(); }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            ImageCupDataContext dc = new ImageCupDataContext();
            try
            {
                var data = dc.ImagineCup.Where(o => o.Sid == text1.Text);
                if (data != null)
                {
                    gridview.DataSource = data;
                    gridview.DataBind();
                }
                else
                {
                    lable1.Visible = true;
                    lable1.Text = "您查找的学生未录入，请重新输入";
                    text1.Text = "";
                    lable1.BackColor = Color.Red;
                }
            }
            catch (Exception)
            {
                Response.Write("加载失败！");
            }
        }

        protected void Unnamed_Click1(object sender, EventArgs e)
        {
            ImageCupDataContext idc = new ImageCupDataContext();
            try
            {
                foreach (GridViewRow row in gridview.Rows)
                {
                    if ((row.FindControl("checkbox1") as CheckBox).Checked)
                    {
                        var data = idc.ImagineCup.Where(o => o.Sid == gridview.DataKeys[row.RowIndex].Value.ToString());
                        foreach (var clf in data)
                        {
                            clf.IsDeal = true;
                        }
                        idc.SubmitChanges();
                    }
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('处理失败！')</script>");
            }
            this.databing();
        }
        private void databing()
        {
            ImageCupDataContext dc = new ImageCupDataContext();
            //ImagineCup imagecup=new ImagineCup();
            try
            {
                var data = dc.ImagineCup.Where(o => o.Sid != null);
                gridview.DataSource = data;
                gridview.DataKeyNames = new string[] { "Sid" };
                gridview.DataBind();
            }
            catch (Exception)
            {
                Response.Write("加载失败！");
            }
        }
    }
}