<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LandingPage.aspx.cs" Inherits="bro.LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Notifications</title>
    <link href="Style.css" rel="stylesheet" type="text/css" />
</head>
<body>
  
   
   <header class="hero">
   <div class="container">
     <h1>NotifyMe</h1>
     <p>Subscribe to real-time notifications via Email, SMS, or Push.</p>
     <a href="Subscribe.aspx" class="btn">Get Started</a>
   </div>
 </header>
    <form id="form1" runat="server">
        <section class="features">
  <div class="container">
    <h2>How It Works</h2>
    <div class="feature-grid">
      <div class="feature">
        <h3>Email Alerts</h3>
        <p>Get important updates directly in your inbox.</p>
      </div>
      <div class="feature">
        <h3>SMS Notifications</h3>
        <p>Receive time-sensitive alerts instantly on your phone.</p>
      </div>
      <div class="feature">
        <h3>Push Messages</h3>
        <p>Stay informed on your device with browser push notifications.</p>
      </div>
    </div>
  </div>
</section>
    </form>
</body>
</html>



