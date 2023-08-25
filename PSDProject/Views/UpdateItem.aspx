<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="UpdateItem.aspx.cs" Inherits="PSDProject.Views.UpdateItem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding:2% 10%">
        <div method="post">
            <div class="form-group">
                <label for="inputTitle">Clothes Name</label>
                <asp:TextBox ID="clothesnameTxt" runat="server" class="form-control"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="inputCategory">Category</label>
                <asp:DropDownList ID="categorySelect" runat="server" class="form-control">
                    
                </asp:DropDownList>
            </div>
            <div class="form-group">
                <div class="form-grouping">
                    <label for="inputBasicPrice">Price</label>
                    <asp:TextBox ID="priceTxt" runat="server" class="form-control" TextMode="Number"></asp:TextBox>
                </div>
                <div class="form-grouping">
                    <label for="inputPrice">Description</label>
                    <asp:TextBox ID="descriptionTxt" runat="server" class="form-control" TextMode="MultiLine" Rows="6"></asp:TextBox>
                </div>
            </div>
      
            </div>
            <div class="form-group custom-file mb-5">
                <label class="form-label" for="customFile">Image</label>
                <asp:FileUpload ID="ImageFile" runat="server" class="form-control p-1" />
            </div>
            <asp:Label ID="ErrorLbl" runat="server" Text="" Visible="false" ForeColor="red"></asp:Label>
            <asp:Button ID="SubmitBtn" runat="server" Text="Submit" class="btn btn-success mb-2 w-100" OnClick="SubmitBtn_Click"/>
            <asp:Button ID="CancelBtn" runat="server" Text="Cancel" style="opacity:0.6;" class="btn btn-success mb-2 w-100" OnClick="CancelBtn_Click"/>
            <asp:Button ID="DeleteBtn" runat="server" Text="Delete" class="btn btn-danger w-100" OnClick="DeleteBtn_Click"/>
        </div>
</asp:Content>
