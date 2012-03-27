<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<TestModel>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Test
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Test</h2>
    
    <form method="post" action="">
    TestModel.NameForDDL is: <%= Model.NameForDDL %>
    <br /><%= Html.DropDownList("NameForDDL", new SelectList(AppHelper.NameList())) %>
    <hr /><input type="submit" value="submit" name="btnSubmit" />
    </form>

</asp:Content>
