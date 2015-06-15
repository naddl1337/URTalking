<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UR_Talking._Default" %>

<asp:Content runat="server" ID="FeaturedContent" ContentPlaceHolderID="FeaturedContent">
    <section class="featured">
        <div class="content-wrapper">
            <hgroup class="title">
                <h1>Willkommen zu Elise</h1>
                <h2> - dem Chatbot der Informationswissenschaft an der Uni Regensburg.</h2>
            </hgroup>
            <p>
                <%--To learn more about ASP.NET, visit <a href="http://asp.net" title="ASP.NET Website">http://asp.net</a>.
                The page features <mark>videos, tutorials, and samples</mark> to help you get the most from ASP.NET.
                If you have any questions about ASP.NET visit
                <a href="http://forums.asp.net/18.aspx" title="ASP.NET Forum">our forums</a>.--%>
                Elise ist immer bereit mit dir zu sprechen. Beginne einfach eine Unterhaltung.
            </p>
        </div>
    </section>
</asp:Content>
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h3>Chatverlauf:</h3>
    <ol class="round">
        <li class="one">
            
        </li>
        <li class="two">
            <asp:Label runat="server" AssociatedControlID="UserName">Deine Eingabe:</asp:Label>
            <asp:TextBox runat="server" ID="UserName" />
            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName" CssClass="field-validation-error" ErrorMessage="Du musst Elise schon etwas fragen..." />
        </li>
        <asp:Button runat="server" CommandName="Submit" Text="Chat!" />
    </ol>
      <ul id="chatHistory" style="list-style: none"></ul>
    <input type="search"/>
    <button type="submit">ok</button>
<script src="Scripts/questionHandler.js"></script>
</asp:Content>
