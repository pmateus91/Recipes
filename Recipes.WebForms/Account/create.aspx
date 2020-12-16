<%@ Page Title="Grandpa's Recipes - Criar Conta" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="create.aspx.cs" Inherits="Recipes.WebForms.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadPlaceHolder" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainPlaceHolder" runat="server">
    <br />
    <asp:CreateUserWizard ID="CreateUserWizard1" runat="server" OnCreatedUser="CreateUserWizard1_CreatedUser" ContinueDestinationPageUrl="~/default.aspx" Width="400px">
        <CreateUserButtonStyle CssClass="btn btn-secondary" />
        <WizardSteps>
            <asp:WizardStep runat="server" Title="User">
                <div class="form-group">
                    <label for="FormControlInput1">Primeiro Nome</label>
                    <asp:TextBox class="form-control" ID="tbFirstName" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="FormControlSelect2">Último Nome</label>
                    <asp:TextBox class="form-control" ID="tbLastName" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="FormControlSelect4">Morada</label>
                    <asp:TextBox class="form-control" ID="tbAdress" runat="server" TextMode="MultiLine"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="FormControlSelect1">Género</label>
                    <asp:DropDownList class="form-control" ID="ddGender" runat="server">
                        <asp:ListItem Value="0">Masculino</asp:ListItem>
                        <asp:ListItem Value="1">Feminino</asp:ListItem>
                    </asp:DropDownList>
                </div>
            </asp:WizardStep>
            <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server" Title="Criar Nova Conta">
                <ContentTemplate>
                    <table style="font-size:100%;width:400px;">
                        <tr>
                            <td align="center" colspan="2">Criar Nova Conta</td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="ConfirmPasswordLabel" runat="server" AssociatedControlID="ConfirmPassword">Confirm Password:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="ConfirmPassword" runat="server" TextMode="Password"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="ConfirmPasswordRequired" runat="server" ControlToValidate="ConfirmPassword" ErrorMessage="Confirm Password is required." ToolTip="Confirm Password is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email">E-mail:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Email" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="EmailRequired" runat="server" ControlToValidate="Email" ErrorMessage="E-mail is required." ToolTip="E-mail is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="QuestionLabel" runat="server" AssociatedControlID="Question">Security Question:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Question" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="QuestionRequired" runat="server" ControlToValidate="Question" ErrorMessage="Security question is required." ToolTip="Security question is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="right">
                                <asp:Label ID="AnswerLabel" runat="server" AssociatedControlID="Answer">Security Answer:</asp:Label>
                            </td>
                            <td>
                                <asp:TextBox ID="Answer" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="AnswerRequired" runat="server" ControlToValidate="Answer" ErrorMessage="Security answer is required." ToolTip="Security answer is required." ValidationGroup="CreateUserWizard1">*</asp:RequiredFieldValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2">
                                <asp:CompareValidator ID="PasswordCompare" runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword" Display="Dynamic" ErrorMessage="The Password and Confirmation Password must match." ValidationGroup="CreateUserWizard1"></asp:CompareValidator>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="2" style="color:Red;">
                                <asp:Literal ID="ErrorMessage" runat="server" EnableViewState="False"></asp:Literal>
                            </td>
                        </tr>
                    </table>
                </ContentTemplate>
            </asp:CreateUserWizardStep>
            <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                <ContentTemplate>
                    <div class="form-group">
                            <div class="alert alert-success" role="alert">
                                A sua conta foi criada com sucesso 
                            </div>                        
                            <asp:Button class="btn btn-secondary" ID="ContinueButton" runat="server" CausesValidation="False" CommandName="Continue" Text="Continuar" ValidationGroup="CreateUserWizard1" />
                     </div>
                </ContentTemplate>
            </asp:CompleteWizardStep>
        </WizardSteps>
        <NavigationButtonStyle CssClass="btn btn-secondary" />
    </asp:CreateUserWizard>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ScriptPlaceHolder" runat="server">
</asp:Content>
