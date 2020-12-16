<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="salada.aspx.cs" Inherits="Recipes.WebForms.Salada" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
      <div class="jumbotron" style="background-image: url('/docs/images/jumbotron2.jpg'); background-size: cover; background-position: top">
        <h1 class="display-4 text-white font-weight-bold">SALADAS</h1>
    </div>
    <div class="row row-cols-1 row-cols-md-3">
        <asp:Repeater runat="server" ID="rptRecipe">
            <ItemTemplate>
                <div class="col mb-4">
                    <div class="card">
                        <img src="../docs/images/noimage.png" class="card-img">
                        <div class="card-body">
                            <h5 class="card-title"><%# DataBinder.Eval(Container.DataItem, "Title") %></h5>
                            <p class="card-text"><b>Duração:</b> <%# TimeSpan.Parse(DataBinder.Eval(Container.DataItem, "Duration").ToString()).TotalMinutes %> minutos</p>
                            <p class="card-text"><b>Dificuldade:</b> <%# DataBinder.Eval(Container.DataItem, "Difficulty") %></p>
                            <asp:LinkButton class="btn btn-secondary" ID="LinkButton1" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID")%>' OnClick="VerReceita">Ver Receita</asp:LinkButton>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
        </asp:Repeater>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
