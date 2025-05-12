<%@ Page Title="Subscribe for Notifications" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subscribe.aspx.cs" Inherits="bro.Subscribe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="subscription-form">
        <div class="container">
            <h2>Subscribe for Notifications</h2>

            <div class="form-group">
                <label for="email">Email Address:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" />
            </div>

            <div class="form-group">
                <label>Notification Preferences:</label>
                <asp:CheckBox ID="chkEmail" runat="server" Text="Email" />
                <asp:CheckBox ID="chkSMS" runat="server" Text="SMS" />
                <asp:CheckBox ID="chkPush" runat="server" Text="Push Notifications" />
            </div>

            <asp:Button ID="btnSubscribe" runat="server" Text="Subscribe" CssClass="btn btn-primary" OnClick="btnSubscribe_Click" />
        </div>
    </section>
</asp:Content>
