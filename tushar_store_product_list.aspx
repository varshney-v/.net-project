<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="tushar_store_product_list.aspx.cs" Inherits="WebApplication7.tushar_store_product_list" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Product Name :</td>
                    <td><asp:TextBox ID="text_pd_name" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Product Expiry :</td>
                    <td><asp:TextBox ID="text_pd_expiry" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Product Reck Number :</td>
                    <td><asp:TextBox ID="text_pd_reck_no" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:Button ID="btninsert" runat="server" Text="submit" OnClick="btninsert_Click" /> </td>
                </tr>
                <tr>
                    <td></td>
                    <td><asp:GridView ID="gv_store" runat="server"></asp:GridView></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
