<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Administration.aspx.cs" Inherits="HMS.Administration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Hospital Management System</title>
     <link rel="stylesheet" href="StyleSheet.css" />

    <style>
        .tablestyle1{background-color:grey;
                     font-family:'Lucida Console';
        }
        #txtDoctorID{background-color:aqua}
    </style>
    <h1>Administration </h1>
    <style> 
        body {background-image:url(HMS.png);
        background-size:100% 100%;
        background-attachment:fixed;
        background-repeat:no-repeat;
        
        }
   </style>
     <script type="text/javascript">
         function validate()
         {
             flag = false;
             var DoctorId = document.getElementById("<%=txtDoctorID.ClientID%>").value;
             var DoctorName = document.getElementById("<%=txtDoctorName.ClientID%>").value;
             var Specialization = document.getElementById("<%=txtSpecialization.ClientID%>").value;
             var Qualification = document.getElementById("<%=txtQualification.ClientID%>").value;
             var Fee = document.getElementById("<%=txtConsultFee.ClientID%>").value;
             if (DoctorId == '')
                 alert('Mention Doctor Id ,Field can not be empty')
            else if (DoctorName == '')
                 alert('should not be empty');
             else if (Specialization == '')
                 alert('Cannot be empty');

            else if (Qualification == '')
                 alert('Qualification cannot be empty');
             else if (Fee == '')
                 alert('Mention fee');
             else
                 flag = true;
             return flag;
             
         }
     </script>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="tablestyle3">
                <tr> 
                    <td> <asp:Label ID="Label1" runat="server" Text="Doctor ID"></asp:Label></td>
                    <td><asp:TextBox ID="txtDoctorID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="Doctor Name"></asp:Label></td>
                    <td>
                        <asp:TextBox ID="txtDoctorName" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Specialization"></asp:Label></td>
                    <td><asp:TextBox ID="txtSpecialization" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Qualification"></asp:Label></td>
                    <td><asp:TextBox ID="txtQualification" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Fee"></asp:Label></td>
                    <td><asp:TextBox ID="txtConsultFee" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Save" OnClientClick="return validate()" OnClick="btnSave_Click" />
                        <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="btnEdit_Click"/>
                        <asp:Button ID="Button3" runat="server" Text="Update" OnClick="btnUpdate_Click"/>
                        <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="btnDelete_Click"/>
                        
                    </td>
                </tr>
            </table>
            <hr />
            <asp:Label Text="" ID="lblResult" runat="server" />
            <hr />
            <h2>Doctor Details</h2>
            <asp:GridView ID="gvDoctorInfo" runat="server"></asp:GridView>

        </div>
    </form>
   
    </body>
</html>
