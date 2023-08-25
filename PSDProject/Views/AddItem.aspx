<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="AddItem.aspx.cs" Inherits="PSDProject.Views.AddItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:2% 10%">
        <div method="post">
            <div class="form-group">
                <label for="inputTitle">Title</label>
                <asp:TextBox ID="TitleTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="inputCategory">Category</label>
                <asp:DropDownList ID="categorySelect" runat="server" class="form-control">
                    
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <div class="form-grouping">
                    <label for="inputBasicPrice">Price</label>
                    <asp:TextBox ID="PriceTxt" runat="server" TextMode="Number" class="form-control"></asp:TextBox>
                </div>
                <div class="form-grouping">
                    <label for="inputPrice">Description</label>
                    <asp:TextBox ID="DescriptionTxt" runat="server" TextMode="MultiLine" rows="10" class="form-control"></asp:TextBox>
                </div>
            </div>
      
            </div>
            <div class="form-group custom-file mb-5">
                <label class="form-label" for="customFile">Images</label>
                 <asp:FileUpload ID="ImageFile" runat="server" class="form-control p-1"/>
            </div>
        <asp:Label ID="ErrorTxt" runat="server" Text=""></asp:Label>
            <asp:Button ID="SubmitBtn" runat="server" Text="Submit" class="btn btn-success mb-2 w-100" OnClick="SubmitBtn_Click"/>
        <a>
            <asp:Button ID="CancelBtn" runat="server" Text="Cancel" class="btn btn-danger mb-2 w-100" OnClick="CancelBtn_Click"/>
        </a>
        </div>
</asp:Content>
