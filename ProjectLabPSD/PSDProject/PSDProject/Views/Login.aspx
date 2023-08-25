<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PSDProject.Views.Login" %>
<asp:Content ID="Content3" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <h2>Login</h2>
        </div>
        <div>
            <div>
                <div>
                    <div>
                        <p>Email</p>
                        <div>
                            <asp:TextBox ID="EmailTxt" runat="server" class="form-control"></asp:TextBox>
                        </div>
                        <p>Password</p>
                        <div
                            >
                            <asp:TextBox ID="PasswordTxt" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
                        <p>
                            <asp:CheckBox ID="RememberCheckBox" runat="server"/>
                            <asp:Label ID="RememberLabel" runat="server" Text="Remember Me" AssociatedControlID="RememberCheckBox"></asp:Label>
                        </p>
                        <p>
                            <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                        </p>
                        <p>
                            <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click"/>
                        </p>
                        <p>
                            <asp:HyperLink ID="RegisterLink" runat="server" NavigateUrl="~/Views/Register.aspx">
                                <input type="button"value="Register"/>
                            </asp:HyperLink>
                        </p>
                    </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>