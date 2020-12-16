<%@ Page Title="Grandpa's Recipes - Login" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Recipes.WebForms.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <br />
    <asp:Login ID="Login1" runat="server">
        <LayoutTemplate>
            <div class="form-group">
                <div class="form-group">
                    <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                    <asp:TextBox class="form-control" ID="UserName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                    <asp:TextBox class="form-control" ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                </div>
                <div class="form-group">
                    <asp:CheckBox class="form-check-label" ID="RememberMe" runat="server" Text="Remember me" />
                </div>
                <div class="form-group">
                    <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                </div>
                <div class="form-group">
                    <asp:Button class="btn btn-secondary" ID="LoginButton" runat="server" CommandName="Login" Text="INICIAR SESSAO" ValidationGroup="Login1" />
                </div>
            </div>
        </LayoutTemplate>
    </asp:Login>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
