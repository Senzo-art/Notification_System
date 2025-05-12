<%@ Page Title="Game Catalog" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="bro.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="game-catalog">
        <div class="container">
            <h2>Browse Games</h2>

           
            <div class="row">
                <div class="col-md-3">
                    <h4>Filter by Genre</h4>
                    <asp:DropDownList ID="ddlGenres" runat="server" CssClass="form-control">
                        <asp:ListItem Text="All Genres" Value="All" />
                        <asp:ListItem Text="Action" Value="Action" />
                        <asp:ListItem Text="Adventure" Value="Adventure" />
                        <asp:ListItem Text="RPG" Value="RPG" />
                
                    </asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <h4>Filter by Platform</h4>
                    <asp:DropDownList ID="ddlPlatforms" runat="server" CssClass="form-control">
                        <asp:ListItem Text="All Platforms" Value="All" />
                        <asp:ListItem Text="PC" Value="PC" />
                        <asp:ListItem Text="PlayStation" Value="PlayStation" />
                        <asp:ListItem Text="Xbox" Value="Xbox" />
               
                    </asp:DropDownList>
                </div>
                <div class="col-md-3">
                    <h4>Filter by Price</h4>
                    <asp:TextBox ID="txtPriceMin" runat="server" CssClass="form-control" Placeholder="Min Price" />
                    <asp:TextBox ID="txtPriceMax" runat="server" CssClass="form-control" Placeholder="Max Price" />
                </div>
                <div class="col-md-3">
                    <button type="button" class="btn btn-primary" id="btnFilter" onclick="applyFilters()">Apply Filters</button>
                </div>
            </div>

        
            <div class="row" id="gameList">
              
                <div class="col-md-4">
                    <div class="game-card">
                        <img src="game_image_url.jpg" class="img-fluid" />
                        <h4>Game Title</h4>
                        <p>Game Description</p>
                        <a href="GameDetails.aspx?gameId=1" class="btn btn-secondary">View Details</a>
                    </div>
                </div>
           
            </div>
        </div>
    </section>
</asp:Content>
