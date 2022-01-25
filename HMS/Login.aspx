<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="HMS.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hospital Mangement System</title>
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
            
                <h1>&nbsp;Patient Login Page</h1>
            <table>
                
                <tr>
                    <td>Patient ID</td>
                    <td>
                        <asp:TextBox ID="txtPatientID" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td>
                        <asp:TextBox ID="txtPatientPassword" TextMode="Password" runat="server"></asp:TextBox> </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" Width="184px" OnClick="btnLogin_Click" />
                        
                    </td>
                </tr>
                    
            </table>
            
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Registration.aspx">Register</asp:HyperLink>
            <hr />
            <asp:Label Text="" ID="lblResult" runat="server"></asp:Label>
            <hr />   
            <asp:GridView ID="gvPatientDetails"  runat="server"></asp:GridView>
        </div>
        
    </form>
</body>
</html>
