<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="eRacunalniServis_Web.Orders.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="gvNarudzba" runat="server" AutoGenerateColumns="false" OnRowCommand="gvNarudzba_RowCommand">
        <Columns>
            <asp:BoundField DataField="Proizvodi" HeaderText="Proizvodi" />
            <asp:BoundField DataField="Kolicina" HeaderText="Količina" />
            <asp:BoundField DataField="Proizvodi.Cijena" HeaderText="Cijena" />
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>     
                    <asp:LinkButton ID="lbtnPonisti" runat="server" CommandName="cmdPonisti">Poništi</asp:LinkButton>
                </ItemTemplate>            
        </asp:TemplateField >
        </Columns>        
    </asp:GridView>
    <br />    
    <asp:Label ID="lblCijena" runat="server" Text="Ukupna cijena:" >
    </asp:Label><asp:TextBox ID="txtbCijena" runat="server" ReadOnly="True" ></asp:TextBox>        
    <br />
    <asp:Button ID="btnZakljuciSubmit" runat="server" Text="Zaključi" OnClick="btnZakljuciSubmit_Click" />
    <asp:Button ID="btnOtkazi" runat="server" Text="Otkaži" OnClick="btnOtkazi_Click" />
    </asp:Content>
