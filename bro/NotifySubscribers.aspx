<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NotifySubscribers.aspx.cs" Inherits="bro.NotifySubscribers" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Send Notifications</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="padding:20px;">
            <h2>Send Notification to Subscribers</h2>
            <asp:TextBox ID="txtMessage" runat="server" TextMode="MultiLine" Rows="6" Columns="60" placeholder="Enter your notification message here..." />
            <br /><br />
            <asp:Button ID="btnSend" runat="server" Text="Send to Email Subscribers" OnClick="btnSend_Click" />
            <br /><br />
            <asp:Label ID="lblStatus" runat="server" ForeColor="Green" />
        </div>
    </form>
</body>
</html>
