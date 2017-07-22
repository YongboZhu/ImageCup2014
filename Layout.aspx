<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Layout.aspx.cs" Inherits="ImageCup2014.Layout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>企划部信息统计</title>
</head>
<body>
    <form id="form1" method="post" runat="server">
        <div class="jumbotron">
        <asp:Table runat="server" Width="823px" Height="28px">
            <asp:TableRow>
                <asp:TableCell>输入学号：   </asp:TableCell>
                <asp:TableCell><asp:TextBox ID="text1" runat="server" Width="600" Height="25px"></asp:TextBox></asp:TableCell>
                <asp:TableCell><asp:Button runat="server" Width="100" Height="25" Text="确定" OnClick="Unnamed_Click"/></asp:TableCell>
                <asp:TableCell><asp:Label runat="server" Visible="false" Width="250" ID="lable1"></asp:Label></asp:TableCell>
            </asp:TableRow>
        </asp:Table>
     <asp:GridView runat="server" Height="245px" Width="858px" ID="gridview" AllowSorting="true" AutoGenerateColumns="False" CellPadding="4">
        <RowStyle ForeColor="#000066" />
        <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
         <HeaderStyle BackColor="Silver" Font-Bold="True"></HeaderStyle>
         <Columns>
             <asp:BoundField DataField="Sid" HeaderText="学号"></asp:BoundField>
             <asp:BoundField DataField="Name" HeaderText="姓名"></asp:BoundField>
             <asp:BoundField DataField="Grade" HeaderText="年级"></asp:BoundField>
             <asp:BoundField DataField="Major" HeaderText="专业"></asp:BoundField>
             <asp:BoundField DataField="Phone" HeaderText="电话"></asp:BoundField>
             <asp:BoundField DataField="Email" HeaderText="电子邮件"></asp:BoundField>
             <asp:BoundField DataField="ProjectTypes" HeaderText="项目类型"></asp:BoundField>
             <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox runat="server" ID="checkbox1"/>
                </ItemTemplate>
            </asp:TemplateField>
<%--             <asp:TemplateField>
                <ItemTemplate>
                    <asp:CheckBox runat="server" ID="checkbox2"/>
                </ItemTemplate>
            </asp:TemplateField>--%>
         </Columns>
     </asp:GridView>
        <asp:Button BorderStyle="Solid" runat="server" Height="40px" Width="100px" text="处理" OnClick="Unnamed_Click1"></asp:Button>
            </div>
    </form>
</body>
</html>
