<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Template.Master" AutoEventWireup="true" CodeBehind="Checkout.aspx.cs" Inherits="PSDProject.Views.Checkout" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="padding: 2% 10%">
        <h1>Checkout</h1>
        <div class="row mt-4">
            <div class="col-12 col-sm-6 col-md-8">
                <div class="card">
                    <div class="card-body">
                        <div>
                            <h3>
                                <asp:Label ID="NameLbl" runat="server" style="margin-top:-12px" Text=""></asp:Label>
                            </h3>
                        </div>
                        <div>
                                <asp:Image ID="Image" runat="server" class="w-50"/>
                        </div>
                        <div>
                                <h5 class="mt-3">Detail :</h5>
                                <asp:Label ID="DescriptionLbl" runat="server"></asp:Label>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-6 col-md-4">
                <div class="card">
                    <div class="card-body">
                        <div>
                            <h5>Price</h5>
                            <h5><asp:Label ID="PriceLbl" runat="server" Text="Label"></asp:Label></h5>
                            <h5>Quantity : </h5> 
                            <asp:TextBox ID="QuantityTxt" runat="server" TextMode="Number" CssClass="form-control"></asp:TextBox>
                            <asp:Button ID="SubmitBtn" runat="server" Text="Add to cart" 
                                class="btn btn-success w-100 mt-2" OnClick="SubmitBtn_Click"/>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
