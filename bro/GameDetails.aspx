<%@ Page Title="Game Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GameDetails.aspx.cs" Inherits="GameStore.GameDetails" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="game-details">
        <div class="container">
            <h2>Game Title</h2>
            <img src="game_image_url.jpg" class="img-fluid" />
            <p>Description of the game...</p>
            <h4>Price: $49.99</h4>
            <asp:Button ID="btnBuy" runat="server" Text="Buy Now" CssClass="btn btn-success" OnClick="btnBuy_Click" />
            <asp:Button ID="btnNotify" runat="server" Text="Notify Me" CssClass="btn btn-warning" OnClick="btnNotify_Click" />
        </div>
    </section>
</asp:Content>
