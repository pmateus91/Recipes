<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Recipes.WebForms.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <div class="jumbotron" style="background-image: url('/docs/images/jumbotron2.jpg'); background-size: cover; background-position: top">
        <h1 class="display-4 text-white font-weight-bold">Bem-vindo</h1>
        <p class="lead text-white">Tem ingredientes na cozinha mas não sabe o que fazer ou falta-lhe inspiração?</p>
        <p class="lead text-white">Nós damos-lhe as sugestões.</p>
        <br>
        <p class="lead">
            <a class="btn btn-secondary btn-lg" href="~/Accounts/Login.aspx" runat="server" role="button">Iniciar Sessão</a>
            <a class="btn btn-secondary btn-lg" href="~/Accounts/Register.aspx" runat="server" role="button">Registar</a>
        </p>

    </div>

    <div>
        <div class="row row-cols-1 row-cols-md-2">
            <div class="col mb-4">
                <div class="card">
                    <img src="/docs/images/entradas.jpg" class="card-img-top" width="600" height="400">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="CategoryTitleLbl1" runat="server" Text="Title"></asp:Label></h5>
                        <p class="card-text">
                            <asp:Label ID="CategoryDescriptionLbl1" runat="server" Text="Description"></asp:Label>
                        </p>
                        <asp:Button class="btn btn-secondary" ID="CategoryBtn1" runat="server" Text="Ver Receitas" />
                    </div>
                </div>
            </div>
            <div class="col mb-4">
                <div class="card">
                    <img src="/docs/images/sopas.jpg" class="card-img-top" width="600" height="400">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="CategoryTitleLbl2" runat="server"></asp:Label></h5>
                        <p class="card-text">
                            <asp:Label ID="CategoryDescriptionLbl2" runat="server"></asp:Label>
                        </p>
                        <asp:Button class="btn btn-secondary" ID="CategoryBtn2" runat="server" Text="Ver Receitas" />
                    </div>
                </div>
            </div>
            <div class="col mb-4">
                <div class="card">
                    <img src="/docs/images/carnes.jpg" class="card-img-top" width="600" height="400">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="CategoryTitleLbl3" runat="server" Text="Title"></asp:Label></h5>
                        <p class="card-text">
                            <asp:Label ID="CategoryDescriptionLbl3" runat="server" Text="Description"></asp:Label>
                        </p>
                        <asp:Button class="btn btn-secondary" ID="CategoryBtn3" runat="server" Text="Ver Receitas" />
                    </div>
                </div>
            </div>
            <div class="col mb-4">
                <div class="card">
                    <img src="/docs/images/peixes.jpg" class="card-img-top" width="600" height="400">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="CategoryTitleLbl4" runat="server" Text="Title"></asp:Label></h5>
                        <p class="card-text">
                            <asp:Label ID="CategoryDescriptionLbl4" runat="server" Text="Description"></asp:Label>
                        </p>
                        <asp:Button class="btn btn-secondary" ID="CategoryBtn4" runat="server" Text="Ver Receitas" />
                    </div>
                </div>
            </div>
            <div class="col mb-4">
                <div class="card">
                    <img src="/docs/images/veg.jpg" class="card-img-top" width="600" height="400">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="CategoryTitleLbl5" runat="server" Text="Title"></asp:Label></h5>
                        <p class="card-text">
                            <asp:Label ID="CategoryDescriptionLbl5" runat="server" Text="Description"></asp:Label>
                        </p>
                        <asp:Button class="btn btn-secondary" ID="CategoryBtn5" runat="server" Text="Ver Receitas" />
                    </div>
                </div>
            </div>
            <div class="col mb-4">
                <div class="card">
                    <img src="/docs/images/sobremesas.jpg" class="card-img-top" width="600" height="400">
                    <div class="card-body">
                        <h5 class="card-title">
                            <asp:Label ID="CategoryTitleLbl6" runat="server" Text="Title"></asp:Label></h5>
                        <p class="card-text">
                            <asp:Label ID="CategoryDescriptionLbl6" runat="server" Text="Description"></asp:Label>
                        </p>
                        <asp:Button class="btn btn-secondary" ID="CategoryBtn6" runat="server" Text="Ver Receitas" />
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
