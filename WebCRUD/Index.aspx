<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebCRUD.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>CRUD</title>
    <link href="css/style.css" rel="stylesheet" />
</head>
<body>
    <div class="center-x">
        <div class="center-y">
            <div class="container">
                <form id="form1" runat="server">
                    <div class="form-container">
                        <asp:DropDownList CssClass="form-contents" ID="DropDownList1" runat="server" AutoPostBack="true" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                        <asp:Label CssClass="form-contents" ID="Label1" runat="server" Text=""></asp:Label>
                        <asp:GridView CssClass="form-contents gridview" Visible="false" ID="GridView1" runat="server"></asp:GridView>
                    </div>
                </form>
            </div>
        </div>
    </div>
</body>
</html>
