<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Gerenciador.Comandos.PostNewTweetCommand>" %>

<asp:Content ID="Content1" ContentPlaceHolderID="TitleContent" runat="server">
	Add
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" runat="server">

    <h2>Add</h2>

    <% using (Html.BeginForm()) {%>
        <%= Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Mensagem) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Mensagem) %>
                <%= Html.ValidationMessageFor(model => model.Mensagem) %>
            </div>
            
            <div class="editor-label">
                <%= Html.LabelFor(model => model.Quem) %>
            </div>
            <div class="editor-field">
                <%= Html.TextBoxFor(model => model.Quem) %>
                <%= Html.ValidationMessageFor(model => model.Quem) %>
            </div>
            
            <p>
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%= Html.ActionLink("Back to List", "Index") %>
    </div>

</asp:Content>

