<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebForm.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Categoria:
            <asp:DropDownList ID="DropDownList1" runat="server" DataTextField="Name" DataValueField="CoffeeTypeId" AutoPostBack="True">
            </asp:DropDownList>
            &nbsp;<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" CssClass="table table-hover" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Title" HeaderText="Title" />
                    <asp:BoundField DataField="Price" HeaderText="Price" />
                    <asp:BoundField DataField="Brand.Name" HeaderText="BrandId" />
                    <asp:BoundField DataField="CoffeeType.Name" HeaderText="CoffeeId" />
                    <asp:TemplateField HeaderText="Img">
                        <EditItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%# Eval("Img") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Image ID="Image1" runat="server" Height="32px" ImageAlign="Left" ImageUrl='<%# Eval("Img") %>' Width="32px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <br />
            <ul class="pagination pagination-sm">
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <li class="page-item"><a class="page-link" href ="<%#Eval("Url")%>"><%#Eval("Pag")%></a></li>
                   
                </ItemTemplate>
            </asp:Repeater>
                </ul>
            <asp:Panel ID="Panel1" runat="server" Visible="False">
                Error Web Side No operativo</asp:Panel>
            <br />
        </div>
    </form>
</body>
</html>
