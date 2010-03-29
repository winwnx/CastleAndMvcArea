<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	ShowRecent
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>ShowRecent</h2>
    
    <p><%= Html.ActionLink("Show Archive", "ShowArchive") %></p>
    <h2>The name is <%= ViewData["BlogName"] %></h2>


</asp:Content>
