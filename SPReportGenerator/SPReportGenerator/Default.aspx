<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SPReportGenerator.ShowListTasks" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   
    <br /><br /><br /><br />
    <asp:Button runat="server" ID="listTasks" Text="Show List Tasks" OnClick="listTasks_Click" />

</asp:Content>
