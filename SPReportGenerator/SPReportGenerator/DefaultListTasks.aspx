<%@ Page Title="Default View Tasks" Language="C#" AutoEventWireup="true" CodeBehind="DefaultListTasks.aspx.cs" Inherits="SPReportGenerator.DefaultListTasks" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="backHome" runat="server" Text="Back" OnClick="backHome_Click" />
        <asp:Panel runat="server" ID="pnl">
        </asp:Panel>
    </div>
    </form>
</body>
</html>
