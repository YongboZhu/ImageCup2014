using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ImageCup2014
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dropdownlist.Items.Add("Games Competition");
            dropdownlist.Items.Add("Innovation Competition");
            dropdownlist.Items.Add("World Citizenship Competition");
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public static string isOK = null;
        protected void Button2_Click(object sender, EventArgs e)
        {
            using (var dc = new ImageCupDataContext())
            {
                try
                {

                    var model = new ImagineCup();
                    if (!String.IsNullOrWhiteSpace(TextBox1.Text) && !String.IsNullOrWhiteSpace(TextBox2.Text) && !String.IsNullOrWhiteSpace(TextBox3.Text) && !String.IsNullOrWhiteSpace(TextBox4.Text) && !String.IsNullOrWhiteSpace(TextBox5.Text) && !String.IsNullOrWhiteSpace(dropdownlist.SelectedValue) && !String.IsNullOrWhiteSpace(TextBox9.Text))
                    {
                        model.Name = TextBox1.Text;
                        model.Grade = TextBox2.Text;
                        model.Major = TextBox3.Text;
                        model.Email = TextBox4.Text;
                        model.Phone = TextBox5.Text;
                        model.ProjectTypes = dropdownlist.SelectedItem.Value;
                        model.ProjectNames = TextBox7.Text;
                        model.TroopsName = TextBox8.Text;
                        model.Sid = TextBox9.Text;
                        model.Ip = Request.UserHostAddress;
                        model.IsDeal = false;
                        model.IsStudent = false;
                        var isRepeat = dc.ImagineCup.Where(o => o.Email == model.Email);
                        var ipRepeat = dc.ImagineCup.Where(o => o.Ip == model.Ip);
                        if (isRepeat.Count() == 0)
                        {
                            if (ipRepeat.Count() < 10)
                            {
                                dc.ImagineCup.InsertOnSubmit(model);
                                dc.SubmitChanges();
                            }
                            else
                            {
                                isOK = "同一IP提交次数过多。";
                                Server.Transfer("Rezult.aspx");
                            }
                        }
                        else
                        {
                            isOK = "请不要重复提交。";
                            Server.Transfer("Rezult.aspx");
                        }
                        if (dc.ImagineCup.Where(o => o.Email == model.Email).Count() > 0 && dc.ImagineCup.Where(o => o.Sid == model.Sid).Count() > 0)
                        {
                            isOK = "提交成功。请携带您的学生证到9栋填写完整的申请表并领取微软大礼包。";
                            Server.Transfer("Rezult.aspx");
                        }
                        else
                        {
                            isOK = "提交失败。";
                            Server.Transfer("Rezult.aspx");
                        }
                    }
                    else
                    {
                        isOK = "请填写完整再提交";
                        Server.Transfer("Rezult.aspx");
                    }
                }
                catch
                {


                }
            }
        }
    }
}