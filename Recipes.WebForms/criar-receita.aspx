<%@ Page Title="Grandpa's Recipes - Criar Receita" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="criar-receita.aspx.cs" Inherits="Recipes.WebForms.InserirReceita" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <div class="jumbotron" style="background-image: url('/docs/images/jumbotron2.jpg'); background-size: cover; background-position: top">
        <h1 class="display-4 text-white font-weight-bold">Faça a sua Receita</h1>
    </div>
            <div class="form-group">
                <label for="exampleFormControlInput1">Nome da Receita</label>
                <asp:TextBox class="form-control" ID="tbName" runat="server"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="exampleFormControlInput1">Categoria</label>
                <asp:DropDownList class="form-control" ID="cbCategory" runat="server"></asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="lblCategoria">Dificuldade</label>
                <asp:DropDownList class="form-control" ID="cbDifficulty" runat="server"></asp:DropDownList>
            </div>
            <div class="form-group">
                <label for="exampleFormControlInput1">Duração</label>
                <asp:TextBox class="form-control" placeholder="Minutos" ID="tbDuration" runat="server" TextMode="Number" min="1"></asp:TextBox>
            </div>
            <%-- INSERIR INGREDIENTE--%>
            <div class="form-group">
                <label for="exampleFormControlInput1">Ingredientes da Receita</label>
                <div class="form-row">
                    <div class="col-6">
                        <asp:DropDownList class="form-control" ID="cbIngredients" runat="server"></asp:DropDownList>
                    </div>
                    <div class="col">
                        <asp:TextBox class="form-control" placeholder="Quantidade" ID="tbquantity" runat="server" TextMode="Number" min="1"></asp:TextBox>
                    </div>
                    <div class="col">
                        <asp:DropDownList class="form-control" ID="cbUnity" runat="server">
                            <asp:ListItem>gramas</asp:ListItem>
                            <asp:ListItem>colher de chá</asp:ListItem>
                            <asp:ListItem>colher de café</asp:ListItem>
                            <asp:ListItem>colher de sopa</asp:ListItem>
                            <asp:ListItem>xícara</asp:ListItem>
                            <asp:ListItem>ml</asp:ListItem>
                            <asp:ListItem>q.b</asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <asp:Button class="btn btn-secondary" ID="btninsertIngredient" runat="server" Text="Inserir Ingrediente" OnClick="btninsertIngredient_Click" />
                </div>
            </div>
            <div class="form-group">
                <asp:GridView ID="gvIngredientsInsert" runat="server" AutoGenerateColumns="True" Width="100%" ViewStateMode="Enabled" CssClass="table table-striped" GridLines="None" OnRowDataBound="gvIngredientsInsert_RowDataBound"></asp:GridView>
            </div>
            <div class="form-group">
                <label for="exampleFormControlTextarea1">Instruções</label>
                <asp:TextBox class="form-control" ID="tbInstructions" runat="server" TextMode="MultiLine" Height="200"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button class="btn btn-secondary btn-lg btn-block" ID="btnInsertRecibe" runat="server" Text="Criar Receita" OnClick="btnInsertRecibe_Click" />
            </div>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
