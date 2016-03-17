<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoctorEntryUI.aspx.cs" Inherits="CommunityMedicine.UI.DoctorEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
&nbsp;
        <asp:TextBox ID="doctorNameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Degree"></asp:Label>
&nbsp;
        <asp:TextBox ID="degreeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Specialization"></asp:Label>
&nbsp;
        <asp:TextBox ID="specializationTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
&nbsp;
        <asp:Button ID="saveDoctorButton" runat="server" OnClick="saveDoctorButton_Click" Text="Save" />
        <br />
        <br />
        <asp:Label ID="messageLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
