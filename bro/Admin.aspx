<%@ Page Title="Send Notification" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Notify.aspx.cs" Inherits="GameStore.AdminNotify" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="send-notification">
        <div class="container">
            <h2>Send Notification to Subscribers</h2>
            <div class="form-group">
                <label for="txtMessage">Message:</label>
                <asp:TextBox ID="txtMessage" runat="server" CssClass="form-control" TextMode="MultiLine" Rows="5" />
            </div>
            <asp:Button ID="btnSend" runat="server" Text="Send Notification" CssClass="btn btn-primary" OnClick="btnSend_Click" />
        </div>
    </section>
</asp:Content>
