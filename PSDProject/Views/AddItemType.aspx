<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="AddItemType.aspx.cs" Inherits="PSDProject.Views.AddItemType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:2% 10%; margin-left:25%; margin-right:25%;">
        <div>
            <div class="form-group">
                <label for="inputTitle">Item Type Name</label>
                <asp:TextBox ID="TypeNameTxt" runat="server" class="form-control"></asp:TextBox>
                <asp:Label ID="TypeNameLbl" runat="server" Text="" ForeColor="Red"></asp:Label>
            </div>
            <asp:Button ID="SubmitBtn" runat="server" Text="Submit" class="btn btn-success mb-2 w-100" OnClick="SubmitBtn_Click"/>
       </div>
    </div>
</asp:Content>
