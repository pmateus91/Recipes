<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="receitasfavoritas.aspx.cs" Inherits="Recipes.WebForms.Receitasfavoritas" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <div class="jumbotron" style="background-image: url('/docs/images/jumbotron2.jpg'); background-size: cover; background-position: top">
        <h1 class="display-4 text-white font-weight-bold">RECEITAS FAVORITAS</h1>
    </div>
    <ul class="list-group">
        <asp:Repeater runat="server" ID="rptRecipe">
            <ItemTemplate>
                <li class="list-group-item">
                    <div class="row">
                        <div class="col-md-7"><b>Titulo: </b><%# DataBinder.Eval(Container.DataItem, "Title") %></div>                        
                         <div class="col-md-2"><b>Categoria: </b><%# DataBinder.Eval(Container.DataItem, "CategoryName") %></div>
                        <div class="col text-right">
                            <asp:LinkButton class="btn btn-secondary" ID="LinkButton1" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID")%>' OnClick="VerReceita">Ver</asp:LinkButton>
                        </div> 
                    </div>
                </li>
            </ItemTemplate>
        </asp:Repeater>
    </ul>
    <br />
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
