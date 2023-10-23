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
            <strong style="background-color: #9999FF">Student Management<br />
            </strong>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style5">Student ID</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtBoxId" runat="server" Font-Size="Medium"></asp:TextBox>
                        &nbsp;
        <asp:Button ID="btnGetInfo" runat="server" OnClick="btnGetInfo_Click" Text="GET" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" />
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
        <asp:Button ID="btnInsert" runat="server" OnClick="btnInsert_Click" Text="Insert" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" />
        &nbsp;<asp:Button ID="btnSelectRec" runat="server" OnClick="btnSelectRec_Click" Text="Select" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" />
        &nbsp;<asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" />
        &nbsp;<asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" OnClientClick="return confirm('are you sure to Delete?');" Text="Delete" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" />
        &nbsp;<asp:Button ID="btnShowAll" runat="server" OnClick="btnShowAll_Click" Text="Show All" BackColor="#0066FF" Font-Bold="True" Font-Size="Medium" ForeColor="White" />
        <br />
        <asp:GridView ID="GridView1" runat="server" Height="127px" Width="432px">
        </asp:GridView>
    </form>
    <p>
        &nbsp;&nbsp;&nbsp;
    </p>
</body>
</html>
