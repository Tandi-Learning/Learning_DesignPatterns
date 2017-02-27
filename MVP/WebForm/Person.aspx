<%@ Page Title="Person" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Person.aspx.cs" Inherits="WebForm.Person" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your Person page.</h3>

    <div>
        <asp:Label ID="Label1" runat="server" Text="First Name"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label2" runat="server" Text="Last Name"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="Label3" runat="server" Text="Last Updated"></asp:Label>
        <asp:TextBox ID="txtLastUpdated" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Save" />
    </div>
</asp:Content>
