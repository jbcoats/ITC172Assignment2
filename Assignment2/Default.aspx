<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="main.css" rel="stylesheet" />
</head>
<body>
    <h1>Calendar of Events</h1>
    <form id="form1" runat="server">
    <div">
        <asp:Calendar ID="CalendarOfEvents" runat="server" OnSelectionChanged="CalendarOfEvents_SelectionChanged"></asp:Calendar>
        <asp:Label ID="EventLabel" runat="server" Text="" CssClass="results"></asp:Label>
    </div>
    </form>
</body>
</html>
