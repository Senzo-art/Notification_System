<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="bro._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <section class="hero">
        <div class="container text-center">
            <h1>Welcome to GameStore!</h1>
            <p>Your ultimate destination for the best games, updates, and deals.</p>
            <a href="#subscribe" class="btn btn-primary">Subscribe for Notifications</a>
        </div>
    </section>

    <!-- Featured Games Section -->
    <section class="featured-games">
        <div class="container">
            <h2>Featured Games</h2>
            <div class="row">
                <!-- Example Game Item (Repeat for more featured games) -->
                <div class="col-md-4">
                    <div class="game-card">
                        <img src="path_to_game_image.jpg" alt="Game Title" class="game-img" />
                        <h3>Game Title</h3>
                        <p>Game Description</p>
                        <a href="purchase.aspx" class="btn btn-secondary">Buy Now</a>
                    </div>
                </div>
          
            </div>
        </div>
    </section>

    <!-- Subscription Section -->
    <section id="subscribe" class="subscription">
        <div class="container text-center">
            <h2>Stay Updated with Game Events & Price Drops!</h2>
            <p>Sign up to receive notifications about game updates, special events, and exclusive discounts.</p>
            <a href="subscribe.aspx" class="btn btn-success">Subscribe Now</a>
        </div>
    </section>

    <!-- Footer Section -->
   
    <script type="text/javascript">
        // JavaScript code to handle logout or other events
        function logout() {
            __doPostBack('btnLogout', ''); // This triggers the server-side logout event
        }
    </script>


</asp:Content>
