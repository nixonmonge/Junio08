<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Categoria:
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Name" DataValueField="CoffeeTypeId">
            </asp:DropDownList>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <%#Eval("Pag") %>
                </ItemTemplate>
            </asp:Repeater>
            <br />
        </div>
    </form>
</body>
</html>
