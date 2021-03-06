﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddJoke.aspx.cs" Inherits="FrontEnd.AddJoke" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Joke</title>
    <link href="style.css" rel="stylesheet" />
    <style>
        .lbl {
            display:inline-block;
            width:100px;
        }

        .bottom {
            margin-bottom:20px;
        }
        .txt {
            margin-bottom:20px;
        }

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <header>
                <!--image here-->
                <img src="images/JokerHeaderLogo.jpg" alt="Joker Head Logo" />
                <h1>Add a New Joke</h1>
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </header>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Title:" CssClass="lbl"></asp:Label>
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Label ID="Label2" runat="server" Text="Teaser:" CssClass="lbl"></asp:Label>
                <asp:TextBox ID="txtTeaser" runat="server"></asp:TextBox>
                <br /><br />
                <asp:Label ID="Label3" runat="server" Text="Joke Text:" CssClass="lbl"></asp:Label>
                <asp:TextBox ID="txtJokeText" runat="server" Rows="4" TextMode="MultiLine" ></asp:TextBox>
                <br /><br />
                <%--<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
            <asp:TextBox ID="txtUser" runat="server"></asp:TextBox>
            <br />--%>
                <asp:Label ID="Label5" runat="server" Text="Category:" CssClass="lbl"></asp:Label>
                <asp:DropDownList ID="ddlCategory" AutoPostBack="True" AppendDataBoundItems="true" runat="server" Width="174px">
                    <asp:ListItem>-- Select a Category --</asp:ListItem>
                </asp:DropDownList>
                <br /><br />
                <asp:Label ID="Label6" runat="server" Text="Featured:" CssClass="lbl" ></asp:Label>
                <asp:CheckBox ID="chkFeatured" runat="server" Width="170px"/>
                <br /><br />
                <asp:Button ID="btnSubmit" runat="server" Text="Save" CssClass="bottom" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Go back!</asp:HyperLink>
            </div>
        </div>
    </form>
</body>
</html>
