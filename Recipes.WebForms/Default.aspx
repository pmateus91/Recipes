<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="Recipes.WebForms.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <div class="jumbotron" style="background-image: url('/docs/images/jumbotron2.jpg'); background-size: cover; background-position: top">
        <h1 class="display-4 text-white font-weight-bold">Bem-vindo</h1>
        <p class="lead text-white">Tem ingredientes na cozinha mas não sabe o que fazer ou falta-lhe inspiração?</p>
        <p class="lead text-white">Nós damos-lhe as sugestões.</p>
        <br>
        <asp:LoginView ID="LoginView1" runat="server">
            <AnonymousTemplate>
                <p class="lead">
                    <a class="btn btn-secondary btn-lg" href="~/account/login.aspx" runat="server" role="button">Iniciar Sessão</a>
                    <a class="btn btn-secondary btn-lg" href="~/account/create.aspx" runat="server" role="button">Registar</a>
                </p>
            </AnonymousTemplate>
        </asp:LoginView>
    </div>

    <div>
        <div class="row row-cols-1 row-cols-md-2">
            <asp:Repeater runat="server" ID="rptCategory">
                <ItemTemplate>
                    <div class="col mb-4">
                        <div class="card">
                            <img src="/docs/images/noimage.png" class="card-img-top" width="600" height="400">
                            <div class="card-body">
                                <h5 class="card-title"><%# DataBinder.Eval(Container.DataItem, "Name") %></h5>
                                <p class="card-text">
                                    <b>Descrição:</b> <%# DataBinder.Eval(Container.DataItem, "Description").ToString() %>
                                </p>
                                <asp:LinkButton class="btn btn-secondary" ID="LinkButton1" runat="server" CommandArgument='<%#DataBinder.Eval(Container.DataItem,"ID")%>' OnClick="VerReceita">Ver Receitas</asp:LinkButton>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>        
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
