<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="HMS.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .auto-style1 {
            margin-left: 5px;
        }
        .auto-style2 {
            width: 119px;
        }
    </style>
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
            <h1>Admin Login</h1>
            <table>
                <tr>
                    <td >Doctor ID</td>
                    <td><asp:TextBox ID="txtDoctorID" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtDoctorID" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Invalid User ID</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox ID="txtPassword" runat="server" ></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" ErrorMessage="RequiredFieldValidator" ForeColor="Red">Incorrect Password</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>                
                    <td><asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" Width="178px" CssClass="auto-style2" ForeColor="#333333" />

                    </td>
                </tr>
            </table>
                       
            
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/AdminRegistration.aspx">Register Here</asp:HyperLink>
            <hr />
            <asp:Label Text="" ID="lblResult" runat="server"></asp:Label>
            <hr />
            <asp:GridView ID="gvDoctorInfo" runat="server"></asp:GridView>
        </div>
    </form>
</body>
</html>
