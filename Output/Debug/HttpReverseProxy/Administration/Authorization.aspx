<%@ Page Language="C#" AutoEventWireup="true" Codebehind="Authorization.aspx.cs"
  Inherits="Egora.Stammportal.HttpReverseProxy.Administration.Authorization" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <title>Authorization</title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <asp:HyperLink ID="ApplicationLink" runat="server" NavigateUrl="Applications.aspx">Applications</asp:HyperLink>
      <asp:HyperLink ID="AuthorizationLink" runat="server" NavigateUrl="Authorization.aspx">Authorization</asp:HyperLink>
      <asp:HyperLink ID="ConnectionLink" runat="server" NavigateUrl="Connection.aspx">Connections</asp:HyperLink> 
      <asp:HyperLink ID="ResetLink" runat="server" NavigateUrl="Reset.aspx">Reset</asp:HyperLink>
      <br />
      <asp:GridView ID="AuthorizationGridView" runat="server" CellPadding="4" ForeColor="#333333"
        GridLines="None" AutoGenerateColumns="false">
        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <RowStyle BackColor="#EFF3FB" />
        <EditRowStyle BackColor="#2461BF" />
        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="White" />
        <Columns>
          <asp:BoundField DataField="User" HeaderText="UserId" />
          <asp:BoundField DataField="ApplicationId" HeaderText="ApplicationId" />
          <asp:BoundField DataField="Hits" HeaderText="Hits" />
          <asp:BoundField DataField="Authorization" HeaderText="Authorization" />
        </Columns>
      </asp:GridView>
    </div>
  </form>
</body>
</html>
