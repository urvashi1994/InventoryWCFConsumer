<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Orders.aspx.cs" Inherits="InventoryWCFConsumer.Orders" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2 colspan="2" style="background-color: Green; height: 50px; color: White;  padding-left: 30px;">Orders</h2>
    <br />          
                    
     <div class="form-group row">
        <label for="OrderNumber" class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;" >Order Numberr</label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtord_no" runat="server" placeholder="id"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="PurchaseAmount " class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;">Purchase Amount </label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtpurch_amt" runat="server" placeholder="Purchase Amount"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="OrderDate" class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;">Order Date</label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtord_date" runat="server" placeholder="Order Date"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="CustomerId" class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;">CustomerId</label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtcust_id" runat="server" placeholder="CustomerId"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="SalesmanId" class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;">SalesmanId</label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtsalesman_id" runat="server" placeholder="id"></asp:TextBox>
        </div>
    </div>
     <div class="form-group row" style="font-size: medium; padding-left: 260px;">
        <div class="col-sm-5">
            <asp:Button CssClass="btn btn-primary" ID="BtnInsert" runat="server" Text="Insert" OnClick="BtnInsert_Click" />
            <asp:Button CssClass="btn btn-primary" ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click" />
            <asp:Button CssClass="btn btn-primary" ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click" />
        </div>
    </div>

    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
</asp:Content>
