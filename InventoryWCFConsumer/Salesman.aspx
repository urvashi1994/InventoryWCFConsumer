<%@ Page Title="" Language="C#" MasterPageFile="~/Inventory.Master" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="InventoryWCFConsumer.Salesman" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2 colspan="2" style="background-color: Green; height: 50px; color: White;  padding-left: 30px;">Salesman</h2>
    <br />
          
                    
     <div class="form-group row">
        <label for="SalesmanNumber" class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;" >Salesman Number</label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtsalesman_id" runat="server" placeholder="id"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="SalesmanName" class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;">Salesman Name</label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtsalesman_name" runat="server" placeholder="Salesman Name"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="City" class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;">City</label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtcity" runat="server" placeholder="City"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="Commission" class="col-sm-2 col-form-label" style="font-size: medium; padding-left: 40px;">Commission</label>
        <div class="col-sm-5">
            <asp:TextBox class="form-control" ID="txtcommission" runat="server" placeholder="Commission"></asp:TextBox>
        </div>
    </div>
     <div class="form-group row" style="font-size: medium; padding-left: 260px;">
        <div class="col-sm-5">
            <asp:Button CssClass="btn btn-primary" ID="BtnInsert" runat="server" Text="Insert" OnClick="BtnInsert_Click"></asp:Button>
            <asp:Button CssClass="btn btn-primary" ID="BtnUpdate" runat="server" Text="Update" OnClick="BtnUpdate_Click"></asp:Button>
            <asp:Button CssClass="btn btn-primary" ID="BtnDelete" runat="server" Text="Delete" OnClick="BtnDelete_Click"></asp:Button>
        </div>
    </div>

    <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>

</asp:Content>
