<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FrontEnd.Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="wrapper">
            <header>
                <!--image here-->
                <img src="images/JokerHeaderLogo.jpg" alt="Joker Head Logo" />
                <h1>The Joker Joke Blog</h1>
                <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
            </header>
            <div id="main">

                <div id="col1">
                    <!--put dropdownlist here-->
                    <asp:DropDownList ID="ddlJokeCategories" runat="server" AutoPostBack="True" AppendDataBoundItems="true" OnSelectedIndexChanged="ddlJokeCategories_SelectedIndexChanged">
                        <asp:ListItem>-- Select a Category --</asp:ListItem>
                    </asp:DropDownList>

                </div>
                <div id="col2">
                    <!--in this spot, you will need to display
           a list of jokes (in brief view)
           that match a given category
           OR a single joke in more detail...
           you decide how you'd like to implement this
            
           -->

                    <asp:Label ID="lblHeader" runat="server" Text="Select a Category"></asp:Label>
                    <asp:Repeater ID="RptJokeTitles" runat="server">
                        <ItemTemplate>
                            <div class="Jokes">
                                <p><strong>Joke ID: </strong><%#Eval("JokeID")%></p>
                                <p><strong>Title: </strong><a href="Default.aspx?jId=<%#Eval("JokeID") %>"><%#Eval("Title") %></a></p>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>
                    <asp:Repeater ID="rptJokes" runat="server">
                        <ItemTemplate>
                            <div class="Jokes">
                                <h2><%#Eval("Title")%></h2>
                                <p><%#Eval("JokeText") %></p>
                                <p><a href="Default.aspx">Start Again</a> | <a href="UpdateJoke.aspx?=<%# Eval("JokeID") %>">Edit Joke</a></p>
                            </div>
                        </ItemTemplate>
                    </asp:Repeater>

                </div>
            </div>

            <br />
            <br />
            <br>
            <footer>
                <!--finish the hyperlinks-->
                <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Default.aspx">Home</asp:HyperLink>
                |
                <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/AddJoke.aspx">Add Joke</asp:HyperLink>
                | &copy; The Joker Blog ~ 2017
            
            </footer>
        </div>
    </form>
</body>
</html>
