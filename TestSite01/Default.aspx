<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="TextBox1" Type="Number" runat="server" Height="39px" Width="56px" BorderWidth="1px" Font-Size="20pt" ></asp:TextBox>
        &nbsp;<asp:TextBox ID="TextBox2" Type="Number" runat="server" Height="39px" Width="56px" BorderWidth="1px" Font-Size="20pt" ></asp:TextBox>
        &nbsp;<asp:TextBox ID="TextBox3" Type="Number" runat="server" Height="39px" Width="56px" BorderWidth="1px" Font-Size="20pt" ></asp:TextBox>
        &nbsp;<asp:TextBox ID="TextBox4" Type="Number" runat="server" Height="39px" Width="56px" BorderWidth="1px" Font-Size="20pt" ></asp:TextBox>
        &nbsp;<asp:TextBox ID="TextBox5" Type="Number" runat="server" Height="39px" Width="56px" BorderWidth="1px" Font-Size="20pt" ></asp:TextBox>
    
    </div>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="FindLargest" BorderWidth="1px" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
