<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	AddPost
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>AddPost</h2>
    <hr />
    <h3>This is :<%= ViewData["Name"] %></h3>
<p><%= Html.ActionLink("Edit Post", "EditPost") %></p>
<p><%= Html.ActionLink("Test", "Test") %></p>
</asp:Content>
