<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="eRacunalniServis_Web.Orders.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvNarudzba" runat="server" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="Proizvodi" HeaderText="Proizvodi" />
            <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnZakljuciSubmit" runat="server" Text="Zaključi" />
    
</asp:Content>
