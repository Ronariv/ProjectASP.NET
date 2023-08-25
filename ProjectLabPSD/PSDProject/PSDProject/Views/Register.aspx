<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Site1.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="PSDProject.Views.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div>
            <h2>Register</h2>
        </div>
        <div>
            <div>
                <div>
                   <div>
                <p>Username</p>
                <div>
                    <asp:TextBox ID="UsernameTxt" runat="server" ></asp:TextBox>
                    <asp:Label ID="UsernameLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>Email</p>
                <div>
                    <asp:TextBox ID="EmailTxt" runat="server" ></asp:TextBox>
                    <asp:Label ID="EmailLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>Gender</p>
                 <div>
                     <asp:DropDownList ID="GenderLists" runat="server">
                         <asp:ListItem>Male</asp:ListItem>
                         <asp:ListItem>Female</asp:ListItem>

                     </asp:DropDownList>
                    <asp:Label ID="GenderLbl" runat="server" Text="Label" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>Password</p>
                <div>
                    <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="PasswordLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>Confirm Password</p>
                <div>
                    <asp:TextBox ID="ConfirmPasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
                    <asp:Label ID="ConfirmPasswordLbl" runat="server" Text="" Visible="false" ForeColor="Red"></asp:Label>
                </div>

                <p>
                    <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="registerBtn_Click"/>
                </p>
                <p>
                    <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Views/Login.aspx"><input type="button" value="Login"></asp:HyperLink>
                </p>
            </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
