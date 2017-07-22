<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ImageCup2014._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      <div class="jumbotron">
    <div class ="textcenter">
        <div class ="infcenter">
        <p style="height:185px;"></p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="姓名："></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="26pt" Width="217pt"></asp:TextBox>
            *</p>
        <p>
            <asp:Label ID="Label11" runat="server" Text="学号："></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox9" runat="server" Height="26pt" Width="217pt"></asp:TextBox>
            *</p>
        <p>
            <asp:Label ID="Label4" runat="server" Text="年级："></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Height="26pt" Width="217pt"></asp:TextBox>
            *</p>
        <p>
            <asp:Label ID="Label5" runat="server" Text="专业："></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" Height="26pt" Width="217pt"></asp:TextBox>
            *</p>
        <p>
            <asp:Label ID="Label6" runat="server" Text="E-mail："></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="26pt" Width="217pt" ></asp:TextBox>
            *</p>
        <p>
            <asp:Label ID="Label7" runat="server" Text="手机号："></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Height="26pt" Width="217pt"></asp:TextBox>
            *</p>
        <p>
            <asp:Label ID="Label8" runat="server" Text="参赛项目种类："></asp:Label>
            <asp:DropDownList runat="server" ID="dropdownlist" Width="280px"></asp:DropDownList>
            *</p>
        <p>
            <asp:Label ID="Label9" runat="server" Text="参赛作品名称："></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server" Height="26pt" Width="217pt"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label10" runat="server" Text="参赛队伍名称："></asp:Label>
            <asp:TextBox ID="TextBox8" runat="server" Height="26pt" Width="217pt"></asp:TextBox>
        </p>
        <p>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
              <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="提交" Width="154px" />
            </p>
       </div>
    </div>
</div>

</asp:Content>
