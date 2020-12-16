<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="detalhesreceita.aspx.cs" Inherits="Recipes.WebForms.detalhesreceita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <div class="card mb-3">
        <img src="../docs/images/noimage.png" class="card-img-top img-fluid" alt="Responsive image"">
        <div class="card-body">
            <div class="form-row">
                <div class="form-group col-md-auto">
                    <asp:Label CssClass="h2" ID="lblTitle" runat="server" Text=""></asp:Label>
                </div>
                <div class="form-group col">
                    <asp:LinkButton class="btn btn-success btn-lg" ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">+ Favoritos</asp:LinkButton>
                </div>
                <div class="form-group col text-right">
                    <div class="input-group mb-1">
                        <div class="input-group-prepend">
                            <asp:Button class="btn btn-outline-success" ID="Button1" runat="server" Text="+ Classificar" />                            
                        </div>
                        <select class="custom-select" id="inputGroupSelect03" aria-label="Example select with button addon">
                            <option selected>Escolha...</option>
                            <option value="1">1</option>
                            <option value="2">2</option>
                            <option value="3">3</option>
                            <option value="3">4</option>
                            <option value="3">5</option>
                        </select>
                    </div>
                </div>
            </div>
            <p class="card-text">
                <b>Classificação:</b>
                <asp:Label ID="lblRating" runat="server" Text="Label">    
                </asp:Label>
            </p>
            <p class="card-text">
                <b>Categoria:</b>
                <asp:Label ID="lblCategoryName" runat="server" Text="Label"></asp:Label>
            </p>
            <p class="card-text">
                <b>Dificuldade:</b>
                <asp:Label ID="lblDifficulty" runat="server" Text="Label"></asp:Label>
            </p>
            <p class="card-text">
                <b>Duração:</b>
                <asp:Label ID="lblDuration" runat="server" Text="Label"></asp:Label>
            </p>
            <p class="card-text">
                <asp:GridView ID="gvIngredientsInsert" runat="server" AutoGenerateColumns="True" Width="100%" ViewStateMode="Enabled" CssClass="table table-striped" GridLines="None"></asp:GridView>
            </p>
            <p class="card-text">
                <b>Instruções: </b>
                <asp:Label ID="lblInstructions" runat="server" Text="Label"></asp:Label>
            </p>
            <p class="card-text">
                <small class="text-muted">Criado por:
                <asp:Label ID="lblUser" runat="server" Text="Label"></asp:Label></small>
            </p>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
