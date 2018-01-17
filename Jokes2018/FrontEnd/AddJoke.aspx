<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJoke.aspx.cs" Inherits="FrontEnd.AddJoke" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtTeaser" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtJoke" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtCreated" runat="server"></asp:TextBox>
            <br />
            <%--<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <br />--%>
            <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <asp:DropDownList ID="ddlCategory" runat="server"></asp:DropDownList>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
            <asp:CheckBox ID="chkFeatured" runat="server" />
            <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Save" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" />
        </div>
    </form>
</body>
</html>
