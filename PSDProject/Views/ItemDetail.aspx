<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="ItemDetail.aspx.cs" Inherits="PSDProject.Views.ItemDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div style="margin: 2% 0% ">
        <div class="d-flex justify-content-around ">
            <div class="flex-left-gig">
                <h1><asp:Label ID="CategoryLbl" runat="server"></asp:Label></h1>
                <h3><asp:Label ID="ClothLbl" runat="server"></asp:Label></h3>
                <asp:Image ID="Image" runat="server" class="card-img-top title-hover" style="max-width:500px;"/>
                <h5 class="mt-3">Detail : </h5>
                <p><asp:Label ID="DescLbl" runat="server"></asp:Label></p>
            </div>
            <div class="flex-right-gig">
                <div class="card mb-3" style="width:24rem">
                    <div class="card-body">
                        <div class="d-flex justify-content-between font-weight-bold">
                            <p>Buy Now</p>
                            <asp:Label ID="PriceLbl" runat="server"></asp:Label>
                            <asp:Button ID="CheckoutBtn" runat="server" Text="Checkout" class="btn btn-outline-success" OnClick="CheckoutBtn_Click"/>
                        </div>
                    </div>
                </div>
                <asp:Panel ID="BtnPanel" runat="server" Visible="false">
                    <div class="d-flex flex-column ">
                        <asp:Button ID="EditBtn" runat="server" class="btn btn-outline-warning mb-3" Text="Edit" OnClick="EditBtn_Click"/>
                        <asp:Button ID="DeleteBtn" runat="server" class="btn btn-outline-danger" Text="Delete" OnClick="DeleteBtn_Click"/>
                    </div>
                    
                </asp:Panel>
            </div>
        </div>
        </div>
</asp:Content>
