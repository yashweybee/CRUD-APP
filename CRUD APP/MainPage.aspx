<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="CRUD_APP.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            height: 23px;
        }

        .auto-style3 {
            height: 23px;
            width: 265px;
        }

        .auto-style4 {
            width: 265px;
        }

        .auto-style5 {
            height: 23px;
            width: 290px;
        }

        .auto-style6 {
            width: 290px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <strong>Student Management<br />
            </strong>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style5">Student ID</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtBoxId" runat="server" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style5">Student Name</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtBoxName" runat="server" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">City</td>
                    <td>
                        <asp:DropDownList ID="ddCity" runat="server">
                            <asp:ListItem Value="Rajkot"></asp:ListItem>
                            <asp:ListItem Value="Jamnagar"></asp:ListItem>
                            <asp:ListItem Value="Gandhinagar"></asp:ListItem>
                            <asp:ListItem Value="Vadodara"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">Age</td>
                    <td>
                        <asp:TextBox ID="txtBoxAge" runat="server" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style6">Contact</td>
                    <td>
                        <asp:TextBox ID="txtBoxContact" runat="server" Font-Size="Medium"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <br />
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" />
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="127px" Width="432px">
        </asp:GridView>
    </form>
    <p>
        &nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
