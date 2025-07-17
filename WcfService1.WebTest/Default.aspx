<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WcfService1.WebTest._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div>
        <asp:Button ID="Button1" runat="server" Text="WCF" OnClick="Button1_Click" />
    </div>
    <div>
    <asp:Button ID="Button2" runat="server" Text="WS" OnClick="Button2_Click" />
     </div>
</asp:Content>
