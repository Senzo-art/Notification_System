<%@ Page Title="Subscribe for Notifications" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Subscribe.aspx.cs" Inherits="bro.Subscribe" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="subscription-form">
        <div class="container">
            <h2>Subscribe for Notifications</h2>
            <p>Choose how you would like to receive notifications:</p>

            <div class="form-group">
                <label for="email">Email Address:</label>
                <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" Placeholder="Enter your email address" />
            </div>

            <div class="form-group">
                <label>Notification Preferences:</label><br />
                <asp:CheckBox ID="chkEmail" runat="server" Text="Email" AutoPostBack="true" OnCheckedChanged="chkEmail_CheckedChanged" />
                <asp:CheckBox ID="chkSMS" runat="server" Text="SMS" AutoPostBack="true" OnCheckedChanged="chkSMS_CheckedChanged" />
                <asp:CheckBox ID="chkPush" runat="server" Text="Push Notifications" AutoPostBack="true" OnCheckedChanged="chkPush_CheckedChanged" />
            </div>

            <div class="form-group" id="smsPhoneNumber" style="display: none;">
                <label for="phoneNumber">Phone Number (for SMS notifications):</label>
                <asp:TextBox ID="txtPhoneNumber" runat="server" CssClass="form-control" Placeholder="Enter your phone number" />
            </div>

            <div class="form-group" id="PushDevice" style="display: none;">
                <label for="PushDevice">Device ID (for Push notifications):</label>
                <asp:TextBox ID="txtPushDevice" runat="server" CssClass="form-control" Placeholder="Enter your device ID" />
            </div>

            <asp:Button ID="btnSubscribe" runat="server" Text="Subscribe" CssClass="btn btn-primary" OnClick="btnSubscribe_Click" />

        </div>
    </section>
</asp:Content>
