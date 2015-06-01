<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MojeNarudzbe.aspx.cs" Inherits="eRacunalniServis_Web.Orders.MojeNarudzbe" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>
                <asp:DataGrid ID="dgNarudzbe" runat="server" AllowPaging="True" AutoGenerateColumns="False" OnPageIndexChanged="dgNarudzbe_PageIndexChanged" DataKeyField="NarudzbaID" OnItemCommand="dgNarudzbe_ItemCommand">
        <PagerStyle Mode="NumericPages" />
        <Columns>            
            <asp:BoundColumn DataField="BrojNarudzbe" HeaderText="Broj narudžbe "> </asp:BoundColumn>
            <asp:BoundColumn DataField="Datum" HeaderText="Datum "> </asp:BoundColumn>
            <asp:BoundColumn DataField="Status" HeaderText="Isporučeno "> </asp:BoundColumn>
            <asp:BoundColumn DataField="Iznos" HeaderText="Iznos "> </asp:BoundColumn>
            <asp:TemplateColumn>
                <ItemTemplate>                                       
                    <asp:LinkButton ID="lbtnOtkaziNarudzbu" runat="server" CommandName="cmdOtkaziNarudzbu">Otkaži narudžbu</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateColumn>
        </Columns>
    </asp:DataGrid> 
            </td>
            <td>               
            </td>
        </tr>
    </table>
</asp:Content>
