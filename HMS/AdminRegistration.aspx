<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminRegistration.aspx.cs" Inherits="HMS.AdminRegistration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Admin Registration</title>
    
     <style> 
        body {background-image:url(HMS.png);
        background-size:100% 100%;
        background-attachment:fixed;
        background-repeat:no-repeat;
        
        }
   </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h1>Security Login</h1>
            <table>

                <tr>
                <td>Security Code</td>
                <td>
                    <asp:TextBox ID="txtSecurityCode" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtSecurityCode" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Required Field</asp:RequiredFieldValidator>
                    </td>
                    </tr>
                <tr>
                <td>Security Password</td>
                <td>
                    <asp:TextBox ID="txtSecurityPassword" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSecurityPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Incorrect Password</asp:RequiredFieldValidator>
                    </td>
                    </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="184px" /></td>
                </tr>
            </table>
        </div>
        <hr />
            <asp:Label Text="" ID="lblResult" runat="server" />
            <hr />
        <asp:GridView ID="gvDoctorInfo" runat="server"></asp:GridView>
        
    </form>
</body>
</html>
